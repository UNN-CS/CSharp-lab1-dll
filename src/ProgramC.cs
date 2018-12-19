using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace CheckDll
{
    class Program
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
        static void Main(string[] args)
        {
            int m = 101;
            int max = 20;
            int[] ts = new int[max];
            mas(ts, max);
            for(int i = 0; i < max; i++)
            {
                Console.Write(ts[i]+" ");
            }
            Console.WriteLine(Add(3, 2));
            if (isPrime(m) == 0)
                Console.WriteLine("Не простое чилсо");
            else
                Console.WriteLine("Простое число");
            Console.Write((int)nextPrime(97)+" ");
            Console.Write((int)nPrime(100));

        }
        
    }
}