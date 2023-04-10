
// Напишите программу, которая принемает число 
// н вход и проверяет кратно ли оно одновременно 7 и 23

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n % 161 == 0)
    Console.WriteLine("yes");
else
    Console.WriteLine("no");