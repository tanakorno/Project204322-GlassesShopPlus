using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using MySql.Data.MySqlClient;

namespace GlassShopPlus.Entity
{
    class Function
    {
        private Color header = Color.FromArgb(43, 103, 178);
        private Color background = Color.LightGray;
        
        // Database
        private string conString()
        {
            string server   = "localhost";
            string database = "optic";
            string uid      = "root";
            string password = "";
            string charset  = "tis620";

            string connectionString;

            connectionString = "SERVER="    + server    + ";"
                             + "DATABASE="  + database  + ";"
                             + "UID="       + uid       + ";"
                             + "PASSWORD="  + password  + ";"
                             + "CHARSET="   + charset   + ";";

            return connectionString;
        }

        private void notic(object sender, string word)
        {
            TextBox tb = (TextBox)sender;
            int VisibleTime = 1000;  //in milliseconds

            ToolTip tt = new ToolTip();
            tt.Show(word, tb, tb.Width - 25, tb.Height - 15, VisibleTime);
        }

        public string dbconnect
        {
            get
            {
                return conString();
            }
            set
            {

            }
        }

        public void query(MySqlCommand cmd, MySqlConnection con)
        {
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        public string addQuote(string x)
        {
            return "\'%" + x + "%\'";
        }

        public bool pressNum(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
                return true;
            }
            else
            {
                notic(sender, "กรุณากรอกตัวเลข");
                e.Handled = true;
                return false;
            }
        }

        public void paintPanelSearch(Panel ctl)
        {
            System.Drawing.Drawing2D.LinearGradientBrush gradBrush;
            gradBrush = new System.Drawing.Drawing2D.LinearGradientBrush(new
            Point(0, 0), new Point(ctl.Width, ctl.Height), Color.White, Color.LightGray);
            Bitmap bmp = new Bitmap(ctl.Width, ctl.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(gradBrush, new Rectangle(0, 0, ctl.Width, ctl.Height));
            ctl.BackgroundImage = bmp;
            ctl.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public void paintButtonSearch(Button ctl)
        {
            System.Drawing.Drawing2D.LinearGradientBrush gradBrush;
            gradBrush = new System.Drawing.Drawing2D.LinearGradientBrush(new
            Point(0, 0), new Point(ctl.Width, ctl.Height), Color.DimGray, Color.FromArgb(85,85,85));
            Bitmap bmp = new Bitmap(ctl.Width, ctl.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(gradBrush, new Rectangle(0, 0, ctl.Width, ctl.Height));
            ctl.BackgroundImage = bmp;
            ctl.BackgroundImageLayout = ImageLayout.Stretch;
        }

    }
}
