namespace Maketting.View
{
    partial class MKTProgramemake2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MKTProgramemake2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txttotalbudget = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttodate = new System.Windows.Forms.DateTimePicker();
            this.txtsohieuct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttenct = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfromdate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txttotalbudget);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txttodate);
            this.panel1.Controls.Add(this.txtsohieuct);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txttenct);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtfromdate);
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 285);
            this.panel1.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(328, 4);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(261, 25);
            this.label16.TabIndex = 65;
            this.label16.Text = "POSM SCHEME CREATE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(419, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 18);
            this.label6.TabIndex = 33;
            this.label6.Text = "VNĐ";
            // 
            // txttotalbudget
            // 
            this.txttotalbudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalbudget.Location = new System.Drawing.Point(242, 173);
            this.txttotalbudget.Name = "txttotalbudget";
            this.txttotalbudget.Size = new System.Drawing.Size(171, 24);
            this.txttotalbudget.TabIndex = 32;
            this.txttotalbudget.Text = "160000000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 18);
            this.label4.TabIndex = 31;
            this.label4.Text = "Tổng giá trị chương trình";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 29;
            this.label3.Text = "Đến ngày";
            // 
            // txttodate
            // 
            this.txttodate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttodate.CustomFormat = "dd.MM.yyyy";
            this.txttodate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttodate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txttodate.Location = new System.Drawing.Point(242, 143);
            this.txttodate.Name = "txttodate";
            this.txttodate.Size = new System.Drawing.Size(119, 24);
            this.txttodate.TabIndex = 28;
            this.txttodate.Value = new System.DateTime(2017, 7, 18, 0, 0, 0, 0);
            this.txttodate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttodate_KeyPress);
            // 
            // txtsohieuct
            // 
            this.txtsohieuct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsohieuct.Location = new System.Drawing.Point(242, 48);
            this.txtsohieuct.Name = "txtsohieuct";
            this.txtsohieuct.Size = new System.Drawing.Size(271, 24);
            this.txtsohieuct.TabIndex = 27;
            this.txtsohieuct.Text = "8/2018/00246/01/HOC";
            this.txtsohieuct.TextChanged += new System.EventHandler(this.txtsohieuct_TextChanged);
            this.txtsohieuct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsohieuct_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Số hiệu chương trình";
            // 
            // txttenct
            // 
            this.txttenct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenct.Location = new System.Drawing.Point(242, 80);
            this.txttenct.Name = "txttenct";
            this.txttenct.Size = new System.Drawing.Size(533, 24);
            this.txttenct.TabIndex = 25;
            this.txttenct.Text = "Chương trình khuyến mại đón năm học mới 2018";
            this.txttenct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttenct_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 18);
            this.label5.TabIndex = 24;
            this.label5.Text = "Tên chương trình khuyến mại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Áp dụng từ ngày";
            // 
            // txtfromdate
            // 
            this.txtfromdate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfromdate.CustomFormat = "dd.MM.yyyy";
            this.txtfromdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfromdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtfromdate.Location = new System.Drawing.Point(242, 110);
            this.txtfromdate.Name = "txtfromdate";
            this.txtfromdate.Size = new System.Drawing.Size(119, 24);
            this.txtfromdate.TabIndex = 22;
            this.txtfromdate.Value = new System.DateTime(2017, 7, 18, 0, 0, 0, 0);
            this.txtfromdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfromdate_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(841, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 27);
            this.button1.TabIndex = 18;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MKTProgramemake2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 294);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MKTProgramemake2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programe make";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttotalbudget;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txttodate;
        private System.Windows.Forms.TextBox txtsohieuct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttenct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtfromdate;
        private System.Windows.Forms.Label label16;
    }
}