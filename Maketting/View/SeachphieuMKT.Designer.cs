namespace Maketting.View
{
    partial class SeachphieuMKT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeachphieuMKT));
            this.txtmktnumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbselect2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbstatusphieu = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtmktnumber
            // 
            this.txtmktnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmktnumber.Location = new System.Drawing.Point(146, 20);
            this.txtmktnumber.Name = "txtmktnumber";
            this.txtmktnumber.Size = new System.Drawing.Size(200, 26);
            this.txtmktnumber.TabIndex = 1;
            this.txtmktnumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtmktnumber.Enter += new System.EventHandler(this.txtmktnumber_Enter);
            this.txtmktnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmktnumber_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "MKT Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Reciept by";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(146, 55);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(200, 26);
            this.txtname.TabIndex = 3;
            this.txtname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtname_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(237, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "ENTER to seach";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Region Maketting";
            // 
            // cbselect2
            // 
            this.cbselect2.DropDownWidth = 200;
            this.cbselect2.FormattingEnabled = true;
            this.cbselect2.Location = new System.Drawing.Point(146, 101);
            this.cbselect2.Name = "cbselect2";
            this.cbselect2.Size = new System.Drawing.Size(200, 21);
            this.cbselect2.TabIndex = 9;
            this.cbselect2.SelectedIndexChanged += new System.EventHandler(this.cbselect2_SelectedIndexChanged);
            this.cbselect2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbselect2_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Status of delivery";
            // 
            // cbstatusphieu
            // 
            this.cbstatusphieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbstatusphieu.DropDownWidth = 200;
            this.cbstatusphieu.FormattingEnabled = true;
            this.cbstatusphieu.Items.AddRange(new object[] {
            "All",
            "CRT",
            "Shipping",
            "Delivering",
            "completed"});
            this.cbstatusphieu.Location = new System.Drawing.Point(146, 142);
            this.cbstatusphieu.Name = "cbstatusphieu";
            this.cbstatusphieu.Size = new System.Drawing.Size(200, 21);
            this.cbstatusphieu.TabIndex = 11;
            this.cbstatusphieu.SelectedIndexChanged += new System.EventHandler(this.cbstatusphieu_SelectedIndexChanged);
            this.cbstatusphieu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbstatusphieu_KeyPress);
            // 
            // SeachphieuMKT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 216);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbstatusphieu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbselect2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmktnumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SeachphieuMKT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm phiếu";
            this.Deactivate += new System.EventHandler(this.Seachcode_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Seachcode_FormClosed);
            this.Leave += new System.EventHandler(this.Seachcode_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtmktnumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbselect2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbstatusphieu;
    }
}