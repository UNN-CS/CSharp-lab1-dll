#include "TestDll.h"
#include <iostream>
#include <cstdlib>
#include <ctime>

using namespace std;

		
extern "C" {
	_declspec(dllexport) int Prime_li(unsigned long number) {
		int i;
		if (number == 1) return 0;
		for (i = 2; i*i <= number; i++)
		{
			if (number%i == 0)
				return 0;
		}
		return 1;
	}

	_declspec(dllexport) int nextPrime(unsigned long number) {
		do
		{
			number++;
		} while (Prime_li(number) != 1);

		return number;
	}

	_declspec(dllexport) int dai_mne_niy_prime(unsigned long n) {

		int i = 1;
		int j = 1;
		while (j <= n)
		{
			i = nextPrime(i);
			j++;
		}
		return i;
	}

}