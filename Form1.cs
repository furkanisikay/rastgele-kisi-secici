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
        public string kisilerdosyası = Application.StartupPath + @"\kisiler.txt";
        readonly Random uret = new Random();
        readonly Color[] renkler = { Color.Red, Color.Blue, Color.DarkViolet, Color.HotPink, Color.Green, Color.Orange };
        private readonly Encoding encoding = Encoding.GetEncoding("iso-8859-9");

        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int secilen = uret.Next(0, lstKisiler.Items.Count);
            int secilenrenk = uret.Next(0, renkler.Count());

            if(chck_secilenler.Checked)
            {
                try
                {
                    lblDurum.ForeColor = renkler[secilenrenk];
                    lblDurum.Text = lstKisiler.Items[secilen].ToString();
                    lstCekilenler.Items.Add(lstKisiler.Items[secilen].ToString());
                    lstKisiler.Items.RemoveAt(secilen);
                    lblSecilebilecekkisiler.Text = "Seçilebilecek Kişi Sayısı : " + lstKisiler.Items.Count.ToString();
                    lblSecilenkisiler.Text = "Seçilen Kişi Sayısı : " + lstCekilenler.Items.Count.ToString();

                    SecileniGoster(lstKisiler.Items[secilen].ToString(), renkler[secilenrenk]);
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
                lblDurum.ForeColor = renkler[secilenrenk];
                lblDurum.Text = lstKisiler.Items[secilen].ToString();
                SecileniGoster(lstKisiler.Items[secilen].ToString(), renkler[secilenrenk]);
            }


        }

        private void SecileniGoster(string v, Color color)
        {
            using (Form2 frm2 = new Form2(v,color))
            {
                frm2.ShowDialog();
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
            lstKisiler.Items.Clear();

            if (!File.Exists(kisilerdosyası))
            {
                string kisiler = Properties.Resources.kisiler;
                File.WriteAllText(kisilerdosyası, kisiler, encoding);
            }

            string[] isimler = File.ReadAllLines(kisilerdosyası, encoding);
            IcerikYukle(isimler);
            if (lstCekilenler.Items.Count > 0)
            {
                if ((MetroMessageBox.Show(this, "Çekilenler Listesi Temizlensinmi?", "NoviceHacker®", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 100)) == DialogResult.Yes)
                {
                    lstCekilenler.Items.Clear();
                    lblSecilenkisiler.Text = "Seçilen Kişi Sayısı : " + lstCekilenler.Items.Count.ToString();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstCekilenler.Items.Clear(); 
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            UzunGorunum(true);
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            UzunGorunum(false);
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
            Sabitle(false);
        }

        private void btnTopMostON_Click(object sender, EventArgs e)
        {
            Sabitle(true);
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
            UzunGorunum(false);
            Ortala(this);
            if (File.Exists(kisilerdosyası))
            {
                string[] isimler = File.ReadAllLines(kisilerdosyası, encoding);
                IcerikYukle(isimler);
            }
            else
            {
                MetroMessageBox.Show(this, "Kişi İsimlerinin Bulunduğu Dosya Bulunamadı\nKişiler Gömülü dosyadan Listeye Eklenecektir!!", "NoviceHacker®", MessageBoxButtons.OK, MessageBoxIcon.Warning, 200);
                string kisiler = Properties.Resources.kisiler;
                File.WriteAllText(kisilerdosyası, kisiler, encoding);
                IcerikYukle(File.ReadAllLines(kisilerdosyası, encoding));
            }
        }

        private void IcerikYukle(string[] isimler)
        {
            foreach (string isim in isimler)
            {
                lstKisiler.Items.Add(isim);
            }
            lblSecilebilecekkisiler.Text = "Seçilebilecek Kişi Sayısı : " + lstKisiler.Items.Count.ToString();
            lblSecilenkisiler.Text = "Seçilen Kişi Sayısı : " + lstCekilenler.Items.Count.ToString();
        }

        private void UzunGorunum(bool uzunmu)
        {
            if (uzunmu)
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
            else
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
        }

        private void Sabitle(bool value)
        {
            this.TopMost = !value;
            btnTopMostOFF.Visible = value;
            btnTopMostON.Visible = !value;
        }

        private void Ortala(Form form)
        {
            form.Top = (Screen.PrimaryScreen.Bounds.Height / 2) - (form.Height / 2);
            form.Left = (Screen.PrimaryScreen.Bounds.Width / 2) - (form.Width / 2);
        }
    }
}
