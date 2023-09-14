// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

// int n = EnterNumbers("Введите N: ");
// int count = 2;
// PrintNumber(n, count);
// Console.Write(1);

// void PrintNumber(int n, int count)
// {
//     if (count > n) 
//     return;
    
//     PrintNumber(n, count + 1);
//     Console.Write(count + ", ");
// }

// int EnterNumbers(string input)
// {
//     Console.Write(input);
//     int output = Convert.ToInt32(Console.ReadLine());
//     return output;
// }

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// int m = EnterNumbers("Введите M: ");
// int n = EnterNumbers("Введите N: ");
// int temp = m;

// if (m > n)
// {
//     m = n;
//     n = temp;
// }

// Printsum(m, n, temp = 0);

// void Printsum(int m, int n, int sum)
// {
//     sum = sum + n;
//     if (n <= m)
//     {
//         Console.Write($"Сумма элементов = {sum} ");
//         return;
//     }
//     Printsum(m, n - 1, sum);
// }

// int EnterNumbers(string input)
// {
//     Console.Write(input);
//     int output = Convert.ToInt32(Console.ReadLine());
//     return output;
// }