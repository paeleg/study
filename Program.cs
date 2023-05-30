//Task1 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

// double Step(double num1, double num2)
// {
//     double pow = Math.Pow(num1, num2);
//     return pow;
// }
// Console.WriteLine("Input num1");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input num2");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"num1 в степени num2: {Step(num1, num2)}");


//Task2 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int Summ(int num)
// {
//     int summ = 0; 
//     while (num > 0)
//     {
//         summ = summ+num%10;
//         num/=10;
//     }
//     return summ;
// }

// Console.WriteLine("Input num");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Сумма чисел в {num}: {Summ(num)}");

//Task3 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

// int[] CreateRandomArray(int size)
// {
//     size = 8;
//     int[] newArray = new int[size];
//     for(int i = 0; i < 8; i++)
//     {
//         newArray[i] = new Random().Next();
//     }
// return newArray;
// }

// void PrintArray(int[] array)
// {
//     for(int i = 0; i < 1; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// Console.WriteLine();
// }

// int[] myArray = CreateRandomArray(8);

// PrintArray(myArray);