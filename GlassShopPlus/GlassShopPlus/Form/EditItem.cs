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
    public partial class EditItem : Form
    {
        private iFunction iFt;

        private MySqlConnection con;
        private MySqlCommand cmd;

        private string[] ItemType = { "เลนส์", "กรอบแว่น", "คอนแทคเลนส์" };
        private string[] ItemTable = { "len", "frame", "contact_len" };
        private object Item { get; set; }
        private int Page { get; set; }

        public EditItem(object SelectedItem, int Page)
        {
            InitializeComponent();

            iFt = new iFunction();
            con = new MySqlConnection(iFt.dbconnect);

            this.Item = SelectedItem;
            this.Page = Page;

            InitValue();
        }

        private void InitValue()
        {
            Product p = (Product)Item;

            prPid.Text = p.Pid;
            prItemType.Text = ItemType[Page];
            prBrand.Text = p.Brand;
            prPrice.Text = p.Price.ToString("F");
    
            switch (Page)
            {
                case 0:
                    Len pl = (Len)Item;
                    prTypeLen.Text = pl.Type;
                    prSightLen.Text = pl.Sight;
                    prSPHLen.Text = pl.Sph.ToString();
                    prCYLLen.Text = pl.Cyl.ToString();
                    PanelFrame.Visible = false;
                    PanelContact.Visible = false;
                    break;
                case 1:
                    Frame pf = (Frame)Item;
                    prClass.Text = pf.Class;
                    prColor.Text = pf.Color;
                    PanelLen.Visible = false;
                    PanelContact.Visible = false;
                    PanelValue.Location = new Point(0, PanelFrame.Location.Y + PanelFrame.Height);
                    break;
                case 2:
                    Contact pc = (Contact)Item;
                    prDuration.Text = pc.Duration;
                    prSightContact.Text = pc.Sight;
                    prSPHContact.Text = pc.Sph.ToString();
                    PanelLen.Visible = false;
                    PanelFrame.Visible = false;
                    break;
            }
        }

        private void BTNEdit_Click(object sender, EventArgs e)
        {
            string sql = "";
            
            sql  = "UPDATE  product ";
            sql += "SET     price = @price ";
            sql += "WHERE   pid = @pid";
            
            cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@pid", prPid.Text);
            cmd.Parameters.AddWithValue("@price", prPrice.Text);
            cmd.CommandType = System.Data.CommandType.Text;
            iFt.query(cmd, con);

            switch (Page)
            {
                case 0:
                    sql  = "UPDATE  len ";
                    sql += "SET     brand = @brand, type = @type, sight = @sight, sph = @sph, cyl = @cyl ";
                    sql += "WHERE   pid = @pid";

                    cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@pid", prPid.Text);
                    cmd.Parameters.AddWithValue("@brand", prBrand.Text);
                    cmd.Parameters.AddWithValue("@type", prTypeLen.Text);
                    cmd.Parameters.AddWithValue("@sight", prSightLen.Text);
                    cmd.Parameters.AddWithValue("@sph", prSPHLen.Text);
                    cmd.Parameters.AddWithValue("@cyl", prCYLLen.Text);
                    cmd.CommandType = System.Data.CommandType.Text;

                    iFt.query(cmd, con);

                    break;
                case 1:
                    sql  = "UPDATE  frame ";
                    sql += "SET     brand = @brand, class = @class, color = @color ";
                    sql += "WHERE   pid = @pid";

                    cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@pid", prPid.Text);
                    cmd.Parameters.AddWithValue("@brand", prBrand.Text);
                    cmd.Parameters.AddWithValue("@class", prClass.Text);
                    cmd.Parameters.AddWithValue("@color", prColor.Text);
                    cmd.CommandType = System.Data.CommandType.Text;

                    iFt.query(cmd, con);
                    break;
                case 2:
                    sql  = "UPDATE  contact_len ";
                    sql += "SET     brand = @brand, duration = @duration, sight = @sight, sph = @sph ";
                    sql += "WHERE   pid = @pid";

                    cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@pid", prPid.Text);
                    cmd.Parameters.AddWithValue("@brand", prBrand.Text);
                    cmd.Parameters.AddWithValue("@duration", prDuration.Text);
                    cmd.Parameters.AddWithValue("@sight", prSightContact.Text);
                    cmd.Parameters.AddWithValue("@sph", prSPHContact.Text);
                    cmd.CommandType = System.Data.CommandType.Text;

                    iFt.query(cmd, con);

                    break;
            }
            
            this.Close();
        }
        private void BTNBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*private void BTNDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ต้องการลบสินค้าหรือไม่", "", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                string sql = "";

                sql = "DELETE FROM product WHERE pid = @pid";
                cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@pid", prPid.Text);
                cmd.CommandType = System.Data.CommandType.Text;
                iFt.query(cmd, con);

                sql = "DELETE FROM " + table[Page] + " WHERE pid = @pid";
                cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@pid", prPid.Text);
                cmd.CommandType = System.Data.CommandType.Text;
                iFt.query(cmd, con);

                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }*/

        private void BTNClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
