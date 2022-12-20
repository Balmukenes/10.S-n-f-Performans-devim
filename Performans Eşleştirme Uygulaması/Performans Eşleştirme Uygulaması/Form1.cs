using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Performans_Eşleştirme_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi = 0;
        int puan = 1000;
        int tahminsayisi = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tahmin;
            tahminsayisi++;
            if(tahminsayisi<=10)
            {
                tahmin = int.Parse(textBox1.Text);
                label6.Text=tahminsayisi.ToString();
                if(sayi<tahmin)
                {
                    label5.Text = "Tahmini azaltın";
                    puan = puan - 100;
                    label7.Text = puan.ToString();
                }
                else if(tahmin<sayi)
                {
                    label5.Text = "Tahmini artırınız";
                    puan = puan - 100;
                    label7.Text = puan.ToString();
                }
                else
                {
                    label5.Text = "Tebrikler! " + label6.Text + " Defada bilip, " + label7.Text + "puan aldınız";
                    button2.Enabled = true;
                    button1.Enabled = false;
                }
                textBox1.Text = "";
            }
            else
            {
                textBox1.Enabled = false;
                MessageBox.Show("Tahmin Hakkınız Kalmadı! Oyun Kapatılacak");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            Random r = new Random();
            sayi = r.Next(100);
            label8.Text=sayi.ToString();
            label5.Text = "";
            label6.Text = "0";
            label7.Text = "1000";

        }

       
    }
}
