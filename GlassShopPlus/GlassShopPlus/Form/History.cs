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
    public partial class History : Form
    {
        private iFunction iFt;

        private MySqlConnection con;
        private MySqlCommand cmd;
        private MySqlDataAdapter adapter;
        private DataTable dt;

        private float SumBuy { get; set; }
        private float SumSell { get; set; }

        public History()
        {
            InitializeComponent();

            iFt = new iFunction();
            con = new MySqlConnection(iFt.dbconnect);

            SumBuy = 0;
            SumSell = 0;

            timer1.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;

            txtTime.Text = today.ToString("HH:mm:ss น.");
            txtDate.Text = today.ToString("dd/MM/yyyy");
        }

        private DataTable selectData(string sql)
        {
            DataTable temp = new DataTable();
           
            try
            {
                con.Open();
                cmd = new MySqlCommand(sql, con);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(temp);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }

            return temp;
        }
        
        private void loadHistory(string start, string stop, int status)
        {
            dgvProduct.Rows.Clear();

            DataTable sell = new DataTable();
            DataTable buy = new DataTable();

            string sql = "";

            sql = "SELECT rd.pid, rd.qty, rd.price ";
            sql += "FROM receipt r, receipt_detail rd ";
            sql += "WHERE r.receipt_id = rd.rid ";
            sql += "AND r.receipt_date BETWEEN \'" + start + "\' ";
            sql += "AND \'" + stop + "\' ";
            sql += "+ INTERVAL 1 DAY";

            sell = selectData(sql);

            foreach (DataRow row in sell.Rows)
            {
                float temp = Int32.Parse(row[1].ToString()) * Int32.Parse(row[2].ToString());
                SumSell += temp;
                dgvProduct.Rows.Add(dgvProduct.Rows.Count + 1, "ขาย " + row[0].ToString(), temp, 0);
            }

            sql = "SELECT pid, qty, price ";
            sql += "FROM invoice ";
            sql += "WHERE order_date BETWEEN \'" + start + "\' ";
            sql += "AND \'" + stop + "\' ";
            sql += "+ INTERVAL 1 DAY";

            buy = selectData(sql);
                
            foreach (DataRow row in buy.Rows)
            {
                float temp = Int32.Parse(row[1].ToString()) * Int32.Parse(row[2].ToString());
                SumBuy += temp;
                dgvProduct.Rows.Add(dgvProduct.Rows.Count + 1, "ซื้อ " + row[0].ToString(), 0, temp);
            }

            txtIncome.Text = SumSell.ToString("F");
            txtIncome.ForeColor = Color.Green;
            txtOutcome.Text = SumBuy.ToString("F");
            txtOutcome.ForeColor = Color.Red;
            txtRealIncome.Text = (SumSell - SumBuy).ToString("F");
            txtRealIncome.ForeColor = (SumSell - SumBuy > 0) ? Color.Green : Color.Red;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            BTNSearch.Enabled = checkBoxSell.Checked || checkBoxBuy.Checked;
        }

        private void BTNSearch_Click(object sender, EventArgs e)
        {
            string start = txtStart.Value.ToString("yyyy-MM-dd");
            string stop = txtStop.Value.ToString("yyyy-MM-dd");

            start = (Int32.Parse(start.Split('-')[0]) - 543).ToString() + "-" + start.Split('-')[1] + "-" + start.Split('-')[2];
            stop = (Int32.Parse(stop.Split('-')[0]) - 543).ToString() + "-" + stop.Split('-')[1] + "-" + stop.Split('-')[2];

            int status = 0;

            if (checkBoxSell.Checked && checkBoxBuy.Checked)
            {
                status = 0;
            }
            else if (checkBoxSell.Checked)
            {
                status = 1;
            }
            else if (checkBoxBuy.Checked)
            {
                status = 2;
            }

            loadHistory(start, stop, status);
        }

        private void BTNClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
