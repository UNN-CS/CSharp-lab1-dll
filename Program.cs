using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace lab1_mayorov
{
    class Program
    {

        [DllImport(@"C:\Users\user\source\repos\lab11\Debug\Project1.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern double Add(double x, double y);
        [DllImport(@"C:\Users\user\source\repos\lab11\Debug\Project1.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int MasAdd(int[] mas, int n);
        [DllImport(@"C:\Users\user\source\repos\lab11\Debug\Project1.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int Prime(ulong number);
        [DllImport(@"C:\Users\user\source\repos\lab11\Debug\Project1.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern ulong nextPrime(ulong number);
        [DllImport(@"C:\Users\user\source\repos\lab11\Debug\Project1.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern ulong nPrime(int number);
        static void Main(string[] args)
        {
            int n = 10, f;
            ulong h = 5, f1 = 5;
            int[] mas = new int[n];
            f = isPrime(h);
            if (f == 1)
                Console.WriteLine("простое");
            else
                Console.WriteLine("не простое");
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