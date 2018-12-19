#include "TestDll.h"
#include<cstdlib>
extern "C" {
	_declspec(dllexport) double Add(double x, double y)
	{
		return x + y;
	}
	_declspec(dllexport) void mas(int* ar, int n) {
		for (int i = 0; i < n; i++) {
			ar[i] = rand() % 100 + 0;
		}
	}
		_declspec(dllexport) int isPrime(long number) {
			int k = number;
			int t = 0;
			if ((number == 0) || (number == 1)) {
				return t;
			}
			for (int i = 2; i <= number; i++) {
				if ((i != number) && (number%i == 0)) {
					return t;
				}
			}
			t++;
			return t;
		}
		_declspec(dllexport) unsigned long nextPrime(unsigned long number) {
			int k = number;
			while (true){
				k++;
				if (isPrime(k) == 1)
					return k;
			}
			}
		_declspec(dllexport) unsigned long nPrime(int n) {
			int k =1;
			int z = 2;
			if (n == 1) {
				return 2;
			}
			while (k != n) {
				z++;
				if (isPrime(z) == 1) {
					k++;
				}
			}
			return z;
		}
		}


	
