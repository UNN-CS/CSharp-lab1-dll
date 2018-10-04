#include "SimpleNum.h"



extern "C" {
	_declspec(dllexport) double Add(double x, double y)
	{
		return x + y;
	}

	_declspec(dllexport) void fullrandom(int* array, int num) {
		for (int i = 0; i < num; i++) {
			array[i] = rand() % 10 + 0;
		}
	}

	_declspec(dllexport) bool isPrime(unsigned long a) {
		if (a == 0) {
			return false;
		}
		if (a == 1 | a == 2) {
			return true;
		}
		for (int i = 2; i < a; i++) {
			if (a % i == 0) {
				return false;
			}
		}
		return true;

	}

	_declspec(dllexport) unsigned long nextPrime(unsigned long a) {
		for (int i = a+1; ; i++) {
			if (isPrime(i) == true) {
				a = i;
				return a;
			}
		}
	}

	_declspec(dllexport) unsigned long nPrime(int n) {
		if (n == 1) {
			return 1;
		}
		if (n == 2) {
			return 2;
		}

		int i = 2;
		int all = 2; 
		while (i != n) {
			all++;
			if (isPrime(all)) {
				i++;
			}
		}
		return all;
	}

}