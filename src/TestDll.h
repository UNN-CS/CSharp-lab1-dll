#pragma once
#include <cstdlib>

extern "C" 
{
	_declspec(dllexport) double Add(double x, double y);
	_declspec(dllexport) void till(int arr[], int n);
	_declspec(dllexport) bool isPrime(unsigned long long num);
	_declspec(dllexport) unsigned long nextPrime(unsigned long long num);
	_declspec(dllexport) unsigned long nPrime(int n);
}