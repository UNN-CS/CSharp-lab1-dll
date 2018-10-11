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

namespace FromDLL1
{
    public partial class Form1 : Form
    {
        [DllImport(@"C:\Users\Ivan\source\repos\Lab sh1\Debug\Lab sh1.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern double Add(double x, double y);
        [DllImport(@"C:\Users\Ivan\source\repos\Lab sh1\Debug\Lab sh1.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern void mas(int[] ts, int z);
        [DllImport(@"C:\Users\Ivan\source\repos\Lab sh1\Debug\Lab sh1.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int isPrime(long number);
        [DllImport(@"C:\Users\Ivan\source\repos\Lab sh1\Debug\Lab sh1.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern ulong nextPrime(ulong number);
        [DllImport(@"C:\Users\Ivan\source\repos\Lab sh1\Debug\Lab sh1.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern ulong nPrime(int n);
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string t1 = textBox1.Text;
            if (string.IsNullOrWhiteSpace(t1))
            {
                MessageBox.Show("Enter the number");
            }
            else
            {
                int k = Convert.ToInt32(t1);
                if (isPrime(k) == 1)
                {
                    MessageBox.Show("The number is prime");
                }
                else
                {
                    MessageBox.Show("The number is not simple");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string t2 = textBox2.Text;
            if (string.IsNullOrWhiteSpace(t2))
            {
                MessageBox.Show("Enter the number");
            }
            else
            {
                ulong s = Convert.ToUInt64(t2);
                int k = (int)nextPrime(s);
                string t = Convert.ToString(k);
                MessageBox.Show(t);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string t3 = textBox3.Text;
            if (string.IsNullOrWhiteSpace(t3))
            {
                MessageBox.Show("Enter the number");
            }
            else
            {
                int k = Convert.ToInt32(t3);
                int x = (int)nPrime(k);
                string t = Convert.ToString(x);
                MessageBox.Show(t);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.chart1.Series["Prime"].Points.Clear();
            ulong left = Convert.ToUInt64(textBox5.Text);
            ulong right = Convert.ToUInt64(textBox4.Text);
            ulong p = 0;
            for(ulong j = 2; j < left; j++)
            {
                if (isPrime((int)j) == 1)
                {
                    p++;
                }
            }
            for(ulong i = left; i < right; i++){
                if (isPrime((int)i) == 1)
                {
                    p++;
                }
                this.chart1.Series["Prime"].Points.AddXY(i, p);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

