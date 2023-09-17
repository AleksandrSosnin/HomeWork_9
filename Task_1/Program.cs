/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.Write("Введите значение N: ");
string input = Console.ReadLine();

if (int.TryParse(input, out int N))
{
    PrintNaturalNumbers(N);
}
else
{
    Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
}

Console.ReadLine();

static void PrintNaturalNumbers(int n)
{
    if (n < 1)
        return;

    Console.Write(n);
    if (n > 1)
        Console.Write(" ");

    PrintNaturalNumbers(n - 1);
}