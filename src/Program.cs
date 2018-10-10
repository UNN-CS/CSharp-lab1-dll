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

        [DllImport(@"F:\программы\lab1\Debug\lab1.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern double Add(double x, double y);
        [DllImport(@"F:\программы\lab1\Debug\lab1.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int MasAdd(int[] mas, int n);
        [DllImport(@"F:\программы\lab1\Debug\lab1.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int isPrime(ulong number);
        [DllImport(@"F:\программы\lab1\Debug\lab1.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern ulong nextPrime(ulong number);
        [DllImport(@"F:\программы\lab1\Debug\lab1.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern ulong nPrime(int number);
        static void Main(string[] args)
        {
            int n = 10, f;
            ulong h = 5, f1 = 5;
            int[] mas = new int[n];
            f = isPrime(h);
            if (f == 1)
                Console.WriteLine("prostoe");
            else
                Console.WriteLine("ne prostoe");
            Console.WriteLine("\n");
           
            Console.WriteLine((int)nextPrime(f1));
            Console.WriteLine("\n");
            Console.WriteLine((int)nPrime(5));
            Console.WriteLine("\n");
            Console.WriteLine(Add(3, 2));
            Console.WriteLine("\n");
            MasAdd(mas, n);
            for (int i = 0; i < n; i++)
                Console.WriteLine(mas[i]);
        }

    }
}
