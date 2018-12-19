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

namespace Lab1Form
{
    public partial class Form1 : Form
    {
        [DllImport(@"\PrimeDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern bool isPrime(ulong a);
        [DllImport(@"\PrimeDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern ulong nextPrime(ulong a);
        [DllImport(@"\PrimeDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern ulong nPrime(int n);



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ulong numb = Convert.ToUInt64(textBox1.Text);
            MessageBox.Show(Convert.ToString(isPrime(numb)));
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ulong numb = Convert.ToUInt64(textBox2.Text);
            MessageBox.Show(Convert.ToString((int)nextPrime(numb)));            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int numb = Convert.ToInt32(textBox3.Text);
            MessageBox.Show(Convert.ToString((int)nPrime(numb)));

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

    }
}