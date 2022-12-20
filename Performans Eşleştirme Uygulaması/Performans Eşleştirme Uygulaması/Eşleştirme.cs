using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Performans_Eşleştirme_Uygulaması
{
    public partial class Eşleştirme : Form
    {
        List<string> icons = new List<string>()
        {
            "!",",","b","k","v","w","z","n",//8 çesit icon belirliyoz
            "!",",","b","k","v","w","z","n",//yazım tibine göre ayarladım

        };
        Random rnd = new Random();//random degişken oluşturuyoruz
        int randomindex; 

        Timer t = new Timer();//zamanlayıcı ayalıyoruz 
        Timer t2 = new Timer();//zamanlayıcı ayalıyoruz 
        Button first, second;//2 tane secim yaptığımız için 2 degisken acıyoruz



        public Eşleştirme()
        {
            InitializeComponent();
            t.Tick += T_Tick;//acılış ekranı
            t.Start();
            t.Interval = 3000;//form acılınca 3 sanıye gösteriyo
            Show();
            t2.Tick += T2_Tick;
        }

        private void T2_Tick(object sender, EventArgs e)
        {
            t2.Stop();
            first.ForeColor = first.BackColor;//arka renk değiştirme
            second.ForeColor = second.BackColor;//arka renk değiştirme
            first =null; 
            second=null;
        }

        private void T_Tick(object sender, EventArgs e)
        {
            t.Stop();
            foreach(Button item in Controls)
            {
                item.ForeColor = item.BackColor;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            show();
        }

        private void show()
        {
            Button btn;
            foreach (Button item in Controls)
            {
                btn = item as Button;
                randomindex = rnd.Next(icons.Count);
                btn.Text = icons[randomindex];
                btn.ForeColor = Color.Black;
                icons.RemoveAt(randomindex);
            }
        }
        int sayac = 0;
        private void Buton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;  
            if(first==null)
            {
                first = btn;
                first.ForeColor = Color.Black;
                return;
            }  
            second = btn;
            second.ForeColor = Color.Black;

            if(first.Text==second.Text)
            {
                first.ForeColor = Color.Black;
                second.ForeColor = Color.Black;
                first = null;
                second = null;
                sayac++;
                if(sayac==8)
                {                   
                    Close();
                }
            }
            else
            {
                t2.Start();
                t2.Interval = 1000;


            }
        }
    }
}
