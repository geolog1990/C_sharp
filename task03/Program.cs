// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

using System;

string inputed;
int number;

System.Console.WriteLine("Введите целое число, которое хотите проверить на четность");
inputed = Console.ReadLine();

try
{
    number = int.Parse(inputed); 
    if (number % 2 == 0) 
    {
        System.Console.WriteLine("четное");
    }
    else 
    {
        System.Console.WriteLine("нечетное");
    }
}
catch (System.Exception)
{
    
    System.Console.WriteLine("Вы ввели некорректное число. Попробуйте снова.");
}
