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
        [DllImport(@"C:\Users\Яна\Documents\Visual Studio 2015\Projects\lab1\Debug\TestDll.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern double Add(double x, double y);
        [DllImport(@"C:\Users\Яна\Documents\Visual Studio 2015\Projects\lab1\Debug\TestDll.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern void till(int[] arr, int n);
        [DllImport(@"C:\Users\Яна\Documents\Visual Studio 2015\Projects\lab1\Debug\TestDll.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern bool isPrime(ulong num);
        [DllImport(@"C:\Users\Яна\Documents\Visual Studio 2015\Projects\lab1\Debug\TestDll.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern uint nextPrime(ulong num);
        [DllImport(@"C:\Users\Яна\Documents\Visual Studio 2015\Projects\lab1\Debug\TestDll.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern uint nPrime(int n);


        static void Main(string[] args)
        {
             int n=100;
             int[] arr = new int[n];
             till(arr, n);
             for (int i=0;i<n;i++)
             {
                 Console.WriteLine(arr[i]);
             }
            ulong t = 29;

            Console.WriteLine(Add(3, 2));
            Console.WriteLine(isPrime(t));
            Console.WriteLine(nextPrime(t));
            Console.WriteLine(nPrime(10));
            Console.ReadLine();
        }
    }
}
