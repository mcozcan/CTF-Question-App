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
    public partial class Flag3 : Form
    {
        public Flag3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = "flag_thtsiberkurtlar";
            if (textBox1.Text == text)
            {
                int a = 1;
                Class1.kontrol3 = a;
                MessageBox.Show("Helal Olsun Dayı Oglu Flagi Yakaladın :)");
                Thread.Sleep(500);
                Flag4 f1 = new Flag4();
                f1.Show();
                this.Hide();
            }

            else
            {
                int j = 3;
                while (j > 0)
                {
                    Thread.Sleep(100);
                    MessageBox.Show("Yakalayamadın emmioglu flagi - flag yanlış :)");

                    j--;
                }


            }
          
            }

        private void Flag3_Load(object sender, EventArgs e)
        {

        }
    }
}
