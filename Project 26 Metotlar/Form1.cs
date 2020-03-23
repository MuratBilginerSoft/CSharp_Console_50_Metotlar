using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_26_Metotlar
{
    public partial class Form1 : Form
    {
        #region Parameters

        int s1, s2, s3;

        #endregion

        private void DeğerAl(string x1, string x2)
        {
            s1 = int.Parse(x1);
            s2 = int.Parse(x2);
        }

        public Form1() // Yapıcı Metot Constractor Metod
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            string y1 = textBox1.Text;
            string y2 = textBox2.Text;

            DeğerAl(y1, y2);

            s3 = s1 + s2;

            label1.Text = s3.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeğerAl(textBox1.Text, textBox2.Text);

            s3 = s1 - s2;

            label1.Text = s3.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeğerAl(textBox1.Text, textBox2.Text);

            s3 = s1 * s2;

            label1.Text = s3.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeğerAl(textBox1.Text, textBox2.Text);

            s3 = s1 / s2;

            label1.Text = s3.ToString();
        }
    }
}
