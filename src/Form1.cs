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


namespace Lab1
{
    public partial class Form1 : Form
    {
        [DllImport(@"C:\Users\Lenovo\Desktop\5 семестр\Вмп(сш)- Штанюк\Dlltest\Debug\Dlltest.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int Prime_li(long number);
        [DllImport(@"C:\Users\Lenovo\Desktop\5 семестр\Вмп(сш)- Штанюк\Dlltest\Debug\Dlltest.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int nextPrime(long number);
        [DllImport(@"C:\Users\Lenovo\Desktop\5 семестр\Вмп(сш)- Штанюк\Dlltest\Debug\Dlltest.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int dai_mne_niy_prime(long n);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       

      

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            string t1 = textBox1.Text;
            if (string.IsNullOrWhiteSpace(t1))
            {
                MessageBox.Show("Чет пусто, ты ввел вообще?");
            }
            else
            {
                int k = Convert.ToInt32(t1);
                if (Prime_li(k) == 1)
                {
                    MessageBox.Show("простое");
                }
                else
                {
                    MessageBox.Show("непростое");
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string t2 = textBox1.Text;
            if (string.IsNullOrWhiteSpace(t2))
            {
                MessageBox.Show("Чет пусто, ты ввел вообще?");
            }
            else
            {
                int s = Convert.ToInt32(t2);
                int k = nextPrime(s);
                string t = Convert.ToString(k);
                MessageBox.Show(t);
            }
        
    }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string t3 = textBox1.Text;
            if (string.IsNullOrWhiteSpace(t3))
            {
                MessageBox.Show("Чет пусто, ты ввел вообще?");
            }
            else
            {
                int k = Convert.ToInt32(t3);
                int x = dai_mne_niy_prime(k);
                string t = Convert.ToString(x);
                MessageBox.Show(t);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.chart1.Series[0].Points.Clear(); // указываем на график и очищаем его
            ulong left = Convert.ToUInt32(textBox2.Text);
            ulong right = Convert.ToUInt32(textBox3.Text);
            ulong p = 0;
            for (ulong j = 2; j < left; j++)
            {
                if (Prime_li((int)j) == 1)
                {
                    p++;
                }
            }
            for (ulong i = left; i < right; i++)
            {
                if (Prime_li((int)i) == 1)
                {
                    p++;
                }

                this.chart1.Series[0].Points.AddXY(i, p); //рисуем
            }
        }
    }
}
    

