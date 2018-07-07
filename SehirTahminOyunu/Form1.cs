using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SehirTahminOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] sehirler = {"İStanbul", "Ankara", "İzmir", "Artvin", "Manisa", "Aydın", "Muş", "muğla"
                               ,"Mardin", "Burdur", "Adana", "Artvin", "Sinop", "Kars", "Diyarbakır",
                                "Van", "Sivas"};

        string bulunacakSehirIsmi = "";
        int kalanHak = 4;
        Random rnd = new Random();
        int bulunanHarfSayisi = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            btnHarfGir.Enabled = false;
            btnKelimeGir.Enabled = false;
            rnd = new Random();

            this.AcceptButton = btnHarfGir;
            
        }
        private void yeniSehirSec()
        {
            int rastgeleSayi = rnd.Next(0, sehirler.Length);
            bulunacakSehirIsmi = sehirler[rastgeleSayi];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bulunanHarfSayisi = 0;
            grbSoruAlani.Controls.Clear();
            lblGirilenHarf.Text = "";
            kalanHak = 4;
            yeniSehirSec();
            btnHarfGir.Enabled = true;
            btnKelimeGir.Enabled = true;

            for(int i=0; i<bulunacakSehirIsmi.Length; i++)
            {
                Label label = new Label();
                label.Location = new Point(20 * i + 30, 20);
                label.Text = bulunacakSehirIsmi[i].ToString();
                label.BackColor = Color.Red;
                label.ForeColor = Color.Red;
                //label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                label.Font = FontStyle.Bold;
                label.Size = new System.Drawing.Size(15, 20);
                grbSoruAlani.Controls.Add(label);

            } 
        }

        private void btnHarfGir_Click_1(object sender, EventArgs e)
        {
            bool harfVarmi = false;
            if (txtHarf.Text.Length != 1)
            {
                MessageBox.Show("Lütfen Tek Harf Giriniz.");
            }
            else
            {
                if (lblGirilenHarf.Text.Contains(txtHarf.Text))
                {
                    MessageBox.Show("Lütfen Farklı Bir Harf Giriniz..");
                    txtHarf.Text = "___";
                    txtHarf.Focus();

                    return;
                }
                foreach (Control item in grbSoruAlani.Controls)
                {
                    if (item is Label)
                    {
                        Label label = item as Label;
                        if (label.Text.ToUpper() == txtHarf.Text.ToUpper())
                        {
                            label.BackColor = Color.Lime;
                            label.ForeColor = Color.Black;
                            harfVarmi = true;
                            bulunanHarfSayisi++;
                        }
                    }
                }
            }
            if (!harfVarmi)
            {
                kalanHak--;
                lblKalanHak.Text = kalanHak.ToString();
                if (kalanHak == 0)
                {
                    btnHarfGir.Enabled = false;
                    btnKelimeGir.Enabled = false;
                    MessageBox.Show("Oyun Bitti Kaybettiniz Tekrar Oynamak İçin Yeni Oyuna Başla'ya Tıkla =>"+bulunacakSehirIsmi);
                }
            }
            lblGirilenHarf.Text += txtHarf.Text + " ";

            if (bulunanHarfSayisi == bulunacakSehirIsmi.Length)
            {
                btnHarfGir.Enabled = false;
                btnKelimeGir.Enabled = false;
                MessageBox.Show("Oyun Bitti. Tebrikler Kazandınız.");
            }
            txtHarf.Text = "";
            txtHarf.Focus();

        }

        private void btnKelimeGir_Click(object sender, EventArgs e)
        {
            if(bulunacakSehirIsmi.ToUpper() == txtKelime.Text.ToUpper())
            {
                foreach(Control item in grbSoruAlani.Controls)
                {
                    if(item is Label)
                    {
                        Label label = item as Label;
                        label.BackColor = Color.Lime;
                        label.ForeColor = Color.Black;

                    }
                }
                MessageBox.Show("Tebrikler Tahmininiz Doğru Kazandınız.");
                btnHarfGir.Enabled = false;
                btnKelimeGir.Enabled = false;
            }
            else
            {
                MessageBox.Show("Tahmininiz Yanlış Kaybettiniz Cevap " + bulunacakSehirIsmi + " olacaktı.");
                btnHarfGir.Enabled = false;
                btnKelimeGir.Enabled = false;
            }
        }
    }
}
