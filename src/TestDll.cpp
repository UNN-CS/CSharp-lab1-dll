#include "TestDll.h"
#include <iostream>
#include <cstdlib>
#include <ctime>



extern "C" {



	_declspec(dllexport)double Add(double x, double y)	{
		return x + y;
	}

	_declspec(dllexport) void zapolny_massiv(int arr[], int n){
	srand(time(0));
	for (int i = 0; i < n; i++)
		{
			arr[i] = rand() % 100;
		}
	}



}