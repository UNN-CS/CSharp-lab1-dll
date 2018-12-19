#pragma once
#include <cstdlib>

extern "C" {
	_declspec(dllexport) bool isPrime(unsigned long a);
	_declspec(dllexport) unsigned long nextPrime(unsigned long a);
	_declspec(dllexport) unsigned long nPrime(int n);
}