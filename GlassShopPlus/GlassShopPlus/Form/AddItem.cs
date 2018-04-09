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
using Len = GlassShopPlus.Entity.Len;
using Frame = GlassShopPlus.Entity.Frame;
using Contact = GlassShopPlus.Entity.Contact_Len;

namespace GlassShopPlus
{
    public partial class AddItem : Form
    {
        private iFunction iFt;

        private MySqlConnection con;
        private MySqlCommand cmd;

        private int page = 0;

        public AddItem()
        {
            InitializeComponent();

            iFt = new iFunction();
            con = new MySqlConnection(iFt.dbconnect);

            Panel[] pnl = { PanelLen, PanelFrame, PanelContact };
            RadioButton[] rdbtn = { RDBTNLen, RDBTNFrame, RDBTNContact };

            foreach (Panel p in pnl)
            {
                p.Visible = false;
            }

            rdbtn[0].Select();
            pnl[0].Visible = true;
        }

        private void RDBTN_CheckedChanged(object sender, EventArgs e)
        {
            int N = 3;

            Panel[] pnl = { PanelLen, PanelFrame, PanelContact };
            RadioButton[] rdbtn = { RDBTNLen, RDBTNFrame, RDBTNContact };

            for (int i = 0; i < N; i++)
            {
                if (rdbtn[i] == (RadioButton)sender)
                {
                    page = i;
                    pnl[i].Visible = true;
                    PanelValue.Location = new Point(0, pnl[i].Location.Y + pnl[i].Height);
                }
                else
                {
                    pnl[i].Visible = false;
                }
            }
        }

        private void insertItem()
        {
            string sql = "";

            // product
            sql = "INSERT INTO product VALUES(@pid, @qty, @price)";
            cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@pid", prPid.Text);
            cmd.Parameters.AddWithValue("@qty", 0);
            cmd.Parameters.AddWithValue("@price", prPrice.Text);
            cmd.CommandType = System.Data.CommandType.Text;
            iFt.query(cmd, con);
            
            // child of product
            switch (page)
            {
                case 0:
                    sql = "INSERT INTO len VALUES(@pid, @brand, @type, @sight, @sph, @cyl)";
                    cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@pid", prPid.Text);
                    cmd.Parameters.AddWithValue("@brand", prBrand.Text);
                    cmd.Parameters.AddWithValue("@type", prTypeLen.Text);
                    cmd.Parameters.AddWithValue("@sight", prSightLen.Text);
                    cmd.Parameters.AddWithValue("@sph", prSPHLen.Text);
                    cmd.Parameters.AddWithValue("@cyl", prCYLLen.Text);
                    break;
                case 1:
                    sql = "INSERT INTO frame VALUES(@pid, @brand, @class, @color)";
                    cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@pid", prPid.Text);
                    cmd.Parameters.AddWithValue("@brand", prBrand.Text);
                    cmd.Parameters.AddWithValue("@class", prClass.Text);
                    cmd.Parameters.AddWithValue("@color", prColor.Text);
                    break;
                case 2:
                    sql = "INSERT INTO contact_len VALUES(@pid, @brand, @duration, @sight, @sph)";
                    cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@pid", prPid.Text);
                    cmd.Parameters.AddWithValue("@brand", prBrand.Text);
                    cmd.Parameters.AddWithValue("@duration", prDuration.Text);
                    cmd.Parameters.AddWithValue("@sight", prSightContact.Text);
                    cmd.Parameters.AddWithValue("@sph", prSPHContact.Text);
                    break;
            }

            iFt.query(cmd, con);
        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            insertItem();
            MessageBox.Show("เพิ่มสินค้าสำเร็จ");
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
