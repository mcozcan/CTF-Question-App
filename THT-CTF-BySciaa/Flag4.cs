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
    public partial class Flag4 : Form
    {
        public Flag4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                 string text = "capturetheflag";
            if (textBox1.Text == text)
            {
                int a = 1;
                Class1.kontrol4 = a;
                MessageBox.Show("Helal Olsun Dayı Oglu Flagi Yakaladın :)");
              
                Flag5 f1 = new Flag5();
                f1.Show();
                this.Hide();
            }

            else
            {

                int j = 2;
                while (j > 0)
                {
                    Thread.Sleep(100);
                    MessageBox.Show("Yakalayamadın emmioglu flagi - flag yanlış :)");

                    j--;
                }
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Flag4_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adım adım ilerle birden fazla şifreleme tekniği kullanılmıştır belki...");
        }
    }
}
