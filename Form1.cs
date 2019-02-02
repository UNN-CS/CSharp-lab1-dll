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
/// <summary>
/// /
/// </summary>
namespace CheckDll
{
    public partial class Form1 : Form
    {
        [DllImport(@"C:\Users\настюша\source\repos\Lab1\Num\Num.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern bool isPrime(ulong a);
        [DllImport(@"C:\Users\настюша\source\repos\Lab1\Num\Num.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern ulong nextPrime(ulong a);
        [DllImport(@"C:\Users\настюша\source\repos\Lab1\Num\Num.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern ulong nPrime(int n);

        public Form1()
        {
            InitializeComponent();


        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || textBox1.Text == "Number not found")
            {
                textBox1.Text = "Number not found";
            }
            else
            {
                ulong numb = Convert.ToUInt64(textBox1.Text);
                MessageBox.Show(Convert.ToString(isPrime(numb)));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text) || textBox2.Text == "Number not found")
            {
                textBox2.Text = "Number not found";
            }
            else
            {
                ulong numb = Convert.ToUInt64(textBox2.Text);
                MessageBox.Show(Convert.ToString((int)nextPrime(numb)));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text) || textBox3.Text == "Number not found")
            {
                textBox3.Text = "Number not found";
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    

}
