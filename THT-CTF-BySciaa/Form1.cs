using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace THT_CTF_BySciaa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayac = 0;
        int puan = 1000;
        private void button1_Click(object sender, EventArgs e)
        {
            flag_THTHERYERDE f1 = new flag_THTHERYERDE();
            f1.Show();
            
            timer1.Enabled = true;

            button1.Visible = false;
            button2.Visible = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo
            {
                FileName = "https://www.turkhackteam.org/uye/bysciaa.650487/",
                UseShellExecute = true,
            };

            Process.Start(psi);
            timer1.Interval = 45000;
            button2.Visible = false;
            label1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Class1.kontrol1;
            int b = Class1.kontrol2;
            int c = Class1.kontrol3;
            int d = Class1.kontrol4;
            int f = Class1.kontrol5;
            int sonuc2 = a + b + c + d + f;
            if(sonuc2 == 5)
            {
                timer1.Enabled = false;
                int sonuc = puan - sayac;
                label1.Visible = true;
                label1.Text = "TEBRİKLER CTF' i TAMAMLADINIZ PUANINIZ:  " + sonuc;
            }

            else
            {
                MessageBox.Show("Seni gidi hacker önce flaglerin hepsini yakala :) ");
            }
         
        }
    }
}
