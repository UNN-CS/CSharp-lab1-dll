#include "TestDll.h"



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
}