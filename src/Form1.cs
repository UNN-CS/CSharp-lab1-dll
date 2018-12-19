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

namespace WinCheckDll
{
    public partial class Form1 : Form
    {
        [DllImport(@"C:\Users\TopT\Desktop\C#\Lab1-dll\Debug\TestDll.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern double Add(double x, double y);
        [DllImport(@"C:\Users\TopT\Desktop\C#\Lab1-dll\Debug\TestDll.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int isPrime(ulong number);
        [DllImport(@"C:\Users\TopT\Desktop\C#\Lab1-dll\Debug\TestDll.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern ulong nextPrime(ulong number);
        [DllImport(@"C:\Users\TopT\Desktop\C#\Lab1-dll\Debug\TestDll.dll", CallingConvention = CallingConvention.Cdecl)]
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
            string s1 = textBox1.Text;
            string s2 = textBox2.Text;
            double x = Convert.ToDouble(s1);
            double y = Convert.ToDouble(s2);
            double z = Add(x, y);
            textBox3.Text = z.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = textBox4.Text;
            if (isPrime(Convert.ToUInt32(s)) == 1)
                textBox5.Text = "prost";
            else
                textBox5.Text = "ne prost";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s1 = textBox6.Text;
           ulong s11=nextPrime(Convert.ToUInt32(s1));
            textBox7.Text = ((int)s11).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string s2 = textBox8.Text;
            ulong s21 = nPrime(Convert.ToInt32(s2));
            textBox9.Text = ((int)s21).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int l = 0;
            for(ulong i=2;i<=100;i++)
            {
                if (isPrime(i) == 1)
                    l++;
                chart1.Series[0].Points.AddXY(i, l);
            }
        }
    }
}
