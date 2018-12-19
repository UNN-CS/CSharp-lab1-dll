#pragma once
#include <cstdlib>
#include <stdio.h>

extern "C" {
	_declspec(dllexport) double Add(double x, double y);
	_declspec(dllexport) void print_mas(int* array, int num);
}