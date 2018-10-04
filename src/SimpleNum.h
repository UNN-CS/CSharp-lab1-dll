#pragma once
#include <cstdlib>


extern "C" {
	_declspec(dllexport) double Add(double x, double y);
	_declspec(dllexport) void fullrandom(int* array, int num);
	_declspec(dllexport) bool isPrime(unsigned long a);
	_declspec(dllexport) unsigned long nextPrime(unsigned long a);
	_declspec(dllexport) unsigned long nPrime(int n);
}

