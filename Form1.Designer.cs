namespace Rastgele_Üretici
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli designer değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        ///Designer desteği için gerekli metottur; bu metodun
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDurum = new MetroFramework.Controls.MetroLink();
            this.chck_secilenler = new MetroFramework.Controls.MetroToggle();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.lstCekilenler = new System.Windows.Forms.ListBox();
            this.lstKisiler = new System.Windows.Forms.ListBox();
            this.lblBaslik = new MetroFramework.Controls.MetroLink();
            this.btnTopMostOFF = new MetroFramework.Controls.MetroLink();
            this.btnMinimize = new MetroFramework.Controls.MetroLink();
            this.btnClose = new MetroFramework.Controls.MetroLink();
            this.btnHide = new MetroFramework.Controls.MetroLink();
            this.btnShow = new MetroFramework.Controls.MetroLink();
            this.btnClear = new MetroFramework.Controls.MetroLink();
            this.btnDefault = new MetroFramework.Controls.MetroLink();
            this.btnCreate = new MetroFramework.Controls.MetroLink();
            this.btnTopMostON = new MetroFramework.Controls.MetroLink();
            this.lblSecilebilecekkisiler = new MetroFramework.Controls.MetroLink();
            this.lblSecilenkisiler = new MetroFramework.Controls.MetroLink();
            this.bckwrk_FormLoad = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lblDurum
            // 
            this.lblDurum.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lblDurum.ForeColor = System.Drawing.Color.Blue;
            this.lblDurum.Location = new System.Drawing.Point(23, 77);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(274, 28);
            this.lblDurum.TabIndex = 1;
            this.lblDurum.Text = "...";
            this.lblDurum.UseCustomForeColor = true;
            this.lblDurum.UseSelectable = true;
            // 
            // chck_secilenler
            // 
            this.chck_secilenler.AutoSize = true;
            this.chck_secilenler.Checked = true;
            this.chck_secilenler.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chck_secilenler.Location = new System.Drawing.Point(161, 147);
            this.chck_secilenler.Name = "chck_secilenler";
            this.chck_secilenler.Size = new System.Drawing.Size(80, 17);
            this.chck_secilenler.TabIndex = 2;
            this.chck_secilenler.Text = "On";
            this.chck_secilenler.UseSelectable = true;
            // 
            // metroLink1
            // 
            this.metroLink1.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroLink1.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroLink1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.metroLink1.Location = new System.Drawing.Point(23, 144);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(140, 23);
            this.metroLink1.TabIndex = 3;
            this.metroLink1.Text = "Seçilenler Listesi Tut";
            this.metroLink1.UseCustomForeColor = true;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // lstCekilenler
            // 
            this.lstCekilenler.FormattingEnabled = true;
            this.lstCekilenler.Location = new System.Drawing.Point(506, 76);
            this.lstCekilenler.Name = "lstCekilenler";
            this.lstCekilenler.Size = new System.Drawing.Size(156, 212);
            this.lstCekilenler.TabIndex = 4;
            // 
            // lstKisiler
            // 
            this.lstKisiler.FormattingEnabled = true;
            this.lstKisiler.Location = new System.Drawing.Point(344, 76);
            this.lstKisiler.Name = "lstKisiler";
            this.lstKisiler.Size = new System.Drawing.Size(156, 212);
            this.lstKisiler.TabIndex = 5;
            this.lstKisiler.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.lstKisiler_ControlAdded);
            this.lstKisiler.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.lstKisiler_ControlRemoved);
            // 
            // lblBaslik
            // 
            this.lblBaslik.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lblBaslik.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblBaslik.Location = new System.Drawing.Point(23, 50);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(281, 27);
            this.lblBaslik.TabIndex = 15;
            this.lblBaslik.Text = "~ Seçilen Kişi ~";
            this.lblBaslik.UseCustomForeColor = true;
            this.lblBaslik.UseSelectable = true;
            // 
            // btnTopMostOFF
            // 
            this.btnTopMostOFF.Image = global::Rastgele_Üretici.Properties.Resources.push27;
            this.btnTopMostOFF.ImageSize = 32;
            this.btnTopMostOFF.Location = new System.Drawing.Point(602, 10);
            this.btnTopMostOFF.Name = "btnTopMostOFF";
            this.btnTopMostOFF.Size = new System.Drawing.Size(34, 34);
            this.btnTopMostOFF.TabIndex = 13;
            this.btnTopMostOFF.UseSelectable = true;
            this.btnTopMostOFF.Click += new System.EventHandler(this.btnTopMostOFF_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = global::Rastgele_Üretici.Properties.Resources.minimize2;
            this.btnMinimize.ImageSize = 32;
            this.btnMinimize.Location = new System.Drawing.Point(562, 10);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(34, 34);
            this.btnMinimize.TabIndex = 12;
            this.btnMinimize.UseSelectable = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::Rastgele_Üretici.Properties.Resources.close33;
            this.btnClose.ImageSize = 32;
            this.btnClose.Location = new System.Drawing.Point(642, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 34);
            this.btnClose.TabIndex = 10;
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnHide
            // 
            this.btnHide.Image = global::Rastgele_Üretici.Properties.Resources.hide;
            this.btnHide.ImageSize = 32;
            this.btnHide.Location = new System.Drawing.Point(263, 138);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(34, 34);
            this.btnHide.TabIndex = 9;
            this.btnHide.UseSelectable = true;
            this.btnHide.Visible = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnShow
            // 
            this.btnShow.Image = global::Rastgele_Üretici.Properties.Resources.show;
            this.btnShow.ImageSize = 32;
            this.btnShow.Location = new System.Drawing.Point(263, 138);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(34, 34);
            this.btnShow.TabIndex = 8;
            this.btnShow.UseSelectable = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnClear
            // 
            this.btnClear.Image = global::Rastgele_Üretici.Properties.Resources.temizle;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.ImageSize = 25;
            this.btnClear.Location = new System.Drawing.Point(506, 297);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(156, 34);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDefault
            // 
            this.btnDefault.Image = global::Rastgele_Üretici.Properties.Resources.recovery1;
            this.btnDefault.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDefault.ImageSize = 24;
            this.btnDefault.Location = new System.Drawing.Point(344, 297);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(156, 34);
            this.btnDefault.TabIndex = 6;
            this.btnDefault.Text = "Varsayılanı Yükle";
            this.btnDefault.UseSelectable = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Image = global::Rastgele_Üretici.Properties.Resources.random_mavi_yuvarlak;
            this.btnCreate.ImageSize = 128;
            this.btnCreate.Location = new System.Drawing.Point(76, 187);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(155, 133);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.UseSelectable = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnTopMostON
            // 
            this.btnTopMostON.Image = global::Rastgele_Üretici.Properties.Resources.pin8;
            this.btnTopMostON.ImageSize = 30;
            this.btnTopMostON.Location = new System.Drawing.Point(602, 10);
            this.btnTopMostON.Name = "btnTopMostON";
            this.btnTopMostON.Size = new System.Drawing.Size(34, 34);
            this.btnTopMostON.TabIndex = 14;
            this.btnTopMostON.UseSelectable = true;
            this.btnTopMostON.Visible = false;
            this.btnTopMostON.Click += new System.EventHandler(this.btnTopMostON_Click);
            // 
            // lblSecilebilecekkisiler
            // 
            this.lblSecilebilecekkisiler.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lblSecilebilecekkisiler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSecilebilecekkisiler.ImageSize = 24;
            this.lblSecilebilecekkisiler.Location = new System.Drawing.Point(344, 50);
            this.lblSecilebilecekkisiler.Name = "lblSecilebilecekkisiler";
            this.lblSecilebilecekkisiler.Size = new System.Drawing.Size(156, 20);
            this.lblSecilebilecekkisiler.TabIndex = 16;
            this.lblSecilebilecekkisiler.Text = "Seçilebilecek Kişi Sayısı : -";
            this.lblSecilebilecekkisiler.UseCustomForeColor = true;
            this.lblSecilebilecekkisiler.UseSelectable = true;
            // 
            // lblSecilenkisiler
            // 
            this.lblSecilenkisiler.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lblSecilenkisiler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSecilenkisiler.ImageSize = 24;
            this.lblSecilenkisiler.Location = new System.Drawing.Point(506, 50);
            this.lblSecilenkisiler.Name = "lblSecilenkisiler";
            this.lblSecilenkisiler.Size = new System.Drawing.Size(156, 20);
            this.lblSecilenkisiler.TabIndex = 17;
            this.lblSecilenkisiler.Text = "Seçilen Kişi Sayısı : -";
            this.lblSecilenkisiler.UseCustomForeColor = true;
            this.lblSecilenkisiler.UseSelectable = true;
            // 
            // bckwrk_FormLoad
            // 
            this.bckwrk_FormLoad.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bckwrk_FormLoad_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 343);
            this.ControlBox = false;
            this.Controls.Add(this.lblSecilenkisiler);
            this.Controls.Add(this.lblSecilebilecekkisiler);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.btnTopMostOFF);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.lstKisiler);
            this.Controls.Add(this.lstCekilenler);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.chck_secilenler);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnTopMostON);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink btnCreate;
        private MetroFramework.Controls.MetroLink lblDurum;
        private MetroFramework.Controls.MetroToggle chck_secilenler;
        private MetroFramework.Controls.MetroLink metroLink1;
        public System.Windows.Forms.ListBox lstCekilenler;
        public System.Windows.Forms.ListBox lstKisiler;
        private MetroFramework.Controls.MetroLink btnDefault;
        private MetroFramework.Controls.MetroLink btnClear;
        private MetroFramework.Controls.MetroLink btnShow;
        private MetroFramework.Controls.MetroLink btnHide;
        private MetroFramework.Controls.MetroLink btnClose;
        private MetroFramework.Controls.MetroLink btnMinimize;
        private MetroFramework.Controls.MetroLink btnTopMostOFF;
        private MetroFramework.Controls.MetroLink btnTopMostON;
        private MetroFramework.Controls.MetroLink lblBaslik;
        private MetroFramework.Controls.MetroLink lblSecilebilecekkisiler;
        private MetroFramework.Controls.MetroLink lblSecilenkisiler;
        private System.ComponentModel.BackgroundWorker bckwrk_FormLoad;
    }
}

