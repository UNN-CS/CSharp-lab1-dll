#pragma once
#include <cstdlib>


extern "C" {
	_declspec(dllexport) double Add(double x, double y);
	_declspec(dllexport) void fullrandom(int* array, int num);
}

