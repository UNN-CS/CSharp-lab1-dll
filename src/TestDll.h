#pragma once
extern "C"
{
	_declspec(dllexport) double Add(double x, double y);
	_declspec(dllexport) double Mass(int x[], int n);
	_declspec(dllexport) int isPrime(int number);
	_declspec(dllexport) int unsigned long  nextPrime(unsigned long number1);
	_declspec(dllexport) int unsigned long nPrime(int n);
}