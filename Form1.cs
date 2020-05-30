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
        [DllImport(@"C:\Users\Лера\Documents\Visual Studio 2015\Projects\lab1\Debug\TestDll.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern double Add(double x, double y);
        [DllImport(@"C:\Users\Лера\Documents\Visual Studio 2015\Projects\lab1\Debug\TestDll.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern void till(int[] arr, int n);
        [DllImport(@"C:\Users\Лера\Documents\Visual Studio 2015\Projects\lab1\Debug\TestDll.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern bool isPrime(ulong num);
        [DllImport(@"C:\Users\Лера\Documents\Visual Studio 2015\Projects\lab1\Debug\TestDll.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern uint nextPrime(ulong num);
        [DllImport(@"C:\Users\Лера\Documents\Visual Studio 2015\Projects\lab1\Debug\TestDll.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern uint nPrime(int n);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = isPrime(ulong.Parse(textBox1.Text)).ToString();
            textBox3.Text = nextPrime(ulong.Parse(textBox1.Text)).ToString();
            textBox4.Text = nPrime(int.Parse(textBox1.Text)).ToString();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int l = 0;
            for (ulong i=2;i<=100;i++)
            {
                if (isPrime(i))
                    l++;
                chart1.Series[0].Points.AddXY(i, l);
            }

        }
    }
}
