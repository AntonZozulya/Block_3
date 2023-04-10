
// Console.Clear(); → очистка консоли
// int n = Convert.ToInt32(Console.ReadLine()); → первый вариант ввода числа (не важно что выбрать)
// int n = int.Parse(Console.ReadLine()!); → первый вариант ввода числа (не важно что выбрать)
// Console.ReadLine → принемает данные в консоль
// onsole.WriteLine → выводит данне в консоль
// Console.WriteLine(n * 3); → выводит результат 

// CTRL + / = закоментировать или раскоментировать 

// Проверка равны ли числа между собой 1 == 1
// Проверка на неравенство чисел 1 != 1

// ДЕМОНСТРАЦИЯ КОДА 1 ВАРИАНТ
// Console.Clear();
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(x * 3);
// 10 * 3 = 15

// ДЕМОНСТРАЦИЯ КОДА 2 ВАРИАНТ
// Console.Clear();
// int x = int.Parse(Console.ReadLine()!);
// Console.WriteLine(x * 3);
// 10 * 3 = 15


// __________________________________________________________________________________________________________________


// Необходимо спросить у пользователя 2 числа и узнать, какое из них наибольшее, к примеру 1 или 2 ?

// Console.Clear(); → очистка консоли
// Console.Write("Введите 1-ое число: "); → консоль интерфейса
// int a = Convert.ToInt32(Console.ReadLine()); → вариант ввода числа 
// Console.Write("Введите 2-ое число: "); → консоль интерфейса
// int b = Convert.ToInt32(Console.ReadLine());

// Интерполяция строк → создание сложных строк из простых, 
// к примеру вывод результата / значения подробно

// ПРИМЕР ВЫВОДА БЕЗ ИНТЕРПОЛЯЦИИ
// Console.Clear(); 
// Console.Write("Введите 1-ое число: "); 
// int a = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите 2-ое число: "); 
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Результат a + b"); → простая строка без интерполции

// ПРИМЕР ВЫВОДА С ИНТЕРПОЛЯЦИЕЙ
// Console.Clear(); 
// Console.Write("Введите 1-ое число: "); 
// int a = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите 2-ое число: "); 
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Результат {a} + {b} = {a + b}"); → сложная строка - интерполяция 


// __________________________________________________________________________________________________________________


// ПРОВЕРКА УСЛОВИЯ БОЛЬШЕ ЛИ 1ОЕ ЧИСЛО 2ГО?
// Console.Clear(); 
// Console.Write("Введите 1-ое число: "); 
// int a = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите 2-ое число: "); 
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine( a > b);

// ПРОВЕРКА УСЛОВИЯ БОЛЬШЕ ЛИ 1ОЕ ЧИСЛО 2ГО? МЕНЬШЕ? ИЛИ ОНИ РАВНЫ?
// Console.Clear(); 
// Console.Write("Введите 1-ое число: "); 
// int a = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите 2-ое число: "); 
// int b = Convert.ToInt32(Console.ReadLine());
// if (a > b) 
//     Console.WriteLine(a);
// else if (a < b) → иначе если 
//     Console.WriteLine(b);
// else
//     Console.WriteLine("Числа равны");


// __________________________________________________________________________________________________________________


// КАК РАБОТАЕТ ЦИКЛ FOR
// for(int i = 1; i <= 10; i++) // 1 2 3 4 5 6 7 8 9 10 
//     Console.Write($"{i} ");

// Console.WriteLine();
// for(int i = 1; i <= 10; i+=2) // 1 3 5 7 9
//     Console.Write($"{i} ");

// Console.WriteLine();
// for(int i = 10; i > 0; i--) // 10 9 8 7 6 5 4 3 2 1
//     Console.Write($"{i} ");