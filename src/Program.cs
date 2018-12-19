using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
namespace CheckDll
{
    class Program
    {
        [DllImport(@"C:\Users\student\Documents\Visual Studio 2017\project\Project2\Debug\TestDll.dll", CallingConvention = CallingConvention.Cdecl )]
        static extern double Add(double x, double y);
        [DllImport(@"C:\Users\student\Documents\Visual Studio 2017\project\Project2\Debug\TestDll.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern double Mass(int []x, int n);
        [DllImport(@"C:\Users\student\Documents\Visual Studio 2017\project\Project2\Debug\TestDll.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int isPrime(ulong number);
        [DllImport(@"C:\Users\student\Documents\Visual Studio 2017\project\Project2\Debug\TestDll.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern ulong nextPrime(ulong number);
        [DllImport(@"C:\Users\student\Documents\Visual Studio 2017\project\Project2\Debug\TestDll.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern ulong nPrime(int n);
        static void Main(string[] args)
        {
            int n = 10;
            ulong num = 2;
            ulong z = 13;
            int v = 7;
            int[] a = new int[n];
            Mass(a, n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);
            }
            if (isPrime(num) == 1)
                Console.WriteLine("prost", "\n");
                    else
                 Console.WriteLine("ne prost","\n");
            Console.WriteLine((int)nextPrime(z));
            Console.WriteLine("\n");
            Console.WriteLine((int)nPrime(v));
            Console.WriteLine("\n");
            Console.WriteLine(Add(3, 2));
        }
       
      
    }
}
