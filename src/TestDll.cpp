#include "TestDll.h"

extern "C" {
	_declspec(dllexport) double Add(double x, double y)
	{
		return x + y;
	}

	_declspec(dllexport) void print_mas(int* mas, int num) {
		for (int i = 0; i < num; i++) {
			mas[i] = rand() % 10;
			printf("%d ", mas[i]);
		}

	}
}