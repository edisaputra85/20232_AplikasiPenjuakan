namespace Aplikasi_Penjualan.GUI
{
    partial class Menu_Utama
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Utama));
            menuStrip = new MenuStrip();
            menu_file = new ToolStripMenuItem();
            submenu_login = new ToolStripMenuItem();
            submenu_logout = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            submenu_keluar = new ToolStripMenuItem();
            menu_masterdata = new ToolStripMenuItem();
            menu_transaksi = new ToolStripMenuItem();
            menu_pengaturan = new ToolStripMenuItem();
            menu_tentang = new ToolStripMenuItem();
            toolStrip = new ToolStrip();
            toolbar_barang = new ToolStripButton();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            subMenuDataBarang = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            toolStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { menu_file, menu_masterdata, menu_transaksi, menu_pengaturan, menu_tentang });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(8, 3, 0, 3);
            menuStrip.Size = new Size(843, 30);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // menu_file
            // 
            menu_file.DropDownItems.AddRange(new ToolStripItem[] { submenu_login, submenu_logout, toolStripMenuItem1, submenu_keluar });
            menu_file.Name = "menu_file";
            menu_file.Size = new Size(46, 24);
            menu_file.Text = "&File";
            // 
            // submenu_login
            // 
            submenu_login.Name = "submenu_login";
            submenu_login.Size = new Size(139, 26);
            submenu_login.Text = "&Login";
            submenu_login.Click += submenu_login_Click;
            // 
            // submenu_logout
            // 
            submenu_logout.Name = "submenu_logout";
            submenu_logout.Size = new Size(139, 26);
            submenu_logout.Text = "&Logout";
            submenu_logout.Click += submenu_logout_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(136, 6);
            // 
            // submenu_keluar
            // 
            submenu_keluar.Name = "submenu_keluar";
            submenu_keluar.Size = new Size(139, 26);
            submenu_keluar.Text = "&Keluar";
            submenu_keluar.Click += submenu_keluar_Click;
            // 
            // menu_masterdata
            // 
            menu_masterdata.DropDownItems.AddRange(new ToolStripItem[] { subMenuDataBarang });
            menu_masterdata.Enabled = false;
            menu_masterdata.Name = "menu_masterdata";
            menu_masterdata.Size = new Size(104, 24);
            menu_masterdata.Text = "&Master Data";
            // 
            // menu_transaksi
            // 
            menu_transaksi.Enabled = false;
            menu_transaksi.Name = "menu_transaksi";
            menu_transaksi.Size = new Size(82, 24);
            menu_transaksi.Text = "&Transaksi";
            // 
            // menu_pengaturan
            // 
            menu_pengaturan.Enabled = false;
            menu_pengaturan.Name = "menu_pengaturan";
            menu_pengaturan.Size = new Size(97, 24);
            menu_pengaturan.Text = "&Pengaturan";
            // 
            // menu_tentang
            // 
            menu_tentang.Name = "menu_tentang";
            menu_tentang.Size = new Size(76, 24);
            menu_tentang.Text = "&Tentang";
            // 
            // toolStrip
            // 
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { toolbar_barang });
            toolStrip.Location = new Point(0, 30);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(843, 27);
            toolStrip.TabIndex = 1;
            toolStrip.Text = "ToolStrip";
            // 
            // toolbar_barang
            // 
            toolbar_barang.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolbar_barang.Image = (Image)resources.GetObject("toolbar_barang.Image");
            toolbar_barang.ImageTransparentColor = Color.Magenta;
            toolbar_barang.Name = "toolbar_barang";
            toolbar_barang.Size = new Size(29, 24);
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 671);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 19, 0);
            statusStrip.Size = new Size(843, 26);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "Not Login";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(49, 20);
            toolStripStatusLabel.Text = "Status";
            // 
            // subMenuDataBarang
            // 
            subMenuDataBarang.Name = "subMenuDataBarang";
            subMenuDataBarang.Size = new Size(224, 26);
            subMenuDataBarang.Text = "Data Barang";
            subMenuDataBarang.Click += subMenuDataBarang_Click;
            // 
            // Menu_Utama
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(843, 697);
            Controls.Add(statusStrip);
            Controls.Add(toolStrip);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(5);
            Name = "Menu_Utama";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu_Utama";
            WindowState = FormWindowState.Maximized;
            Load += Menu_Utama_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion


        private MenuStrip menuStrip;
        private ToolStrip toolStrip;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabel;
        private ToolTip toolTip;
        public ToolStripMenuItem menu_file;
        public ToolStripMenuItem menu_masterdata;
        public ToolStripMenuItem menu_transaksi;
        private ToolStripMenuItem menu_pengaturan;
        public ToolStripMenuItem menu_tentang;
        public ToolStripMenuItem submenu_login;
        public ToolStripMenuItem submenu_logout;
        private ToolStripSeparator toolStripMenuItem1;
        public ToolStripMenuItem submenu_keluar;
        public ToolStripButton toolbar_barang;
        public ToolStripMenuItem subMenuDataBarang;
    }
}



