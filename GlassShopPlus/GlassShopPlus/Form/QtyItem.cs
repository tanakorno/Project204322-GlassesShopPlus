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
    public partial class QtyItem : Form
    {
        private iFunction iFt = new iFunction();

        private Product Item { get; set; }
        private bool Correct { get; set; }
        private string[] ItemType = { "เลนส์", "กรอบแว่น", "คอนแทคเลนส์" };

        private MySqlConnection con;
        private MySqlCommand cmd;

        public QtyItem(object obj)
        {
            InitializeComponent();

            Item = (Product)obj;
            Correct = false;
            int index = Int32.Parse(Item.Pid[0].ToString()) - 1;

            con = new MySqlConnection(iFt.dbconnect);

            txtPid.Text = Item.Pid;
            txtQty.Text = Item.Qty.ToString();
            txtPrice.Text = Item.Price.ToString() + ".00";

            switch (index)
            {
                case 0:
                    txtName.Text = ((Len)Item).getName();
                    break;
                case 1:
                    txtName.Text = ((Frame)Item).getName();
                    break;
                case 2:
                    txtName.Text = ((Contact)Item).getName();
                    break;
            }
        }

      

        private void prQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            Correct = iFt.pressNum(sender, e);
        }

        private void prQty_TextChanged(object sender, EventArgs e)
        {
            if (Correct)
            {
                int qty = (prQty.Text != String.Empty) ? Int32.Parse(prQty.Text) : 0;
                prPrice.Text = (Item.Price * qty).ToString() + ".00";
            }
            else
            {
                prPrice.Text = "0.00";
            }
        }

        private void updateQty()
        {
            string sql = "";
            int qty = 0;

            qty = Int32.Parse(txtQty.Text) + Int32.Parse(prQty.Text);

            sql = "UPDATE  product ";
            sql += "SET     qty = @qty ";
            sql += "WHERE   pid = @pid";

            cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@pid", txtPid.Text);
            cmd.Parameters.AddWithValue("@qty", qty);
            cmd.CommandType = System.Data.CommandType.Text;
            iFt.query(cmd, con);
        }
        private void updatePO()
        {
            string sql = "";
            int qty = 0;

            qty = Int32.Parse(prQty.Text);
       
            sql = "INSERT INTO invoice ";
            sql += "VALUES (@pid, @qty, @price, NOW())";

            cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@pid", txtPid.Text);
            cmd.Parameters.AddWithValue("@qty", qty);
            cmd.Parameters.AddWithValue("@price", txtPrice.Text);
            cmd.CommandType = System.Data.CommandType.Text;
            iFt.query(cmd, con);
        }
        private void BTNSave_Click(object sender, EventArgs e)
        {
            updateQty();
            updatePO();
            this.Close();
        }

        private void BTNBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
