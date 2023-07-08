// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Console.Write("введите число A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите число B: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int step = a;

// for (int i = 1; i < b; i++)
// {
// step *=a;
// }
// Console.WriteLine("A в степени B равно: " + step);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int len = Length(a);
// Console.WriteLine($"Сумма цифр в числе {a} равно: {Sum(a,len)}");
// int Length(int a)
// {
// int index = 0;
// while (a > 0)
// {
//     a /= 10;
//     index++;
// }
// return index;
// }
//     int Sum(int a, int len)
// {
// int sum = 0;
// for (int i = 1; i <= len; i++)
// {
//     sum += a % 10;
//     a /= 10;
// }
// return sum;
// }

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов в диапазоне от 10 до 1000 и выводит их на экран.
// int lenArray = 8;
// int[] randomArray = new int[lenArray];
// for (int i = 0; i < randomArray.Length; i++)
// {
//     randomArray[i] = new Random().Next(1,1001);
//     Console.Write(randomArray[i] + " ");
// }