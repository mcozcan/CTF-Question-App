using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace THT_CTF_BySciaa
{
    public partial class Flag2 : Form
    {
        public Flag2()
        {
            InitializeComponent();
        }
        public int puan2 { get; set; }



        private void label1_Click(object sender, EventArgs e)
        {

        }
        int x = 100;
        private void button1_Click(object sender, EventArgs e)
        {
            int a = 1;
            Class1.kontrol2 = a;
            string text = "https://www.boylebisiteyok.com/search.php?id=1'";
            if (textBox1.Text == text)
            {
                MessageBox.Show("Helal Olsun Dayı Oglu Flagi Yakaladın :)");
                Thread.Sleep(500);
                Flag3 f1 = new Flag3();
                f1.Show();
                this.Hide();
                puan2 = x;

            }

            else
            {
                x = x -10;
            
                int j = 4;
                while (j > 0)
                {
                    Thread.Sleep(100);
                    MessageBox.Show("Yakalayamadın emmioglu flagi - flag yanlış :)");
                    
                    j--;
                }
            }
        }

        private void Flag2_Load(object sender, EventArgs e)
        {
            x = 100;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
