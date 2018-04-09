using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Globalization;
using System.Threading;

using MySql.Data.MySqlClient;
using iFunction = GlassShopPlus.Entity.Function;
using Product = GlassShopPlus.Entity.Product;
using Len = GlassShopPlus.Entity.Len;
using Frame = GlassShopPlus.Entity.Frame;
using Contact = GlassShopPlus.Entity.Contact_Len;

namespace GlassShopPlus
{
    public partial class Counter : Form
    {
        private iFunction iFt;

        private MySqlConnection con;
        private MySqlCommand cmd;
        private MySqlDataAdapter adapter;
        private DataTable dt;

        private Product Item { get; set; }
        private float Sum { get; set; }

        public Counter()
        {
            InitializeComponent();

            iFt = new iFunction();
            con = new MySqlConnection(iFt.dbconnect);

            Sum = 0;
            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;

            txtTime.Text = today.ToString("HH:mm:ss น.");
            txtDate.Text = today.ToString("dd/MM/yyyy");
        }
        private void resetAll()
        {
            Item = null;
            Sum = 0.00f;

            txtSum.Text = "0.00";
            txtGet.Text = "0.00";
            txtSubtract.Text = "0.00";

            BTNAdd.Enabled = false;
            BTNSubmit.Enabled = false;
            prPid.Text = string.Empty;
            txtName.Text = string.Empty;

            dgvProduct.Rows.Clear();
        }
        private bool loadProduct()
        {
            bool found = false;
            string sql = "";
            string pid = prPid.Text;

            if (prPid.Text == string.Empty) return found;

            if (pid[0] == '1')
            {
                sql += "SELECT  * ";
                sql += "FROM    product, len ";
                sql += "WHERE   product.pid = len.pid ";
            }
            else if (pid[0] == '2')
            {
                sql += "SELECT  * ";
                sql += "FROM    product, frame ";
                sql += "WHERE   product.pid = frame.pid ";
            }
            else
            {
                sql += "SELECT  * ";
                sql += "FROM    product, contact_len ";
                sql += "WHERE   product.pid = contact_len.pid ";
            }

            sql += "AND product.pid = \'" + pid + "\'";

            cmd = new MySqlCommand(sql, con);
            //MessageBox.Show(sql);
            try
            {
                con.Open();

                dt = new DataTable();
                cmd = new MySqlCommand(sql, con);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    if (pid[0] == '1')
                    {
                        Len item = new Len();
                        item.Pid = row[0].ToString();
                        item.Qty = (int)row[1];
                        item.Price = (float)row[2];
                        item.Brand = row[4].ToString();
                        item.Type = row[5].ToString();
                        item.Sight = row[6].ToString();
                        item.Sph = (float)row[7];
                        item.Cyl = (float)row[8];
                        Item = item;
                        Name = item.getName();
                    }
                    else if (pid[0] == '2')
                    {
                        Frame item = new Frame();
                        item.Pid = row[0].ToString();
                        item.Qty = (int)row[1];
                        item.Price = (float)row[2];
                        item.Brand = row[4].ToString();
                        item.Class = row[5].ToString();
                        item.Color = row[6].ToString();
                        Item = item;
                        Name = item.getName();
                    }
                    else
                    {
                        Contact item = new Contact();
                        item.Pid = row[0].ToString();
                        item.Qty = (int)row[1];
                        item.Price = (float)row[2];
                        item.Brand = row[4].ToString();
                        item.Duration = row[5].ToString();
                        item.Sight = row[6].ToString();

                        item.Sph = (float)row[7];
                        Item = item;
                        Name = item.getName();
                    }
                    txtName.Text = Name;
                    found = true;
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }

            return found;
        }    
        private string getReceiptId()
        {
            string sql = "";
            string ans = "0";
            bool found = false;

            sql = "SELECT * FROM receipt ORDER BY receipt_id DESC LIMIT 1 ";
            cmd = new MySqlCommand(sql, con);
            try
            {
                con.Open();

                dt = new DataTable();
                cmd = new MySqlCommand(sql, con);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    ans = row[0].ToString();
                    found = true;
                }

                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
            }

            ans = (Int32.Parse(ans)+1).ToString("000000");

            return ans;
        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            dgvProduct_addItem();
        }
        private void BTNSearch_Click(object sender, EventArgs e)
        {
            bool found = loadProduct();
            if (found)
            {
                if (Item.Qty > 0)
                {
                    BTNAdd.Enabled = found;
                }
                else
                {
                    MessageBox.Show("        สินค้าหมด ไม่สามารถเพิ่มได้");
                }
            }
            else
            {
                MessageBox.Show("        ไม่พบรหัสสินค้า กรุณากรอกใหม่");
            }

        }
        private void BTNSubmit_Click(object sender, EventArgs e)
        {
            string sql  = "";
            string date = "";
            string rid  = "";

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

            rid = getReceiptId();
            date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            sql = "INSERT INTO receipt VALUES (@rid, @date, @money)";
            cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@rid", rid);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@money", txtGet.Text);
            cmd.CommandType = System.Data.CommandType.Text;

            iFt.query(cmd, con);

            foreach (DataGridViewRow row in dgvProduct.Rows)
            {
                string curPid = row.Cells["ID"].Value.ToString();
                string curQty = row.Cells["qty"].Value.ToString();
                string curPrice = row.Cells["price"].Value.ToString();

                sql = "INSERT INTO receipt_detail VALUES (@rid, @pid, @qty, @price)";
                cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@rid", rid);
                cmd.Parameters.AddWithValue("@pid", curPid);
                cmd.Parameters.AddWithValue("@qty", curQty);
                cmd.Parameters.AddWithValue("@price", Int32.Parse(curPrice) / Int32.Parse(curQty));
                cmd.CommandType = System.Data.CommandType.Text;
                iFt.query(cmd, con);

                sql = "UPDATE product SET qty = qty - @qty WHERE pid = @pid";
                cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@pid", curPid);
                cmd.Parameters.AddWithValue("@qty", curQty);
                cmd.CommandType = System.Data.CommandType.Text;
                iFt.query(cmd, con);
            }
            resetAll();
        }
        private void BTNReset_Click(object sender, EventArgs e)
        {
            resetAll();
        }
        private void BTNBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BTNClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }          
        
        // Validate
        private void prPid_TextChanged(object sender, EventArgs e)
        {
            BTNAdd.Enabled = false;
            txtName.Text = string.Empty;
        }
        private void prPid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter))
            {
                if (BTNAdd.Enabled == false)
                {
                    BTNAdd.Enabled = loadProduct();
                }
                else
                {
                    dgvProduct_addItem();
                }
            }
        }

        private void dgvProduct_addItem()
        {
            bool found = false;

            //
            //Int32.Parse(dgvProduct.Rows[0].ToString());

            foreach (DataGridViewRow row in dgvProduct.Rows)
            {
                string curPid = row.Cells["ID"].Value.ToString();
                //MessageBox.Show(curPid);
                if (Item.Pid == curPid && !found)
                {
                    int newQty = Int16.Parse(row.Cells["qty"].Value.ToString()) + 1;

                    row.Cells["qty"].Value = newQty;
                    row.Cells["price"].Value = Item.Price * newQty;
                    found = true;

                    Sum += Item.Price;

                    break;
                }
            }

            if (!found)
            {
                dgvProduct.Rows.Add(dgvProduct.RowCount + 1, Item.Pid, Name, '1', Item.Price, " ลบ");
                Sum += Item.Price;
            }

            txtSum.Text = Sum.ToString("F");
            prPid.Text = string.Empty;
            txtName.Text = string.Empty;
            BTNAdd.Enabled = false;
        }

        private void txtGet_TextChanged(object sender, EventArgs e)
        {
            float sum = 0.0f;
            float num = 0.0f;

            float.TryParse(txtSum.Text, out sum);
            float.TryParse(txtGet.Text, out num);

            txtGet.Text = num.ToString("F");
            txtSubtract.Text = (num - sum).ToString("F");

            float tmp = 0.0f;
            float.TryParse(txtGet.Text, out tmp);
            
            BTNSubmit.Enabled = (tmp >= Sum);
            
        }
        private void txtSubtract_TextChanged(object sender, EventArgs e)
        {
            float tmp = 0.0f;
            float.TryParse(txtSubtract.Text, out tmp);

            Color clr;

            if (tmp == 0) clr = Color.Black;
            else if (tmp > 0) clr = Color.Green;
            else clr = Color.Red;

            txtSubtract.ForeColor = clr;
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvProduct.Columns["delete"].Index)
                {
                    Sum -= float.Parse(dgvProduct.Rows[e.RowIndex].Cells["price"].Value.ToString());
                    txtSum.Text = Sum.ToString("F");
                    dgvProduct.Rows.RemoveAt(e.RowIndex); 
                }
            }
        }
    }
}
