// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

using System;
int[] MyArray = new int[3];
int max;

System.Console.WriteLine("Введите 3 целочисленных числа для выявления наибольшего");
try
{
    for (int i = 0; i < MyArray.Length; i++)
    {
        MyArray[i] = int.Parse(Console.ReadLine());
    }
}
catch (System.Exception)
{
        System.Console.WriteLine("Вы ввели не целочисленное число. Попробуйте снова.");
}
max = MyArray[0];

for (int i = 1; i < MyArray.Length; i++)
{
    if (MyArray[i] > max)
    {
        max = MyArray[i];
    }
}
System.Console.WriteLine($"Наибольшее число {max}");