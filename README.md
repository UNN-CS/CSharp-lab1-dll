# Смешанное программирование на С++ и С#

**Цель работы:** научиться создавать библиотеки динамической компоновки на С++ и подключать их к проектам на C#.\

## Создание библиотеки динамической компоновки

В пакете Visual Studio создадим новое решение `Lab1` и включим в него проект `TestDll`. Тип: консольное приложение (VS <2017) или пустой проект (VS 2017), потом выставляется опция `Dll`.

В проект помещаются файлы:

**TestDll.h**

```cpp
#pragma once

extern "C" {
   _declspec(dllexport) double Add(double x, double y);
}
```

**TestDll.cpp**

```cpp
#include "TestDll.h"

extern "C" {
   _declspec(dllexport) double Add(double x, double y)
   {
      return x+y;
   }
}
```

Проект необходимо построить и в результате сборке должен появиться файл динамической компоновки `TestDll.dll`

## Создание консольного приложения на C#

В то же решение `Lab1` нужно добавить новый проект **Консольное приложение на C#**

**Program.cs**

```csharp
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace CheckDll
{
   class Program
   {
      [DllImport(@"путь\TestDll.dll",CallingConvention = CallingConvention.Cdecl)]
      static extern double Add(double x,double y);
      static void main(string[] args)
      {
         Console.WriteLine(Add(3,2));
      }
    }
}
```


