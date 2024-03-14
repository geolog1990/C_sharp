// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

using System;


Console.WriteLine("Введите первое число для сравнения");
string inputedString = Console.ReadLine();
int firstNumber = Convert.ToInt32(inputedString);
System.Console.WriteLine("Введите второй число для сравнения");
inputedString = Console.ReadLine();
int SecNumber = Convert.ToInt32(inputedString);

if (firstNumber > SecNumber) 
    {
        Console.WriteLine($"Число {firstNumber} больше");
    }
    else if (firstNumber < SecNumber) 
        {
            Console.WriteLine($"Число {SecNumber} больше");
        }   
        else Console.WriteLine("Ваши числа равны");
