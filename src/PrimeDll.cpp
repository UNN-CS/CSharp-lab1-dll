#include "PrimeDll.h"



extern "C" {

	_declspec(dllexport) bool isPrime(unsigned long a) {
		if (a % 2 == 0 || a == 1) {
			return false;
		}

		unsigned long int square_root = sqrt(a);
		for (unsigned long int i = 3; i <= square_root; i += 2) {
			if (a % i == 0) {
				return false;
			}
		}

		return true;

	}

	_declspec(dllexport) unsigned long nextPrime(unsigned long a) {
		while (!isPrime(++a))
			;
		return a;
	}

	_declspec(dllexport) unsigned long nPrime(int n) {
		int sum = 0;
		int i = 0;
		while (i <= n)
			sum += isPrime(++i);
		return sum;
	}
}
