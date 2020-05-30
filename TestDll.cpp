#include "TestDll.h"
#include <cstdlib>
#include <conio.h>
#include <iostream>
#include <ctime>

using namespace std;


extern "C" {

	_declspec(dllexport) double Add(double x, double y)
	{
		return x + y;
	}


_declspec(dllexport) void till(int arr[], int n)
{
	srand(time(0));
	for (int i = 0;i < n;i++)
		arr[i] = rand() % 100;
}

_declspec(dllexport) bool isPrime(unsigned long long num)
{
	bool tr = true;
	if (num == 0 || num == 1)
	{
		tr = false;
		return tr;
	}
	for (int i = 2; i < num;i++)
		if (num%i == 0 )
		{
			tr = false;
			break;
		}
	return tr;
}

_declspec(dllexport) unsigned long nextPrime(unsigned long long num)
{
	unsigned long long t = num + 1;
	while (!isPrime(t))
		t++;
	return t;
}

_declspec(dllexport) unsigned long nPrime(int n)
{
	int k = 1;
	if (n == 0)
	return 0;
	unsigned long t = 1;
	while (k <= n)
	{
		while (!isPrime(++t));
		k++;
	}
	return t;
}


}

