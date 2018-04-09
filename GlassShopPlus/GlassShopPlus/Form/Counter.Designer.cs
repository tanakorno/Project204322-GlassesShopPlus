namespace GlassShopPlus
{
    partial class Counter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNClose = new System.Windows.Forms.Button();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.Seq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.prPid = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.BTNAdd = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BTNSearch = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGet = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSubtract = new System.Windows.Forms.TextBox();
            this.BTNSubmit = new System.Windows.Forms.Button();
            this.BTNReset = new System.Windows.Forms.Button();
            this.BTNBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(950, 100);
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
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToResizeRows = false;
            this.dgvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduct.ColumnHeadersHeight = 26;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seq,
            this.ID,
            this.name,
            this.qty,
            this.price,
            this.delete});
            this.dgvProduct.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvProduct.Location = new System.Drawing.Point(13, 174);
            this.dgvProduct.MultiSelect = false;
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersVisible = false;
            this.dgvProduct.RowHeadersWidth = 30;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 10.25F);
            dataGridViewCellStyle4.NullValue = "-";
            this.dgvProduct.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProduct.RowTemplate.Height = 30;
            this.dgvProduct.RowTemplate.ReadOnly = true;
            this.dgvProduct.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(625, 464);
            this.dgvProduct.TabIndex = 4;
            this.dgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellContentClick);
            // 
            // Seq
            // 
            this.Seq.FillWeight = 20F;
            this.Seq.HeaderText = "No.";
            this.Seq.Name = "Seq";
            this.Seq.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.FillWeight = 40F;
            this.ID.HeaderText = "รหัสสินค้า";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.FillWeight = 120F;
            this.name.HeaderText = "ชื่อสินค้า";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.NullValue = null;
            this.qty.DefaultCellStyle = dataGridViewCellStyle2;
            this.qty.FillWeight = 40F;
            this.qty.HeaderText = "จำนวน";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.price.DefaultCellStyle = dataGridViewCellStyle3;
            this.price.FillWeight = 40F;
            this.price.HeaderText = "รวมเป็นเงิน";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.delete.FillWeight = 20F;
            this.delete.HeaderText = "";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 103;
            this.label1.Text = "รหัสสินค้า";
            // 
            // prPid
            // 
            this.prPid.BackColor = System.Drawing.Color.White;
            this.prPid.Location = new System.Drawing.Point(92, 12);
            this.prPid.MaxLength = 6;
            this.prPid.Name = "prPid";
            this.prPid.Size = new System.Drawing.Size(80, 27);
            this.prPid.TabIndex = 1;
            this.prPid.TextChanged += new System.EventHandler(this.prPid_TextChanged);
            this.prPid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.prPid_KeyPress);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtName.Location = new System.Drawing.Point(248, 12);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(304, 27);
            this.txtName.TabIndex = 107;
            this.txtName.TabStop = false;
            // 
            // BTNAdd
            // 
            this.BTNAdd.BackColor = System.Drawing.Color.White;
            this.BTNAdd.Enabled = false;
            this.BTNAdd.Font = new System.Drawing.Font("Tahoma", 12F);
            this.BTNAdd.Location = new System.Drawing.Point(558, 11);
            this.BTNAdd.Name = "BTNAdd";
            this.BTNAdd.Size = new System.Drawing.Size(64, 29);
            this.BTNAdd.TabIndex = 3;
            this.BTNAdd.Text = "เพิ่ม";
            this.BTNAdd.UseVisualStyleBackColor = false;
            this.BTNAdd.Click += new System.EventHandler(this.BTNAdd_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTime.Location = new System.Drawing.Point(719, 13);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(94, 27);
            this.txtTime.TabIndex = 2;
            this.txtTime.TabStop = false;
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDate.Location = new System.Drawing.Point(818, 13);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(97, 27);
            this.txtDate.TabIndex = 112;
            this.txtDate.TabStop = false;
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(628, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 113;
            this.label2.Text = "เวลา / วันที่";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtSum);
            this.panel2.Location = new System.Drawing.Point(644, 174);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 78);
            this.panel2.TabIndex = 115;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(11, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "ราคารวม";
            // 
            // txtSum
            // 
            this.txtSum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.txtSum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSum.Font = new System.Drawing.Font("Tahoma", 25F);
            this.txtSum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSum.Location = new System.Drawing.Point(15, 32);
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(264, 41);
            this.txtSum.TabIndex = 0;
            this.txtSum.TabStop = false;
            this.txtSum.Text = "0.00";
            this.txtSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BTNSearch);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.BTNAdd);
            this.panel3.Controls.Add(this.prPid);
            this.panel3.Controls.Add(this.txtTime);
            this.panel3.Controls.Add(this.txtDate);
            this.panel3.Controls.Add(this.txtName);
            this.panel3.Location = new System.Drawing.Point(12, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(926, 50);
            this.panel3.TabIndex = 116;
            // 
            // BTNSearch
            // 
            this.BTNSearch.BackColor = System.Drawing.Color.White;
            this.BTNSearch.Font = new System.Drawing.Font("Tahoma", 12F);
            this.BTNSearch.Location = new System.Drawing.Point(178, 11);
            this.BTNSearch.Name = "BTNSearch";
            this.BTNSearch.Size = new System.Drawing.Size(64, 29);
            this.BTNSearch.TabIndex = 2;
            this.BTNSearch.Text = "ค้นหา";
            this.BTNSearch.UseVisualStyleBackColor = false;
            this.BTNSearch.Click += new System.EventHandler(this.BTNSearch_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtGet);
            this.panel4.Location = new System.Drawing.Point(644, 258);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(294, 78);
            this.panel4.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(11, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "รับเงิน";
            // 
            // txtGet
            // 
            this.txtGet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGet.BackColor = System.Drawing.Color.White;
            this.txtGet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGet.Font = new System.Drawing.Font("Tahoma", 25F);
            this.txtGet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtGet.Location = new System.Drawing.Point(15, 32);
            this.txtGet.Name = "txtGet";
            this.txtGet.Size = new System.Drawing.Size(264, 41);
            this.txtGet.TabIndex = 0;
            this.txtGet.Text = "0.00";
            this.txtGet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGet.TextChanged += new System.EventHandler(this.txtGet_TextChanged);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.txtSubtract);
            this.panel5.Location = new System.Drawing.Point(644, 342);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(294, 78);
            this.panel5.TabIndex = 118;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(11, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "เงินทอน";
            // 
            // txtSubtract
            // 
            this.txtSubtract.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.txtSubtract.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubtract.Font = new System.Drawing.Font("Tahoma", 25F);
            this.txtSubtract.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSubtract.Location = new System.Drawing.Point(15, 32);
            this.txtSubtract.Name = "txtSubtract";
            this.txtSubtract.ReadOnly = true;
            this.txtSubtract.Size = new System.Drawing.Size(264, 41);
            this.txtSubtract.TabIndex = 0;
            this.txtSubtract.TabStop = false;
            this.txtSubtract.Text = "0.00";
            this.txtSubtract.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSubtract.TextChanged += new System.EventHandler(this.txtSubtract_TextChanged);
            // 
            // BTNSubmit
            // 
            this.BTNSubmit.AutoSize = true;
            this.BTNSubmit.BackColor = System.Drawing.Color.White;
            this.BTNSubmit.Enabled = false;
            this.BTNSubmit.Font = new System.Drawing.Font("Tahoma", 14F);
            this.BTNSubmit.Location = new System.Drawing.Point(794, 426);
            this.BTNSubmit.Name = "BTNSubmit";
            this.BTNSubmit.Size = new System.Drawing.Size(144, 49);
            this.BTNSubmit.TabIndex = 2;
            this.BTNSubmit.Text = "บันทึกการขาย";
            this.BTNSubmit.UseVisualStyleBackColor = false;
            this.BTNSubmit.Click += new System.EventHandler(this.BTNSubmit_Click);
            // 
            // BTNReset
            // 
            this.BTNReset.BackColor = System.Drawing.Color.White;
            this.BTNReset.Cursor = System.Windows.Forms.Cursors.Default;
            this.BTNReset.Font = new System.Drawing.Font("Tahoma", 14F);
            this.BTNReset.Location = new System.Drawing.Point(644, 426);
            this.BTNReset.Name = "BTNReset";
            this.BTNReset.Size = new System.Drawing.Size(144, 49);
            this.BTNReset.TabIndex = 119;
            this.BTNReset.Text = "เริ่มรายการใหม่";
            this.BTNReset.UseVisualStyleBackColor = false;
            this.BTNReset.Click += new System.EventHandler(this.BTNReset_Click);
            // 
            // BTNBack
            // 
            this.BTNBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNBack.BackColor = System.Drawing.Color.White;
            this.BTNBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTNBack.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTNBack.Location = new System.Drawing.Point(838, 600);
            this.BTNBack.Name = "BTNBack";
            this.BTNBack.Size = new System.Drawing.Size(100, 38);
            this.BTNBack.TabIndex = 121;
            this.BTNBack.TabStop = false;
            this.BTNBack.Text = "ย้อนกลับ";
            this.BTNBack.UseVisualStyleBackColor = false;
            this.BTNBack.Click += new System.EventHandler(this.BTNBack_Click);
            // 
            // Counter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.BTNBack);
            this.Controls.Add(this.BTNReset);
            this.Controls.Add(this.BTNSubmit);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Counter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Counter";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTNClose;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seq;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prPid;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button BTNAdd;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtGet;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSubtract;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTNSearch;
        private System.Windows.Forms.Button BTNSubmit;
        private System.Windows.Forms.Button BTNReset;
        private System.Windows.Forms.Button BTNBack;
    }
}