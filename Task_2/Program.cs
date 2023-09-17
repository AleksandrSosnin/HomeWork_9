/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int sum = 0;
void PrintNumbers(int num1, int num2)
{
for (int i = num1; i <= num2; i++)
{
    sum += i;
}

Console.WriteLine("Сумма натуральных чисел от " + num1 + " до " + num2 + " равна " + sum);
}

int firstNum = InputNum("Введите первое число: ");
int secondNum = InputNum("Введите второе число: ");
PrintNumbers(firstNum, secondNum);