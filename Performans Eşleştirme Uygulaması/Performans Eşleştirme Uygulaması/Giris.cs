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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }


        Eşleştirme eslestirme = new Eşleştirme();
        private void button1_Click(object sender, EventArgs e)
        {
            eslestirme.Show();
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            eslestirme.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();          
        }
    }
}
