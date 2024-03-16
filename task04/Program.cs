// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

using System;

string input;
int ArrSize;

System.Console.WriteLine("Задайте число, до которого нужно вывести все четные числа");

try
{
    input = Console.ReadLine();
    ArrSize = int.Parse(input);
    int[] MyArray = new int[ArrSize/2 + 1];
    for (int i = 0; i < ArrSize/2 + 1; i++)
    {
        MyArray[i] = i * 2;
    }

    for (int i = 1; i < MyArray.Length; i++)
    {
        System.Console.Write(MyArray[i] + " ");
    }
}
catch (System.Exception)
{
    
    System.Console.WriteLine("Вы ввели не целочисленное число. Попробуйте снова.");;
}
