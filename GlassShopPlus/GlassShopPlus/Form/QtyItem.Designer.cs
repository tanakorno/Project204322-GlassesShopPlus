namespace GlassShopPlus
{
    partial class QtyItem
    {
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTNClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Panel PanelAddHolder;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox prPrice;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox prQty;
        private System.Windows.Forms.Button BTNBack;
        private System.Windows.Forms.Button BTNSave;

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.PanelAddHolder = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.prPrice = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.prQty = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BTNBack = new System.Windows.Forms.Button();
            this.BTNSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PanelAddHolder.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.BTNClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 138);
            this.panel1.TabIndex = 5;
            // 
            // BTNClose
            // 
            this.BTNClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNClose.BackColor = System.Drawing.Color.Transparent;
            this.BTNClose.BackgroundImage = global::GlassShopPlus.Properties.Resources.btn_close_2x;
            this.BTNClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNClose.FlatAppearance.BorderSize = 0;
            this.BTNClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNClose.ForeColor = System.Drawing.Color.Transparent;
            this.BTNClose.Location = new System.Drawing.Point(878, 0);
            this.BTNClose.Name = "BTNClose";
            this.BTNClose.Size = new System.Drawing.Size(72, 70);
            this.BTNClose.TabIndex = 1;
            this.BTNClose.TabStop = false;
            this.BTNClose.UseVisualStyleBackColor = false;
            this.BTNClose.Click += new System.EventHandler(this.BTNClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::GlassShopPlus.Properties.Resources.product_txtleft;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.labelHeader);
            this.panel2.Location = new System.Drawing.Point(0, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 90);
            this.panel2.TabIndex = 117;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(167)))), ((int)(((byte)(212)))));
            this.labelHeader.Location = new System.Drawing.Point(21, 27);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(157, 33);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "รับเข้าสินค้า";
            // 
            // PanelAddHolder
            // 
            this.PanelAddHolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelAddHolder.BackColor = System.Drawing.Color.Transparent;
            this.PanelAddHolder.Controls.Add(this.label6);
            this.PanelAddHolder.Controls.Add(this.label5);
            this.PanelAddHolder.Controls.Add(this.label4);
            this.PanelAddHolder.Controls.Add(this.label3);
            this.PanelAddHolder.Controls.Add(this.txtPrice);
            this.PanelAddHolder.Controls.Add(this.txtQty);
            this.PanelAddHolder.Controls.Add(this.txtName);
            this.PanelAddHolder.Controls.Add(this.label2);
            this.PanelAddHolder.Controls.Add(this.txtPid);
            this.PanelAddHolder.Controls.Add(this.label1);
            this.PanelAddHolder.Location = new System.Drawing.Point(457, 239);
            this.PanelAddHolder.Name = "PanelAddHolder";
            this.PanelAddHolder.Size = new System.Drawing.Size(417, 128);
            this.PanelAddHolder.TabIndex = 118;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 19);
            this.label6.TabIndex = 121;
            this.label6.Text = "ชิ้น";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 19);
            this.label5.TabIndex = 120;
            this.label5.Text = "บาท";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 119;
            this.label4.Text = "ราคา/ชิ้น";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 118;
            this.label3.Text = "จำนวนคงเหลือ";
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPrice.Location = new System.Drawing.Point(128, 100);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(137, 27);
            this.txtPrice.TabIndex = 117;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtQty
            // 
            this.txtQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQty.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtQty.Location = new System.Drawing.Point(128, 67);
            this.txtQty.Name = "txtQty";
            this.txtQty.ReadOnly = true;
            this.txtQty.Size = new System.Drawing.Size(137, 27);
            this.txtQty.TabIndex = 116;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtName.Location = new System.Drawing.Point(128, 34);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(289, 27);
            this.txtName.TabIndex = 115;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "ชื่อสินค้า";
            // 
            // txtPid
            // 
            this.txtPid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPid.Location = new System.Drawing.Point(128, 1);
            this.txtPid.Name = "txtPid";
            this.txtPid.ReadOnly = true;
            this.txtPid.Size = new System.Drawing.Size(289, 27);
            this.txtPid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "รหัสสินค้า";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(271, 37);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 19);
            this.label18.TabIndex = 28;
            this.label18.Text = "บาท";
            // 
            // prPrice
            // 
            this.prPrice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.prPrice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.prPrice.Location = new System.Drawing.Point(128, 34);
            this.prPrice.Name = "prPrice";
            this.prPrice.ReadOnly = true;
            this.prPrice.Size = new System.Drawing.Size(137, 27);
            this.prPrice.TabIndex = 26;
            this.prPrice.Text = "0.00";
            this.prPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 37);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 19);
            this.label17.TabIndex = 27;
            this.label17.Text = "ราคา";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label7.Location = new System.Drawing.Point(460, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 23);
            this.label7.TabIndex = 119;
            this.label7.Text = "รายละเอียดสินค้า";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label8.Location = new System.Drawing.Point(460, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 120;
            this.label8.Text = "สั่งซื้อสินค้า";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.prQty);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.prPrice);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Location = new System.Drawing.Point(457, 408);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(417, 62);
            this.panel3.TabIndex = 121;
            // 
            // prQty
            // 
            this.prQty.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.prQty.Location = new System.Drawing.Point(128, 1);
            this.prQty.Name = "prQty";
            this.prQty.Size = new System.Drawing.Size(137, 27);
            this.prQty.TabIndex = 29;
            this.prQty.Text = "0";
            this.prQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.prQty.TextChanged += new System.EventHandler(this.prQty_TextChanged);
            this.prQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.prQty_KeyPress);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(271, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 19);
            this.label9.TabIndex = 31;
            this.label9.Text = "ชิ้น";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 19);
            this.label10.TabIndex = 30;
            this.label10.Text = "จำนวน *";
            // 
            // BTNBack
            // 
            this.BTNBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNBack.BackColor = System.Drawing.Color.White;
            this.BTNBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTNBack.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTNBack.Location = new System.Drawing.Point(774, 556);
            this.BTNBack.Name = "BTNBack";
            this.BTNBack.Size = new System.Drawing.Size(100, 38);
            this.BTNBack.TabIndex = 122;
            this.BTNBack.TabStop = false;
            this.BTNBack.Text = "ย้อนกลับ";
            this.BTNBack.UseVisualStyleBackColor = false;
            this.BTNBack.Click += new System.EventHandler(this.BTNBack_Click);
            // 
            // BTNSave
            // 
            this.BTNSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNSave.BackColor = System.Drawing.Color.White;
            this.BTNSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTNSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTNSave.Location = new System.Drawing.Point(666, 556);
            this.BTNSave.Name = "BTNSave";
            this.BTNSave.Size = new System.Drawing.Size(100, 38);
            this.BTNSave.TabIndex = 123;
            this.BTNSave.TabStop = false;
            this.BTNSave.Text = "บันทึก";
            this.BTNSave.UseVisualStyleBackColor = false;
            this.BTNSave.Click += new System.EventHandler(this.BTNSave_Click);
            // 
            // QtyItem
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BackgroundImage = global::GlassShopPlus.Properties.Resources.product_BG;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.BTNBack);
            this.Controls.Add(this.BTNSave);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PanelAddHolder);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QtyItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PanelAddHolder.ResumeLayout(false);
            this.PanelAddHolder.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }


}