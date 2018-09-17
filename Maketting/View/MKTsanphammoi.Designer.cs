namespace Maketting.View
{
    partial class MKTsanphammoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MKTsanphammoi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtsapcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btupdate = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btnew = new System.Windows.Forms.Button();
            this.txtitemcode = new System.Windows.Forms.TextBox();
            this.txttensanpham = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtunit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtstorelocation = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtstorelocation);
            this.panel1.Controls.Add(this.txtunit);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtdescription);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtsapcode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btupdate);
            this.panel1.Controls.Add(this.btxoa);
            this.panel1.Controls.Add(this.btnew);
            this.panel1.Controls.Add(this.txtitemcode);
            this.panel1.Controls.Add(this.txttensanpham);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Location = new System.Drawing.Point(5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 265);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 20);
            this.label9.TabIndex = 66;
            this.label9.Text = "STORE";
            // 
            // txtsapcode
            // 
            this.txtsapcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsapcode.Location = new System.Drawing.Point(176, 49);
            this.txtsapcode.Name = "txtsapcode";
            this.txtsapcode.Size = new System.Drawing.Size(130, 20);
            this.txtsapcode.TabIndex = 51;
            this.txtsapcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmavach_KeyPress);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "SAP CODE";
            // 
            // btupdate
            // 
            this.btupdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btupdate.BackColor = System.Drawing.Color.Transparent;
            this.btupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btupdate.ForeColor = System.Drawing.Color.Red;
            this.btupdate.Location = new System.Drawing.Point(336, 241);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(94, 21);
            this.btupdate.TabIndex = 6;
            this.btupdate.Text = "Cập nhật";
            this.btupdate.UseVisualStyleBackColor = false;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // btxoa
            // 
            this.btxoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btxoa.BackColor = System.Drawing.Color.Transparent;
            this.btxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa.ForeColor = System.Drawing.Color.Red;
            this.btxoa.Location = new System.Drawing.Point(199, 241);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(94, 21);
            this.btxoa.TabIndex = 6;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = false;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btnew
            // 
            this.btnew.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnew.BackColor = System.Drawing.Color.Transparent;
            this.btnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnew.ForeColor = System.Drawing.Color.Red;
            this.btnew.Location = new System.Drawing.Point(447, 241);
            this.btnew.Name = "btnew";
            this.btnew.Size = new System.Drawing.Size(94, 21);
            this.btnew.TabIndex = 8;
            this.btnew.Text = "Tạo mới";
            this.btnew.UseVisualStyleBackColor = false;
            this.btnew.Click += new System.EventHandler(this.btnew_Click);
            // 
            // txtitemcode
            // 
            this.txtitemcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtitemcode.Location = new System.Drawing.Point(175, 21);
            this.txtitemcode.Name = "txtitemcode";
            this.txtitemcode.Size = new System.Drawing.Size(131, 20);
            this.txtitemcode.TabIndex = 1;
            this.txtitemcode.TextChanged += new System.EventHandler(this.txtmakho_TextChanged);
            this.txtitemcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustcode_KeyPress);
            // 
            // txttensanpham
            // 
            this.txttensanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttensanpham.Location = new System.Drawing.Point(176, 83);
            this.txttensanpham.Name = "txttensanpham";
            this.txttensanpham.Size = new System.Drawing.Size(368, 20);
            this.txttensanpham.TabIndex = 2;
            this.txttensanpham.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttensanpham_KeyPress);
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label20.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(18, 22);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(126, 16);
            this.label20.TabIndex = 50;
            this.label20.Text = "ITEM Code";
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label21.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(18, 83);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(125, 20);
            this.label21.TabIndex = 49;
            this.label21.Text = "MATERIAL NAME";
            // 
            // txtdescription
            // 
            this.txtdescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescription.Location = new System.Drawing.Point(176, 116);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(368, 20);
            this.txtdescription.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 74;
            this.label2.Text = "Description";
            // 
            // txtunit
            // 
            this.txtunit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtunit.Location = new System.Drawing.Point(176, 150);
            this.txtunit.Name = "txtunit";
            this.txtunit.Size = new System.Drawing.Size(130, 20);
            this.txtunit.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 76;
            this.label3.Text = "UNIT";
            // 
            // txtstorelocation
            // 
            this.txtstorelocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstorelocation.Location = new System.Drawing.Point(176, 180);
            this.txtstorelocation.Name = "txtstorelocation";
            this.txtstorelocation.Size = new System.Drawing.Size(130, 20);
            this.txtstorelocation.TabIndex = 77;
            // 
            // MKTsanphammoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 279);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MKTsanphammoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maketing Product";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtitemcode;
        private System.Windows.Forms.TextBox txttensanpham;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnew;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.TextBox txtsapcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtunit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtstorelocation;
    }
}