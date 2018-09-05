namespace Maketting.View
{
    using Maketting;
    using System.Windows.Forms;

    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// 
       
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbusername = new System.Windows.Forms.Label();
            this.lb_user = new System.Windows.Forms.Label();
            this.panelmain = new System.Windows.Forms.Panel();
            this.dfasfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ádfasdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hạchToánKếToánTổngHợpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpPhiếuXuấtĐồMKTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tậpHợpPhiếuMKTTrảVềToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.inputPOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadPOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.báoCáoPhiếuMKTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storeAvaiableReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchCácPhiếuMKTCầnXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiềnMặtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtĐồToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryApprovalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoTrạngTháiPhiếuMKTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusGatepassReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lbusername);
            this.panel1.Controls.Add(this.lb_user);
            this.panel1.Controls.Add(this.panelmain);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(6, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1336, 640);
            this.panel1.TabIndex = 20;
            // 
            // lbusername
            // 
            this.lbusername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbusername.AutoSize = true;
            this.lbusername.ForeColor = System.Drawing.Color.Red;
            this.lbusername.Location = new System.Drawing.Point(38, 618);
            this.lbusername.Name = "lbusername";
            this.lbusername.Size = new System.Drawing.Size(35, 13);
            this.lbusername.TabIndex = 24;
            this.lbusername.Text = "label1";
            // 
            // lb_user
            // 
            this.lb_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_user.AutoSize = true;
            this.lb_user.Location = new System.Drawing.Point(3, 618);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(29, 13);
            this.lb_user.TabIndex = 23;
            this.lb_user.Text = "User";
            // 
            // panelmain
            // 
            this.panelmain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelmain.AutoScroll = true;
            this.panelmain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelmain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelmain.Location = new System.Drawing.Point(6, 0);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(1327, 611);
            this.panelmain.TabIndex = 7;
            // 
            // dfasfToolStripMenuItem
            // 
            this.dfasfToolStripMenuItem.Name = "dfasfToolStripMenuItem";
            this.dfasfToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.dfasfToolStripMenuItem.Text = "Thiết lập người dùng";
            this.dfasfToolStripMenuItem.Click += new System.EventHandler(this.dfasfToolStripMenuItem_Click);
            // 
            // ádfasdfToolStripMenuItem
            // 
            this.ádfasdfToolStripMenuItem.Name = "ádfasdfToolStripMenuItem";
            this.ádfasdfToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.ádfasdfToolStripMenuItem.Text = "Thiết lập hệ thống";
            this.ádfasdfToolStripMenuItem.Click += new System.EventHandler(this.ádfasdfToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.hạchToánKếToánTổngHợpToolStripMenuItem,
            this.loadCreateToolStripMenuItem,
            this.tiềnMặtToolStripMenuItem,
            this.khoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1354, 28);
            this.menuStrip1.TabIndex = 56;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem1,
            this.changePasswordToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.hệThốngToolStripMenuItem.Text = "System";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.changePasswordToolStripMenuItem.Text = "Change password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // hạchToánKếToánTổngHợpToolStripMenuItem
            // 
            this.hạchToánKếToánTổngHợpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lậpPhiếuXuấtĐồMKTToolStripMenuItem,
            this.tậpHợpPhiếuMKTTrảVềToolStripMenuItem,
            this.toolStripSeparator2,
            this.inputPOToolStripMenuItem,
            this.uploadPOToolStripMenuItem,
            this.toolStripSeparator1,
            this.báoCáoPhiếuMKTToolStripMenuItem,
            this.storeAvaiableReportsToolStripMenuItem});
            this.hạchToánKếToánTổngHợpToolStripMenuItem.Name = "hạchToánKếToánTổngHợpToolStripMenuItem";
            this.hạchToánKếToánTổngHợpToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.hạchToánKếToánTổngHợpToolStripMenuItem.Text = "Maketting";
            // 
            // lậpPhiếuXuấtĐồMKTToolStripMenuItem
            // 
            this.lậpPhiếuXuấtĐồMKTToolStripMenuItem.Image = global::Maketting.Properties.Resources.blogosfera_diciembre_640x300;
            this.lậpPhiếuXuấtĐồMKTToolStripMenuItem.Name = "lậpPhiếuXuấtĐồMKTToolStripMenuItem";
            this.lậpPhiếuXuấtĐồMKTToolStripMenuItem.Size = new System.Drawing.Size(265, 24);
            this.lậpPhiếuXuấtĐồMKTToolStripMenuItem.Text = "MKT Gate pass request";
            this.lậpPhiếuXuấtĐồMKTToolStripMenuItem.Click += new System.EventHandler(this.lậpPhiếuXuấtĐồMKTToolStripMenuItem_Click);
            // 
            // tậpHợpPhiếuMKTTrảVềToolStripMenuItem
            // 
            this.tậpHợpPhiếuMKTTrảVềToolStripMenuItem.Name = "tậpHợpPhiếuMKTTrảVềToolStripMenuItem";
            this.tậpHợpPhiếuMKTTrảVềToolStripMenuItem.Size = new System.Drawing.Size(265, 24);
            this.tậpHợpPhiếuMKTTrảVềToolStripMenuItem.Text = "Update Gate pass delivered ";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(262, 6);
            // 
            // inputPOToolStripMenuItem
            // 
            this.inputPOToolStripMenuItem.Name = "inputPOToolStripMenuItem";
            this.inputPOToolStripMenuItem.Size = new System.Drawing.Size(265, 24);
            this.inputPOToolStripMenuItem.Text = "Input PO ";
            // 
            // uploadPOToolStripMenuItem
            // 
            this.uploadPOToolStripMenuItem.Name = "uploadPOToolStripMenuItem";
            this.uploadPOToolStripMenuItem.Size = new System.Drawing.Size(265, 24);
            this.uploadPOToolStripMenuItem.Text = "Upload PO";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(262, 6);
            // 
            // báoCáoPhiếuMKTToolStripMenuItem
            // 
            this.báoCáoPhiếuMKTToolStripMenuItem.Image = global::Maketting.Properties.Resources.KETOANTONGHOP;
            this.báoCáoPhiếuMKTToolStripMenuItem.Name = "báoCáoPhiếuMKTToolStripMenuItem";
            this.báoCáoPhiếuMKTToolStripMenuItem.Size = new System.Drawing.Size(265, 24);
            this.báoCáoPhiếuMKTToolStripMenuItem.Text = "Status Gate pass reports";
            this.báoCáoPhiếuMKTToolStripMenuItem.Click += new System.EventHandler(this.báoCáoPhiếuMKTToolStripMenuItem_Click);
            // 
            // storeAvaiableReportsToolStripMenuItem
            // 
            this.storeAvaiableReportsToolStripMenuItem.Name = "storeAvaiableReportsToolStripMenuItem";
            this.storeAvaiableReportsToolStripMenuItem.Size = new System.Drawing.Size(265, 24);
            this.storeAvaiableReportsToolStripMenuItem.Text = "Store avaiable reports";
            // 
            // loadCreateToolStripMenuItem
            // 
            this.loadCreateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchCácPhiếuMKTCầnXuấtToolStripMenuItem});
            this.loadCreateToolStripMenuItem.Name = "loadCreateToolStripMenuItem";
            this.loadCreateToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.loadCreateToolStripMenuItem.Text = "Load Create";
            // 
            // danhSáchCácPhiếuMKTCầnXuấtToolStripMenuItem
            // 
            this.danhSáchCácPhiếuMKTCầnXuấtToolStripMenuItem.Name = "danhSáchCácPhiếuMKTCầnXuấtToolStripMenuItem";
            this.danhSáchCácPhiếuMKTCầnXuấtToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.danhSáchCácPhiếuMKTCầnXuấtToolStripMenuItem.Text = "Maketting Load Create";
            // 
            // tiềnMặtToolStripMenuItem
            // 
            this.tiềnMặtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpKhoToolStripMenuItem,
            this.xuấtĐồToolStripMenuItem,
            this.toolStripSeparator3,
            this.inventoryToolStripMenuItem,
            this.inventoryApprovalToolStripMenuItem});
            this.tiềnMặtToolStripMenuItem.Name = "tiềnMặtToolStripMenuItem";
            this.tiềnMặtToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.tiềnMặtToolStripMenuItem.Text = "Ware House";
            // 
            // nhậpKhoToolStripMenuItem
            // 
            this.nhậpKhoToolStripMenuItem.Name = "nhậpKhoToolStripMenuItem";
            this.nhậpKhoToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.nhậpKhoToolStripMenuItem.Text = "Good Issue ";
            // 
            // xuấtĐồToolStripMenuItem
            // 
            this.xuấtĐồToolStripMenuItem.Name = "xuấtĐồToolStripMenuItem";
            this.xuấtĐồToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.xuấtĐồToolStripMenuItem.Text = "Good Recieved";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(201, 6);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // inventoryApprovalToolStripMenuItem
            // 
            this.inventoryApprovalToolStripMenuItem.Name = "inventoryApprovalToolStripMenuItem";
            this.inventoryApprovalToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.inventoryApprovalToolStripMenuItem.Text = "Inventory Approval";
            // 
            // khoToolStripMenuItem
            // 
            this.khoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.báoCáoTrạngTháiPhiếuMKTToolStripMenuItem,
            this.statusGatepassReportsToolStripMenuItem});
            this.khoToolStripMenuItem.Name = "khoToolStripMenuItem";
            this.khoToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.khoToolStripMenuItem.Text = "Reports";
            // 
            // báoCáoTrạngTháiPhiếuMKTToolStripMenuItem
            // 
            this.báoCáoTrạngTháiPhiếuMKTToolStripMenuItem.Name = "báoCáoTrạngTháiPhiếuMKTToolStripMenuItem";
            this.báoCáoTrạngTháiPhiếuMKTToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.báoCáoTrạngTháiPhiếuMKTToolStripMenuItem.Text = "Store Avaiable Reports";
            // 
            // statusGatepassReportsToolStripMenuItem
            // 
            this.statusGatepassReportsToolStripMenuItem.Name = "statusGatepassReportsToolStripMenuItem";
            this.statusGatepassReportsToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.statusGatepassReportsToolStripMenuItem.Text = "Status Gate pass reports";
            // 
            // usersToolStripMenuItem1
            // 
            this.usersToolStripMenuItem1.Name = "usersToolStripMenuItem1";
            this.usersToolStripMenuItem1.Size = new System.Drawing.Size(195, 24);
            this.usersToolStripMenuItem1.Text = "Users";
            this.usersToolStripMenuItem1.Click += new System.EventHandler(this.usersToolStripMenuItem1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 669);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Maketting ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_user;
        private Label lbusername;
     //   private ToolStripMenuItem Menu;
        private ToolStripMenuItem dfasfToolStripMenuItem;
        private ToolStripMenuItem ádfasdfToolStripMenuItem;
        private Panel panelmain;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem khoToolStripMenuItem;
        private ToolStripMenuItem hạchToánKếToánTổngHợpToolStripMenuItem;
        private ToolStripMenuItem lậpPhiếuXuấtĐồMKTToolStripMenuItem;
        private ToolStripMenuItem báoCáoPhiếuMKTToolStripMenuItem;
        private ToolStripMenuItem tậpHợpPhiếuMKTTrảVềToolStripMenuItem;
        private ToolStripMenuItem loadCreateToolStripMenuItem;
        private ToolStripMenuItem danhSáchCácPhiếuMKTCầnXuấtToolStripMenuItem;
        private ToolStripMenuItem tiềnMặtToolStripMenuItem;
        private ToolStripMenuItem nhậpKhoToolStripMenuItem;
        private ToolStripMenuItem xuấtĐồToolStripMenuItem;
        private ToolStripMenuItem báoCáoTrạngTháiPhiếuMKTToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem inputPOToolStripMenuItem;
        private ToolStripMenuItem uploadPOToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem storeAvaiableReportsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem inventoryToolStripMenuItem;
        private ToolStripMenuItem statusGatepassReportsToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripMenuItem inventoryApprovalToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem1;
    }
}

