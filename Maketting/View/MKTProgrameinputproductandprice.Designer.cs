namespace Maketting.View
{
    partial class MKTProgrameinputproductandprice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MKTProgrameinputproductandprice));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnew = new System.Windows.Forms.Button();
            this.txtposmproduct = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.lbe = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtsapcode = new System.Windows.Forms.TextBox();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.txtdescription);
            this.panel1.Controls.Add(this.txtsapcode);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnew);
            this.panel1.Controls.Add(this.txtposmproduct);
            this.panel1.Controls.Add(this.txtprice);
            this.panel1.Controls.Add(this.lbe);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Location = new System.Drawing.Point(5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 261);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnew
            // 
            this.btnew.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnew.BackColor = System.Drawing.Color.Transparent;
            this.btnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnew.ForeColor = System.Drawing.Color.Red;
            this.btnew.Location = new System.Drawing.Point(446, 227);
            this.btnew.Name = "btnew";
            this.btnew.Size = new System.Drawing.Size(94, 21);
            this.btnew.TabIndex = 8;
            this.btnew.Text = "Add to";
            this.btnew.UseVisualStyleBackColor = false;
            this.btnew.Click += new System.EventHandler(this.btnew_Click);
            // 
            // txtposmproduct
            // 
            this.txtposmproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtposmproduct.Location = new System.Drawing.Point(171, 22);
            this.txtposmproduct.Name = "txtposmproduct";
            this.txtposmproduct.Size = new System.Drawing.Size(369, 20);
            this.txtposmproduct.TabIndex = 1;
            this.txtposmproduct.TextChanged += new System.EventHandler(this.txtmakho_TextChanged);
            this.txtposmproduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustcode_KeyPress);
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(173, 189);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(134, 20);
            this.txtprice.TabIndex = 2;
            this.txtprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttenkho_KeyPress);
            // 
            // lbe
            // 
            this.lbe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbe.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbe.Location = new System.Drawing.Point(14, 23);
            this.lbe.Name = "lbe";
            this.lbe.Size = new System.Drawing.Size(126, 16);
            this.lbe.TabIndex = 50;
            this.lbe.Text = "POSM Product ";
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label21.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(15, 189);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(125, 20);
            this.label21.TabIndex = 49;
            this.label21.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "VNĐ";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "Sap Code";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 54;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 55;
            this.label5.Text = "Name";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(411, 54);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(129, 20);
            this.txtid.TabIndex = 56;
            // 
            // txtsapcode
            // 
            this.txtsapcode.Enabled = false;
            this.txtsapcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsapcode.Location = new System.Drawing.Point(171, 84);
            this.txtsapcode.Name = "txtsapcode";
            this.txtsapcode.Size = new System.Drawing.Size(369, 20);
            this.txtsapcode.TabIndex = 57;
            // 
            // txtdescription
            // 
            this.txtdescription.Enabled = false;
            this.txtdescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescription.Location = new System.Drawing.Point(171, 118);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(369, 20);
            this.txtdescription.TabIndex = 58;
            // 
            // txtname
            // 
            this.txtname.Enabled = false;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(171, 148);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(369, 20);
            this.txtname.TabIndex = 59;
            // 
            // MKTProgrameinputproductandprice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 276);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MKTProgrameinputproductandprice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set product and price of programe";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtposmproduct;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label lbe;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.TextBox txtsapcode;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}