namespace SI.App.Presentation
{
    partial class UiMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UiMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.setİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuListUser = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setİşlemleriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddSet = new System.Windows.Forms.ToolStripMenuItem();
            this.setListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.içeriSetAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dışarıSetAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kelimeİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kelimeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kelimeListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.homePanel = new System.Windows.Forms.Panel();
            this.notifyIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazılımcıHakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programHakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.notifyIconMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setİşlemleriToolStripMenuItem,
            this.setİşlemleriToolStripMenuItem1,
            this.kelimeİşlemleriToolStripMenuItem,
            this.ayarlarToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(905, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // setİşlemleriToolStripMenuItem
            // 
            this.setİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddUser,
            this.menuListUser,
            this.kullanıcıDeğiştirToolStripMenuItem});
            this.setİşlemleriToolStripMenuItem.Name = "setİşlemleriToolStripMenuItem";
            this.setİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.setİşlemleriToolStripMenuItem.Text = "Kullanıcı İşlemleri";
            // 
            // menuAddUser
            // 
            this.menuAddUser.Name = "menuAddUser";
            this.menuAddUser.Size = new System.Drawing.Size(169, 22);
            this.menuAddUser.Text = "Kullanıcı Ekle";
            this.menuAddUser.Click += new System.EventHandler(this.MenuAddUser_Click);
            // 
            // menuListUser
            // 
            this.menuListUser.Name = "menuListUser";
            this.menuListUser.Size = new System.Drawing.Size(169, 22);
            this.menuListUser.Text = "Kullanıcı Listele";
            this.menuListUser.Click += new System.EventHandler(this.KullanıcıListeleToolStripMenuItem_Click);
            // 
            // kullanıcıDeğiştirToolStripMenuItem
            // 
            this.kullanıcıDeğiştirToolStripMenuItem.Name = "kullanıcıDeğiştirToolStripMenuItem";
            this.kullanıcıDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.kullanıcıDeğiştirToolStripMenuItem.Text = "Kullanıcı Değiştir";
            this.kullanıcıDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.KullanıcıDeğiştirToolStripMenuItem_Click);
            // 
            // setİşlemleriToolStripMenuItem1
            // 
            this.setİşlemleriToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddSet,
            this.setListeleToolStripMenuItem,
            this.içeriSetAktarToolStripMenuItem,
            this.dışarıSetAktarToolStripMenuItem});
            this.setİşlemleriToolStripMenuItem1.Name = "setİşlemleriToolStripMenuItem1";
            this.setİşlemleriToolStripMenuItem1.Size = new System.Drawing.Size(82, 20);
            this.setİşlemleriToolStripMenuItem1.Text = "Set İşlemleri";
            // 
            // menuAddSet
            // 
            this.menuAddSet.Name = "menuAddSet";
            this.menuAddSet.Size = new System.Drawing.Size(153, 22);
            this.menuAddSet.Text = "Set Ekle";
            this.menuAddSet.Click += new System.EventHandler(this.MenuAddSet_Click);
            // 
            // setListeleToolStripMenuItem
            // 
            this.setListeleToolStripMenuItem.Name = "setListeleToolStripMenuItem";
            this.setListeleToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.setListeleToolStripMenuItem.Text = "Set Listele";
            this.setListeleToolStripMenuItem.Click += new System.EventHandler(this.SetListeleToolStripMenuItem_Click);
            // 
            // içeriSetAktarToolStripMenuItem
            // 
            this.içeriSetAktarToolStripMenuItem.Name = "içeriSetAktarToolStripMenuItem";
            this.içeriSetAktarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.içeriSetAktarToolStripMenuItem.Text = "İçeri Set Aktar";
            this.içeriSetAktarToolStripMenuItem.Click += new System.EventHandler(this.İçeriSetAktarToolStripMenuItem_Click);
            // 
            // dışarıSetAktarToolStripMenuItem
            // 
            this.dışarıSetAktarToolStripMenuItem.Name = "dışarıSetAktarToolStripMenuItem";
            this.dışarıSetAktarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dışarıSetAktarToolStripMenuItem.Text = "Dışarı Set Aktar";
            this.dışarıSetAktarToolStripMenuItem.Click += new System.EventHandler(this.DışarıSetAktarToolStripMenuItem_Click);
            // 
            // kelimeİşlemleriToolStripMenuItem
            // 
            this.kelimeİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kelimeEkleToolStripMenuItem,
            this.kelimeListeleToolStripMenuItem});
            this.kelimeİşlemleriToolStripMenuItem.Name = "kelimeİşlemleriToolStripMenuItem";
            this.kelimeİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.kelimeİşlemleriToolStripMenuItem.Text = "Kelime İşlemleri";
            // 
            // kelimeEkleToolStripMenuItem
            // 
            this.kelimeEkleToolStripMenuItem.Name = "kelimeEkleToolStripMenuItem";
            this.kelimeEkleToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.kelimeEkleToolStripMenuItem.Text = "Kelime Ekle";
            this.kelimeEkleToolStripMenuItem.Click += new System.EventHandler(this.KelimeEkleToolStripMenuItem_Click);
            // 
            // kelimeListeleToolStripMenuItem
            // 
            this.kelimeListeleToolStripMenuItem.Name = "kelimeListeleToolStripMenuItem";
            this.kelimeListeleToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.kelimeListeleToolStripMenuItem.Text = "Kelime Listele";
            this.kelimeListeleToolStripMenuItem.Click += new System.EventHandler(this.KelimeListeleToolStripMenuItem_Click);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayarlarToolStripMenuItem1});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ayarlarToolStripMenuItem.Text = "Araçlar";
            // 
            // ayarlarToolStripMenuItem1
            // 
            this.ayarlarToolStripMenuItem1.Name = "ayarlarToolStripMenuItem1";
            this.ayarlarToolStripMenuItem1.Size = new System.Drawing.Size(111, 22);
            this.ayarlarToolStripMenuItem1.Text = "Ayarlar";
            this.ayarlarToolStripMenuItem1.Click += new System.EventHandler(this.AyarlarToolStripMenuItem1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.notifyIconMenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.NotifyIcon1_DoubleClick);
            // 
            // homePanel
            // 
            this.homePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePanel.Location = new System.Drawing.Point(0, 24);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(905, 587);
            this.homePanel.TabIndex = 2;
            // 
            // notifyIconMenu
            // 
            this.notifyIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHome,
            this.menuExit});
            this.notifyIconMenu.Name = "notifyIconMenu";
            this.notifyIconMenu.Size = new System.Drawing.Size(130, 48);
            // 
            // menuHome
            // 
            this.menuHome.Name = "menuHome";
            this.menuHome.Size = new System.Drawing.Size(180, 22);
            this.menuHome.Text = "Ana Menü";
            this.menuHome.Click += new System.EventHandler(this.MenuHome_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(180, 22);
            this.menuExit.Text = "Çıkış";
            this.menuExit.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yazılımcıHakkındaToolStripMenuItem,
            this.programHakkındaToolStripMenuItem});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // yazılımcıHakkındaToolStripMenuItem
            // 
            this.yazılımcıHakkındaToolStripMenuItem.Name = "yazılımcıHakkındaToolStripMenuItem";
            this.yazılımcıHakkındaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yazılımcıHakkındaToolStripMenuItem.Text = "Yazılımcı Hakkında";
            this.yazılımcıHakkındaToolStripMenuItem.Click += new System.EventHandler(this.YazılımcıHakkındaToolStripMenuItem_Click);
            // 
            // programHakkındaToolStripMenuItem
            // 
            this.programHakkındaToolStripMenuItem.Name = "programHakkındaToolStripMenuItem";
            this.programHakkındaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.programHakkındaToolStripMenuItem.Text = "Program Hakkında";
            this.programHakkındaToolStripMenuItem.Click += new System.EventHandler(this.ProgramHakkındaToolStripMenuItem_Click);
            // 
            // UiMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 611);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(921, 650);
            this.MinimumSize = new System.Drawing.Size(921, 650);
            this.Name = "UiMain";
            this.Text = "UISets";
            this.Load += new System.EventHandler(this.UiMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.notifyIconMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAddUser;
        private System.Windows.Forms.ToolStripMenuItem menuListUser;
        private System.Windows.Forms.ToolStripMenuItem setİşlemleriToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuAddSet;
        private System.Windows.Forms.ToolStripMenuItem setListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem içeriSetAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dışarıSetAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kelimeİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kelimeEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kelimeListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıDeğiştirToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem1;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.ContextMenuStrip notifyIconMenu;
        private System.Windows.Forms.ToolStripMenuItem menuHome;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazılımcıHakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programHakkındaToolStripMenuItem;
    }
}