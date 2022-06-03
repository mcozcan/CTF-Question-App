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
    public partial class Flag5 : Form
    {
        public Flag5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int a = 1;
            Class1.kontrol5 = a;
            string text = "tht123456";
            if (textBox1.Text == text)
            {
                MessageBox.Show("Helal Olsun Dayı Oglu Flagi Yakaladın :)");
                Thread.Sleep(500);
                Form1 frm = new Form1();
                this.Hide();
                frm.Activate();

            }

            else
            {

                int j = 1;
                while (j > 0)
                {
                    Thread.Sleep(100);
                    MessageBox.Show("Yakalayamadın emmioglu flagi - flag yanlış :)");

                    j--;
                }
            }
        





    }

        private void Flag5_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
