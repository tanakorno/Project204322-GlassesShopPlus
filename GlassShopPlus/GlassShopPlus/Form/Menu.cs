using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GlassShopPlus
{
    public partial class FormMenu : System.Windows.Forms.Form
    {
        
        public FormMenu()
        {
            InitializeComponent();
        }

        private void BTNClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Counter form = new Counter();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stock form = new Stock();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            History form = new History();
            form.ShowDialog();
        }
    }
}
