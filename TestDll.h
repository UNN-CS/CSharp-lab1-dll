#pragma once
extern "C" {
	_declspec(dllexport) double Add(double x, double y);
	_declspec(dllexport) int MasAdd(int* mas, int n);
	_declspec(dllexport) int Prime(unsigned long number);
	_declspec(dllexport) unsigned long nextPrime(unsigned long number);
}