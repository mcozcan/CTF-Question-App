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
    public partial class flag_THTHERYERDE : Form
    {
        public flag_THTHERYERDE()
        {
            InitializeComponent();
        }
        public int puan1 { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "evet" || textBox1.Text == "Evet" || textBox1.Text == "EVET")
            {

                MessageBox.Show("O Kadar da kolay değil be emmioğlu");

            }

            int i = 0;
            if (textBox1.Text == "flag_THTHERYERDE")
            {
                int a = 1;
                Class1.kontrol1 = a;
                MessageBox.Show("Helal Olsun Dayı Oglu Flagi Yakaladın :)");
                Thread.Sleep(500);
                Flag2 f1 = new Flag2();
                f1.Show();
                this.Hide();
            }

            else
            {
                
                int j = 5;
                while(j>0)
                {
                    Thread.Sleep(100);
                    MessageBox.Show("Yakalayamadın emmioglu flagi - flag yanlış :)");
                    
                    j--;
                }


            }
        }

        private void flag_THTHERYERDE_Load(object sender, EventArgs e)
        {

        }
    }
}
