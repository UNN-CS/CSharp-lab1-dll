#pragma once

extern "C" {
	_declspec(dllexport) double Add(double x, double y);
	_declspec(dllexport) void mas(int* ar,int n);
	_declspec(dllexport) int isPrime(long number);
	_declspec(dllexport) unsigned long nextPrime(unsigned long number);
	_declspec(dllexport) unsigned long nPrime(int n);
}
