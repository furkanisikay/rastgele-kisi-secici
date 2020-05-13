using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rastgele_Üretici
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        public string kisilerdosyası = Application.StartupPath + @"\kisiler.txt";
        Random uret = new Random();
        Color[] renkler = { Color.Red, Color.Blue, Color.DarkViolet, Color.HotPink, Color.Green, Color.Orange };
        //string[] kisiler = { };
        //string[] secilenkisiler = { };
        //Form2 fr2 = (Form2)Application.OpenForms["Form2"];
        //Form3 fr3 = (Form3)Application.OpenForms["Form3"];
        //private void form2baslatt()
        //{
        //    Form2 frm2 = new Form2();
        //    Application.Run(frm2);
        //    frm2.Hide();
        //}
        //private void form3baslatt()
        //{
        //    Form3 frm3 = new Form3();
        //    Application.Run(frm3);
        //    frm3.Hide();
        //}

        private void formortala(Form form)
        {
            form.Top = (Screen.PrimaryScreen.Bounds.Height / 2) - (form.Height / 2);
            form.Left = (Screen.PrimaryScreen.Bounds.Width / 2) - (form.Width / 2);
        }


        //Form2 fr2 = (Form2)Application.OpenForms["Form2"];
        private void btnCreate_Click(object sender, EventArgs e)
        {
            int secilen = uret.Next(0, lstKisiler.Items.Count);
            int secilenrenk = uret.Next(0, renkler.Count());

            if(chck_secilenler.Checked == true)
            {
                try
                {
                    lblDurum.ForeColor = renkler[secilenrenk];
                    lblDurum.Text = lstKisiler.Items[secilen].ToString();
                    //new Form2().Show();
                    //fr2.lblSecilenKisi.ForeColor = renkler[secilenrenk];
                    //fr2.lblSecilenKisi.Text = lstKisiler.Items[secilen].ToString();
                    lstCekilenler.Items.Add(lstKisiler.Items[secilen].ToString());
                    lstKisiler.Items.Remove(lstKisiler.Items[secilen].ToString());
                    lblSecilebilecekkisiler.Text = "Seçilebilecek Kişi Sayısı : " + lstKisiler.Items.Count.ToString();
                    lblSecilenkisiler.Text = "Seçilen Kişi Sayısı : " + lstCekilenler.Items.Count.ToString();
                }
                catch(ArgumentOutOfRangeException)
                {
                    lblDurum.Text = "...";
                    //fr2.lblSecilenKisi.Text = "...";
                    MetroMessageBox.Show(this, "Seçilecek Kişi Kalmadı!", "NoviceHacker®", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                        
                }
            }
            else
            {
                lblDurum.Text = string.Format("Seçilen Kişi:\n{0}", lstKisiler.Items[secilen].ToString());
            }
                
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            //fr2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bckwrk_FormLoad.RunWorkerAsync();
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            if (File.Exists(kisilerdosyası))
            {
                lstKisiler.Items.Clear();
                byte[] kisiler = Properties.Resources.kisiler;
                File.WriteAllBytes(kisilerdosyası, kisiler);
                string[] isimler = File.ReadAllLines(kisilerdosyası, Encoding.GetEncoding(1254));
                foreach (string isim in isimler)
                {
                    lstKisiler.Items.Add(isim);
                }
                lblSecilebilecekkisiler.Text = "Seçilebilecek Kişi Sayısı : " + lstKisiler.Items.Count.ToString();
                lblSecilenkisiler.Text = "Seçilen Kişi Sayısı : " + lstCekilenler.Items.Count.ToString();
                if (lstCekilenler.Items.Count > 0)
                {
                    if ((MetroMessageBox.Show(this, "Çekilenler Listesi Temizlensinmi?", "NoviceHacker®", MessageBoxButtons.YesNo, MessageBoxIcon.Error, 100)) == DialogResult.Yes)
                    {
                        lstCekilenler.Items.Clear();
                        lblSecilenkisiler.Text = "Seçilen Kişi Sayısı : " + lstCekilenler.Items.Count.ToString();
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstCekilenler.Items.Clear(); 
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.Width = 685;
            btnShow.Visible = false;
            btnHide.Visible = true;
            btnClose.Location = new Point(642, 10);
            btnTopMostON.Location = new Point(602, 10);
            btnTopMostOFF.Location = new Point(602, 10);
            btnMinimize.Location = new Point(562, 10);
            lblBaslik.FontWeight = MetroLinkWeight.Bold;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.Width = 307;
            btnHide.Visible = false;
            btnShow.Visible = true;
            btnClose.Location = new Point(270, 10);
            btnTopMostON.Location = new Point(230, 10);
            btnTopMostOFF.Location = new Point(230, 10);
            btnMinimize.Location = new Point(190, 10);
            lblBaslik.FontWeight = MetroLinkWeight.Regular;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnTopMostOFF_Click(object sender, EventArgs e)
        {
            this.TopMost = true;
            btnTopMostOFF.Visible = false;
            btnTopMostON.Visible = true;
        }

        private void btnTopMostON_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            btnTopMostON.Visible = false;
            btnTopMostOFF.Visible = true;
        }

        private void lstKisiler_ControlAdded(object sender, ControlEventArgs e)
        {
            lblSecilebilecekkisiler.Text = "Seçilebilecek Kişi Sayısı : " + lstKisiler.Items.Count.ToString();
        }

        private void lstKisiler_ControlRemoved(object sender, ControlEventArgs e)
        {
            lblSecilebilecekkisiler.Text = "Seçilebilecek Kişi Sayısı : " + lstKisiler.Items.Count.ToString();
        }

        private void bckwrk_FormLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            if (File.Exists(kisilerdosyası))
            {
                string[] isimler = File.ReadAllLines(kisilerdosyası, Encoding.GetEncoding(1254));
                foreach (string isim in isimler)
                {
                    lstKisiler.Items.Add(isim);
                }
                this.Width = 307;
                btnClose.Location = new Point(270, 10);
                btnTopMostON.Location = new Point(230, 10);
                btnTopMostOFF.Location = new Point(230, 10);
                btnMinimize.Location = new Point(190, 10);
                lblBaslik.FontWeight = MetroLinkWeight.Regular;
                lblSecilebilecekkisiler.Text = "Seçilebilecek Kişi Sayısı : " + lstKisiler.Items.Count.ToString();
                lblSecilenkisiler.Text = "Seçilen Kişi Sayısı : " + lstCekilenler.Items.Count.ToString();
            }
            else
            {
                MetroMessageBox.Show(this, "Kişi İsimlerinin Bulunduğu Dosya Bulunamadı\nKişiler Gömülü dosyadan Listeye Eklenecektir!!", "NoviceHacker®", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
                byte[] kisiler = Properties.Resources.kisiler;
                File.WriteAllBytes(kisilerdosyası, kisiler);
                string[] isimler = File.ReadAllLines(kisilerdosyası, Encoding.GetEncoding(1254));
                foreach (string isim in isimler)
                {
                    lstKisiler.Items.Add(isim);
                }
                this.Width = 307;
                btnClose.Location = new Point(270, 10);
                btnTopMostON.Location = new Point(230, 10);
                btnTopMostOFF.Location = new Point(230, 10);
                btnMinimize.Location = new Point(190, 10);
                lblBaslik.FontWeight = MetroLinkWeight.Regular;
                lblSecilebilecekkisiler.Text = "Seçilebilecek Kişi Sayısı : " + lstKisiler.Items.Count.ToString();
                lblSecilenkisiler.Text = "Seçilen Kişi Sayısı : " + lstCekilenler.Items.Count.ToString();
            }
            formortala(this);
        }

    }
}
