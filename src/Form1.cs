using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TestForms
{
    public partial class Form1 : Form
    {
        [DllImport(@"C:\Programs\CSharp\Lab1\Release\SimpleNum.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern bool isPrime(ulong a);
        [DllImport(@"C:\Programs\CSharp\Lab1\Release\SimpleNum.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern ulong nextPrime(ulong a);
        [DllImport(@"C:\Programs\CSharp\Lab1\Release\SimpleNum.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern ulong nPrime(int n);

        public Form1()
        {
            InitializeComponent();
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || textBox1.Text == "Enter the number!!!")
            {
                textBox1.Text = "Enter the number!!!";
            }
            else
            {
                ulong numb = Convert.ToUInt64(textBox1.Text);
                MessageBox.Show(Convert.ToString(isPrime(numb)));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text) || textBox2.Text == "Enter the number!!!")
            {
                textBox2.Text = "Enter the number!!!";
            }
            else
            {
                ulong numb = Convert.ToUInt64(textBox2.Text);
                MessageBox.Show(Convert.ToString((int)nextPrime(numb)));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text) || textBox3.Text == "Enter the number!!!")
            {
                textBox3.Text = "Enter the number!!!";
            }
            else
            {
                int numb = Convert.ToInt32(textBox3.Text);
                MessageBox.Show(Convert.ToString((int)nPrime(numb)));
            }

        }

        private void chart1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.chart1.Series["Kolvo"].Points.Clear();
            ulong left = Convert.ToUInt64(textBox4.Text);
            ulong right = Convert.ToUInt64(textBox5.Text);
            ulong kolvo = 0;
            for (ulong j = 1; j < left; j++)
            {
                if (isPrime(j))
                {
                    kolvo++;
                }
            }
            for (ulong i = left; i < right; i++)
            {
                if (isPrime(i))
                {
                    kolvo++;
                }
                this.chart1.Series["Kolvo"].Points.AddXY(i, kolvo);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Width = 1200;
            Height = 600;
        }
    }
}
