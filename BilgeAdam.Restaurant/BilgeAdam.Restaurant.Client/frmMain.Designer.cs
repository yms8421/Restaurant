namespace BilgeAdam.Restaurant.Client
{
    partial class frmMain
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
            this.mstMain = new System.Windows.Forms.MenuStrip();
            this.uygulamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervasyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msbNewReservation = new System.Windows.Forms.ToolStripMenuItem();
            this.masalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masaÇıkışıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelUyarısıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.msbNewClient = new System.Windows.Forms.ToolStripMenuItem();
            this.msbClients = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniSiparişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapDetayıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemeAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mstMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstMain
            // 
            this.mstMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uygulamaToolStripMenuItem,
            this.rezervasyonToolStripMenuItem,
            this.siparişToolStripMenuItem});
            this.mstMain.Location = new System.Drawing.Point(0, 0);
            this.mstMain.Name = "mstMain";
            this.mstMain.Size = new System.Drawing.Size(800, 24);
            this.mstMain.TabIndex = 0;
            this.mstMain.Text = "menuStrip1";
            // 
            // uygulamaToolStripMenuItem
            // 
            this.uygulamaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkındaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.uygulamaToolStripMenuItem.Name = "uygulamaToolStripMenuItem";
            this.uygulamaToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.uygulamaToolStripMenuItem.Text = "Uygulama";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // rezervasyonToolStripMenuItem
            // 
            this.rezervasyonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msbNewReservation,
            this.masalarToolStripMenuItem,
            this.toolStripSeparator1,
            this.msbNewClient,
            this.msbClients});
            this.rezervasyonToolStripMenuItem.Name = "rezervasyonToolStripMenuItem";
            this.rezervasyonToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.rezervasyonToolStripMenuItem.Text = "Rezervasyon";
            // 
            // msbNewReservation
            // 
            this.msbNewReservation.Name = "msbNewReservation";
            this.msbNewReservation.Size = new System.Drawing.Size(164, 22);
            this.msbNewReservation.Text = "Yeni Rezervasyon";
            this.msbNewReservation.Click += new System.EventHandler(this.msbNewReservation_Click);
            // 
            // masalarToolStripMenuItem
            // 
            this.masalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masaÇıkışıToolStripMenuItem,
            this.personelUyarısıToolStripMenuItem});
            this.masalarToolStripMenuItem.Name = "masalarToolStripMenuItem";
            this.masalarToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.masalarToolStripMenuItem.Text = "Masalar";
            // 
            // masaÇıkışıToolStripMenuItem
            // 
            this.masaÇıkışıToolStripMenuItem.Name = "masaÇıkışıToolStripMenuItem";
            this.masaÇıkışıToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.masaÇıkışıToolStripMenuItem.Text = "Masa Çıkışı";
            // 
            // personelUyarısıToolStripMenuItem
            // 
            this.personelUyarısıToolStripMenuItem.Name = "personelUyarısıToolStripMenuItem";
            this.personelUyarısıToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.personelUyarısıToolStripMenuItem.Text = "Personel Uyarısı";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(161, 6);
            // 
            // msbNewClient
            // 
            this.msbNewClient.Name = "msbNewClient";
            this.msbNewClient.Size = new System.Drawing.Size(164, 22);
            this.msbNewClient.Text = "Yeni Müşteri";
            this.msbNewClient.Click += new System.EventHandler(this.msbNewClient_Click);
            // 
            // msbClients
            // 
            this.msbClients.Name = "msbClients";
            this.msbClients.Size = new System.Drawing.Size(164, 22);
            this.msbClients.Text = "Müşteriler";
            this.msbClients.Click += new System.EventHandler(this.msbClients_Click);
            // 
            // siparişToolStripMenuItem
            // 
            this.siparişToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniSiparişToolStripMenuItem,
            this.hesapDetayıToolStripMenuItem,
            this.ödemeAlToolStripMenuItem});
            this.siparişToolStripMenuItem.Name = "siparişToolStripMenuItem";
            this.siparişToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.siparişToolStripMenuItem.Text = "Sipariş";
            // 
            // yeniSiparişToolStripMenuItem
            // 
            this.yeniSiparişToolStripMenuItem.Name = "yeniSiparişToolStripMenuItem";
            this.yeniSiparişToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.yeniSiparişToolStripMenuItem.Text = "Yeni Sipariş";
            // 
            // hesapDetayıToolStripMenuItem
            // 
            this.hesapDetayıToolStripMenuItem.Name = "hesapDetayıToolStripMenuItem";
            this.hesapDetayıToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.hesapDetayıToolStripMenuItem.Text = "Hesap Detayı";
            // 
            // ödemeAlToolStripMenuItem
            // 
            this.ödemeAlToolStripMenuItem.Name = "ödemeAlToolStripMenuItem";
            this.ödemeAlToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.ödemeAlToolStripMenuItem.Text = "Ödeme Al";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mstMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mstMain;
            this.Name = "frmMain";
            this.Text = "Lokantası Sistemi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mstMain.ResumeLayout(false);
            this.mstMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstMain;
        private System.Windows.Forms.ToolStripMenuItem uygulamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervasyonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msbNewReservation;
        private System.Windows.Forms.ToolStripMenuItem masalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masaÇıkışıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelUyarısıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniSiparişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapDetayıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödemeAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msbNewClient;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem msbClients;
    }
}

