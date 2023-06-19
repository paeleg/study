// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// int ShowNumbers(int n)
// {
//     if (n>1)
//     {
//         Console.Write(n + " ");
//         ShowNumbers(n-1);
//     }
//     return 1;
// }

// Console.WriteLine("Input n");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write(ShowNumbers(n));

// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int FindSum(int N, int M)
// {
//     int sum = 0;
//     while (N<=M)
//     {
//         sum+= N;
//         N++;
//     }
//     while (M<=N)
//     {
//         sum+=M;
//         M++;
//     }
//     return sum;
// }

// Console.WriteLine("Input N");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input M");
// int M = Convert.ToInt32(Console.ReadLine());

// Console.Write(FindSum(N, M));

// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int Akerman(int m, int n)
// {
//   if (m == 0)
//     return n + 1;
//   else
//     if ((m != 0) && (n == 0))
//       return Akerman(m - 1, 1);
//     else
//       return Akerman(m - 1, Akerman(m, n - 1));
// }

// Console.WriteLine("Input m");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input n");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write(Akerman(m, n));