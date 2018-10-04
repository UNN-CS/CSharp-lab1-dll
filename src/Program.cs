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
        [DllImport(@"C:\Programs\CSharp\Lab1\Release\Lab1.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern double Add(double x, double y);
        [DllImport(@"C:\Programs\CSharp\Lab1\Release\Lab1.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern void fullrandom(int[] test, int num);
        [DllImport(@"C:\Programs\CSharp\Lab1\Release\SimpleNum.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern bool isPrime(ulong a);
        [DllImport(@"C:\Programs\CSharp\Lab1\Release\SimpleNum.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern ulong nextPrime(ulong a);
        [DllImport(@"C:\Programs\CSharp\Lab1\Release\SimpleNum.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern ulong nPrime(int n);
        static void Main(string[] args)
        {
            int max = 10;
            int[] test = new int[max];
            Console.WriteLine(Add(3, 2));
            fullrandom(test, max);
            for(int i = 0; i <max; i++)
            {
                Console.Write(test[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(isPrime(1));
            Console.WriteLine(isPrime(2));
            Console.WriteLine(isPrime(3));
            Console.WriteLine(isPrime(99));
            Console.WriteLine((int)nextPrime(97));
            Console.WriteLine((int)nPrime(100));
        }
    }
}
