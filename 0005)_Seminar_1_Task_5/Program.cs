
// напишите программу, которая принемает на вход одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N

// n = Math.Abs(n); → модуль числа

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = (-1) * n; i <= n; i++)
    Console.Write($"{i} ");