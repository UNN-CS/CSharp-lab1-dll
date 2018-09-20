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

В то же решение `Lab1` нужно добавить новый проект **Консольное приложение на C#** под именем `CheckDll`

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
      static void Main(string[] args)
      {
         Console.WriteLine(Add(3,2));
      }
    }
}
```

Теперь необходимо построить приложение и запустить его. В случае успеха, на экране должна появиться 6, иначе появятся сообщения об ошибках.

## Работа с массивами

В том же проекте добавить функцию, заполняющую массив целых чисел случайными значениями в диапазоне от 0 до 100. Функцию поместить в Dll, а результат вывести в консольном приложении C#

## Простые числа

Написать динамическую библиотеку для работы с простыми числами. Реализовать в библиотеке следующие функции:

- **int isPrime(unsigned long number)** - проверка числа на простоту
- **unsigned long nextPrime(unsigned long number)** - нахождение ближайшего простого, большего number
- **unsigned long nPrime(int n)** - вычисление n-ого простого числа (в ряду простых чисел)

Написать демонстрационное приложение на C#, использующую функции из динамической библиотеки

## Графический интерфейс

Создать оконное приложение C# для демонстрации работы с простыми числами из Dll.

