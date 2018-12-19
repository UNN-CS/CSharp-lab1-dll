#include "TestDll.h"
#include <time.h>
#include <iostream>

using namespace std;
extern "C"
{
	_declspec(dllexport) double Add(double x, double y)
	{
		return x + y;
	}
	_declspec(dllexport) double Mass(int x[], int n)
	{
		srand(time_t(0));
		for (int i = 0; i < n; i++)
		{
			x[i] = rand() % 100;

		}
		return 0;
	}
	_declspec(dllexport) int isPrime(int number)
	{
		for (int i = 2; i < number; i++)
		{
			if ((number%i == 0))
				return 0;
		}
		return 1;
	}
	_declspec(dllexport) int unsigned long  nextPrime(unsigned long number)
	{
		for (int i = 0; i < INFINITY; i++)
		{
			number++;
			if (isPrime(number) == 1)
				return number;
		}
	}
	_declspec(dllexport) int unsigned long nPrime(int n)
	{
		unsigned long prost1 = 2;
		for (int i = 1; i < n; i++)
		{
			prost1 = nextPrime(prost1);
		}
		return prost1;
	}
}