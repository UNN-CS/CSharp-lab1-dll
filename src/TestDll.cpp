#include "TestDll.h"
#include <cstdlib>
#include <iostream>
#include <time.h>
using namespace std;
int is(unsigned long number)
{
	for (unsigned long i = 2; i < number; i++)
	{
		if (number%i == 0)
			return 0;
	}
	return 1;
}
extern "C"
{_declspec(dllexport) double Add(double x, double y) 
{
	return x + y;
}
_declspec(dllexport) int MasAdd(int* mas,int n)
{
	srand(time(0));
	for (int i = 0; i < n; i++)
		mas[i] = rand()%100 ;
	return 0;
}
_declspec(dllexport) int isPrime(unsigned long number)
{
	for (unsigned long i = 2; i < number; i++)
	{
		if (number%i == 0)
			return 0;
	}
	return 1;
}
_declspec(dllexport) unsigned long nextPrime(unsigned long number)
{
	while (1)
	{
		number++;
		if (isPrime(number) == 1)
			return number;
	}
}
	_declspec(dllexport) unsigned long nPrime(int n)
	{
		unsigned long m=2;
		for(int i=1;i<n;i++)
		{
			
			m = nextPrime(m);
		}
		return m;

	}
	
}
