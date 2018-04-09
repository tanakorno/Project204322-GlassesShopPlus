using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using iFunction = GlassShopPlus.Entity.Function;
using Product = GlassShopPlus.Entity.Product;
using Len = GlassShopPlus.Entity.Len;
using Frame = GlassShopPlus.Entity.Frame;
using Contact = GlassShopPlus.Entity.Contact_Len;

namespace GlassShopPlus
{
    public partial class Stock : Form
    {
        private iFunction iFt;

        private MySqlConnection con;
        private MySqlCommand cmd;
        private MySqlDataAdapter adapter;
        private DataTable dt;

        private string[] ItemType = { "เลนส์", "กรอบแว่น", "คอนแทคเลนส์" };
        private string[] ItemTable = { "len", "frame", "contact_len" };

        private object[] listItem = new object[25];
        private int Page { get; set; }

        private string txtPO = " เติม";
        private string txtEdit = "แก้ไข";
        private string txtDelete = "  ลบ";

        public Stock()
        {
            InitializeComponent();

            iFt = new iFunction();
            con = new MySqlConnection(iFt.dbconnect);

            Panel[] pnl = { PanelLen, PanelFrame, PanelContact };
            foreach (Panel p in pnl)
            {
                p.Visible = false;
            }

        }

        // Navigation Search
        private void BTNPanelLen_Click(object sender, EventArgs e)
        {
            PanelLen.Visible = true;
            PanelFrame.Visible = false;
            PanelContact.Visible = false;
            BTNPanelFrame.Location = new Point(3, 54 + PanelLen.Height);
            BTNPanelContact.Location = new Point(3, 104 + PanelLen.Height);
        }
        private void BTNPanelFrame_Click(object sender, EventArgs e)
        {
            PanelLen.Visible = false;
            PanelFrame.Visible = true;
            PanelContact.Visible = false;
            BTNPanelFrame.Location = new Point(3, 54);
            BTNPanelContact.Location = new Point(3, 104 + PanelLen.Height);
        }
        private void BTNPanelContact_Click(object sender, EventArgs e)
        {
            PanelLen.Visible = false;
            PanelFrame.Visible = false;
            PanelContact.Visible = true;
            BTNPanelFrame.Location = new Point(3, 54);
            BTNPanelContact.Location = new Point(3, 104);
        }

        //
        // Search Query
        //
        private string whereLen()
        {
            string whr = "";

            if (prLSight.Text != String.Empty)
            {
                whr += " AND len.sight LIKE " + iFt.addQuote(prLSight.Text);
            }

            if (prLType.Text != String.Empty)
            {
                whr += " AND len.type LIKE " + iFt.addQuote(prLType.Text);
            }

            if (prLBrand.Text != String.Empty)
            {
                whr += " AND len.brand LIKE " + iFt.addQuote(prLBrand.Text);
            }

            if (prLSPH.Text != String.Empty)
            {
                whr += " AND len.sph = " + iFt.addQuote(prLSPH.Text);
            }

            if (prLCYL.Text != String.Empty)
            {
                whr += " AND len.cyl = " + iFt.addQuote(prLCYL.Text);
            }

            if (prLMinP.Text != String.Empty)
            {
                whr += " AND product.price >= " + iFt.addQuote(prLMinP.Text);
            }

            if (prLMaxP.Text != String.Empty)
            {
                whr += " AND product.price <= " + iFt.addQuote(prLMaxP.Text);
            }

            return whr;
        }
        private string whereFrame()
        {
            string whr = "";

            if (prFBrand.Text != String.Empty)
            {
                whr += " AND frame.brand LIKE " + iFt.addQuote(prFBrand.Text);
            }

            if (prFClass.Text != String.Empty)
            {
                whr += " AND frame.class LIKE " + iFt.addQuote(prFClass.Text);
            }

            if (prFColor.Text != String.Empty)
            {
                whr += " AND frame.color LIKE " + iFt.addQuote(prFColor.Text);
            }

            if (prFMinP.Text != String.Empty)
            {
                whr += " AND product.price >= " + iFt.addQuote(prFMinP.Text);
            }

            if (prFMaxP.Text != String.Empty)
            {
                whr += " AND product.price <= " + iFt.addQuote(groupBox3.Text);
            }

            return whr;
        }
        private string whereContact()
        {
            string whr = "";

            if (prCSight.Text != String.Empty)
            {
                whr += " AND contact_len.sight LIKE " + iFt.addQuote(prCSight.Text);
            }

            if (prCDuration.Text != String.Empty)
            {
                whr += " AND contact_len.duration LIKE " + iFt.addQuote(prCDuration.Text);
            }

            if (prCBrand.Text != String.Empty)
            {
                whr += " AND contact_len.brand LIKE " + iFt.addQuote(prCBrand.Text);
            }

            if (prCSPH.Text != String.Empty)
            {
                whr += " AND contact_len.sph = " + iFt.addQuote(prLSPH.Text);
            }

            if (prCMinP.Text != String.Empty)
            {
                whr += " AND product.price >= " + iFt.addQuote(prCMinP.Text);
            }

            if (prCMaxP.Text != String.Empty)
            {
                whr += " AND product.price <= " + iFt.addQuote(prCMaxP.Text);
            }

            return whr;
        }

        private void loadLen()
        {
            Page = 0;

            string sql = "";
            string whr = whereLen();

            sql += "SELECT  * ";
            sql += "FROM    product, len ";
            sql += "WHERE   product.pid = len.pid";
            sql += whr;

            try
            {
                int count = 0;
                con.Open();

                dt = new DataTable();
                cmd = new MySqlCommand(sql, con);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                dgvProduct.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    Len item = new Len();
                    listItem[count] = item;

                    item.Pid = row[0].ToString();
                    item.Qty = (int)row[1];
                    item.Price = (float)row[2];

                    item.Brand = row[4].ToString();
                    item.Type = row[5].ToString();
                    item.Sight = row[6].ToString();
                    item.Sph = (float)row[7];
                    item.Cyl = (float)row[8];

                    dgvProduct.Rows.Add(item.Pid, item.getName(), item.Qty, item.Price, txtPO, txtEdit, txtDelete);

                    count++;
                }

                con.Close();

                if (count > 0)
                {
                    errorBox.Text = count.ToString() + " matches found.";
                }
                else
                {
                    errorBox.Text = "not found.";
                }
            }
            catch (Exception ex)
            {
                errorBox.Text = ex.ToString();
                con.Close();
            }
        }
        private void loadFrame()
        {
            Page = 1;

            string sql = "";
            string whr = whereFrame();

            sql += "SELECT  * ";
            sql += "FROM    product, frame ";
            sql += "WHERE   product.pid = frame.pid";
            sql += whr;

            // MessageBox.Show(sql);

            try
            {
                int count = 0;
                con.Open();

                dt = new DataTable();
                cmd = new MySqlCommand(sql, con);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                dgvProduct.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    Frame item = new Frame();
                    listItem[count] = item;

                    item.Pid = row[0].ToString();
                    item.Qty = (int)row[1];
                    item.Price = (float)row[2];

                    item.Brand = row[4].ToString();
                    item.Class = row[5].ToString();
                    item.Color = row[6].ToString();

                    dgvProduct.Rows.Add(item.Pid, item.getName(), item.Qty, item.Price, txtPO, txtEdit, txtDelete);

                    count++;
                }

                con.Close();

                if (count > 0)
                {
                    errorBox.Text = count.ToString() + " matches found.";
                }
                else
                {
                    errorBox.Text = "not found.";
                }
            }
            catch (Exception ex)
            {
                errorBox.Text = ex.ToString();
                con.Close();
            }
        }
        private void loadContact()
        {
            Page = 2;

            string sql = "";
            string whr = whereContact();

            sql = " SELECT  *";
            sql += " FROM    product, contact_len";
            sql += " WHERE   product.pid = contact_len.pid";
            sql += whr;

            try
            {
                int count = 0;
                con.Open();

                dt = new DataTable();
                cmd = new MySqlCommand(sql, con);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                dgvProduct.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    Contact item = new Contact();
                    listItem[count] = item;

                    item.Pid = row[0].ToString();
                    item.Qty = (int)row[1];
                    item.Price = (float)row[2];

                    item.Brand = row[4].ToString();
                    item.Duration = row[5].ToString();
                    item.Sight = row[6].ToString();
                    item.Sph = (float)row[7];

                    dgvProduct.Rows.Add(item.Pid, item.getName(), item.Qty, item.Price, txtPO, txtEdit, txtDelete);

                    count++;
                }

                con.Close();

                if (count > 0)
                {
                    errorBox.Text = count.ToString() + " matches found.";
                }
                else
                {
                    errorBox.Text = "not found.";
                }
            }
            catch (Exception ex)
            {
                errorBox.Text = ex.ToString();
                con.Close();
            }
        }
        private void loadProduct()
        {
            switch (Page)
            {
                case 0:
                    loadLen();
                    break;
                case 1:
                    loadFrame();
                    break;
                case 2:
                    loadContact();
                    break;
            }
        }

        private void deleteProduct(string pid)
        {
            DialogResult dialogResult = MessageBox.Show("ต้องการลบสินค้าหรือไม่", "", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                string sql = "";

                sql = "DELETE FROM purchase_order WHERE pid = @pid";
                cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@pid", pid);
                cmd.CommandType = System.Data.CommandType.Text;
                iFt.query(cmd, con);

                sql = "DELETE FROM product WHERE pid = @pid";
                cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@pid", pid);
                cmd.CommandType = System.Data.CommandType.Text;
                iFt.query(cmd, con);

                sql = "DELETE FROM " + ItemTable[Page] + " WHERE pid = @pid";
                cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@pid", pid);
                cmd.CommandType = System.Data.CommandType.Text;
                iFt.query(cmd, con);
                
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
        //
        // Button
        //
        private void BTNSearchA_Click(object sender, EventArgs e)
        {
            loadLen();
        }
        private void BTNResetA_Click(object sender, EventArgs e)
        {
            prLSight.SelectedIndex = -1;
            prLType.SelectedIndex = -1;
            prLBrand.SelectedIndex = -1;
            prLSPH.Text = String.Empty;
            prLCYL.Text = String.Empty;
            prLMinP.Text = String.Empty;
            prLMaxP.Text = String.Empty;
        }
  
        private void BTNSearchB_Click(object sender, EventArgs e)
        {
            loadFrame();
        }
        private void BTNResetB_Click(object sender, EventArgs e)
        {
            prFBrand.SelectedIndex = -1;
            prFClass.SelectedIndex = -1;
            prFColor.SelectedIndex = -1;
            prFMinP.Text = String.Empty;
            prFMaxP.Text = String.Empty;
        }
       
        private void BTNSearchC_Click(object sender, EventArgs e)
        {
            loadContact();
        }
        private void BTNResetC_Click(object sender, EventArgs e)
        {
            prCSight.SelectedIndex = -1;
            prCDuration.SelectedIndex = -1;
            prCBrand.SelectedIndex = -1;
            prCSPH.Text = String.Empty;
            prCMinP.Text = String.Empty;
            prCMaxP.Text = String.Empty;
        }

        private void BTNAddItem_Click(object sender, EventArgs e)
        {
            AddItem form = new AddItem();
            form.ShowDialog();

            switch (Page)
            {
                case 0:
                    loadLen();
                    break;
                case 1:
                    loadFrame();
                    break;
                case 2:
                    loadContact();
                    break;
            }
        }
        private void BTNClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvProduct.Columns["edit"].Index)
                {
                    EditItem form = new EditItem(listItem[e.RowIndex], Page);
                    form.ShowDialog();
                    loadProduct();
                }
                else if (e.ColumnIndex == dgvProduct.Columns["delete"].Index)
                {
                    deleteProduct(((Product)listItem[e.RowIndex]).Pid);
                    loadProduct();
                }
                else if (e.ColumnIndex == dgvProduct.Columns["po"].Index)
                {
                    QtyItem form = new QtyItem(listItem[e.RowIndex]);
                    form.ShowDialog();
                    loadProduct();
                }
            }
        }

        private void BTNBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
