﻿namespace Maketting.View
{
    partial class MKTNhaphancollectfrommaket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MKTNhaphancollectfrommaket));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btinphieu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btluu = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewLoaddetail = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtdnnumbar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateNgaynhaphang = new System.Windows.Forms.DateTimePicker();
            this.txtstorelocation = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datecreated = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPonumber = new System.Windows.Forms.Label();
            this.txtnguoinhanhang = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoaddetail)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btinphieu);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btluu);
            this.panel2.Location = new System.Drawing.Point(4, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 40);
            this.panel2.TabIndex = 1;
            // 
            // btinphieu
            // 
            this.btinphieu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btinphieu.Location = new System.Drawing.Point(113, 7);
            this.btinphieu.Name = "btinphieu";
            this.btinphieu.Size = new System.Drawing.Size(94, 25);
            this.btinphieu.TabIndex = 56;
            this.btinphieu.TabStop = false;
            this.btinphieu.Text = "Print receipt";
            this.btinphieu.UseVisualStyleBackColor = true;
            this.btinphieu.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1195, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btluu
            // 
            this.btluu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btluu.Location = new System.Drawing.Point(7, 8);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(71, 25);
            this.btluu.TabIndex = 0;
            this.btluu.TabStop = false;
            this.btluu.Text = "Save";
            this.btluu.UseVisualStyleBackColor = true;
            this.btluu.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewLoaddetail);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1272, 539);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Phiếu nhập kho";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dataGridViewLoaddetail
            // 
            this.dataGridViewLoaddetail.AllowUserToAddRows = false;
            this.dataGridViewLoaddetail.AllowUserToDeleteRows = false;
            this.dataGridViewLoaddetail.AllowUserToResizeRows = false;
            this.dataGridViewLoaddetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLoaddetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLoaddetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLoaddetail.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewLoaddetail.Location = new System.Drawing.Point(6, 101);
            this.dataGridViewLoaddetail.Name = "dataGridViewLoaddetail";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLoaddetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewLoaddetail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridViewLoaddetail.Size = new System.Drawing.Size(1261, 388);
            this.dataGridViewLoaddetail.TabIndex = 69;
            this.dataGridViewLoaddetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLoaddetail_CellContentClick);
            this.dataGridViewLoaddetail.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLoaddetail_CellDoubleClick);
            this.dataGridViewLoaddetail.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridViewLoaddetail_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(455, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(351, 20);
            this.label3.TabIndex = 68;
            this.label3.Text = "GOOD RECIEPT COLLECTED FROM MARKET";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtdnnumbar);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateNgaynhaphang);
            this.panel1.Controls.Add(this.txtstorelocation);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.datecreated);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.txtPonumber);
            this.panel1.Controls.Add(this.txtnguoinhanhang);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(6, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 69);
            this.panel1.TabIndex = 65;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // txtdnnumbar
            // 
            this.txtdnnumbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdnnumbar.Location = new System.Drawing.Point(1091, 38);
            this.txtdnnumbar.Name = "txtdnnumbar";
            this.txtdnnumbar.Size = new System.Drawing.Size(157, 20);
            this.txtdnnumbar.TabIndex = 81;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(998, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 18);
            this.label6.TabIndex = 80;
            this.label6.Text = "DN Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1033, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 71;
            this.label1.Text = "Reciept date";
            // 
            // dateNgaynhaphang
            // 
            this.dateNgaynhaphang.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgaynhaphang.CustomFormat = "dd.MM.yyyy";
            this.dateNgaynhaphang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgaynhaphang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgaynhaphang.Location = new System.Drawing.Point(1129, 2);
            this.dateNgaynhaphang.Name = "dateNgaynhaphang";
            this.dateNgaynhaphang.Size = new System.Drawing.Size(119, 24);
            this.dateNgaynhaphang.TabIndex = 70;
            this.dateNgaynhaphang.Value = new System.DateTime(2017, 7, 18, 0, 0, 0, 0);
            // 
            // txtstorelocation
            // 
            this.txtstorelocation.AutoSize = true;
            this.txtstorelocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstorelocation.Location = new System.Drawing.Point(562, 40);
            this.txtstorelocation.Name = "txtstorelocation";
            this.txtstorelocation.Size = new System.Drawing.Size(41, 18);
            this.txtstorelocation.TabIndex = 79;
            this.txtstorelocation.Text = "V101";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date: ";
            // 
            // datecreated
            // 
            this.datecreated.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datecreated.CustomFormat = "dd.MM.yyyy";
            this.datecreated.Enabled = false;
            this.datecreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datecreated.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datecreated.Location = new System.Drawing.Point(72, 6);
            this.datecreated.Name = "datecreated";
            this.datecreated.Size = new System.Drawing.Size(119, 24);
            this.datecreated.TabIndex = 0;
            this.datecreated.Value = new System.DateTime(2017, 7, 18, 0, 0, 0, 0);
            this.datecreated.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.datepickngayphieu_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(449, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 72;
            this.label4.Text = "Store (Tại kho)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(927, 125);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 18);
            this.label19.TabIndex = 68;
            // 
            // txtPonumber
            // 
            this.txtPonumber.AutoSize = true;
            this.txtPonumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPonumber.Location = new System.Drawing.Point(160, 33);
            this.txtPonumber.Name = "txtPonumber";
            this.txtPonumber.Size = new System.Drawing.Size(64, 25);
            this.txtPonumber.TabIndex = 65;
            this.txtPonumber.Text = "1135";
            // 
            // txtnguoinhanhang
            // 
            this.txtnguoinhanhang.Enabled = false;
            this.txtnguoinhanhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnguoinhanhang.Location = new System.Drawing.Point(532, 2);
            this.txtnguoinhanhang.Name = "txtnguoinhanhang";
            this.txtnguoinhanhang.Size = new System.Drawing.Size(267, 24);
            this.txtnguoinhanhang.TabIndex = 21;
            this.txtnguoinhanhang.Text = "LÊ THANH VÂN";
            this.txtnguoinhanhang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbtennguoinop_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 18);
            this.label11.TabIndex = 19;
            this.label11.Text = "MINUTE NUMBER";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(449, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Reciept by";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(4, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1280, 565);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // MKTNhaphancollectfrommaket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 618);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MKTNhaphancollectfrommaket";
            this.Text = "BeePhieuThu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoaddetail)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btinphieu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewLoaddetail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtstorelocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label txtPonumber;
        private System.Windows.Forms.TextBox txtnguoinhanhang;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datecreated;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateNgaynhaphang;
        private System.Windows.Forms.TextBox txtdnnumbar;
    }
}