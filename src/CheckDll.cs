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
        [DllImport(@"\TestDll.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern double Add(double x, double y);
        [DllImport(@"\TestDll.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern void print_mas(int[] test, int num);
        [DllImport(@"\PrimeDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern bool isPrime(ulong a);
        [DllImport(@"\PrimeDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern ulong nextPrime(ulong a);
        [DllImport(@"\PrimeDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern ulong nPrime(int n);




        static void Main(string[] args)
        {
            int[] test = new int[10];
            Console.WriteLine(Add(3, 2));
            print_mas(test, 10);
            Console.WriteLine();
            Console.WriteLine(isPrime(3));
            Console.WriteLine((int)nextPrime(33));
            Console.WriteLine((int)nPrime(25));
        }
    }
}
