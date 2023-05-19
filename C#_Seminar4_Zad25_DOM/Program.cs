// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// ВАРИАНТ 1:
// Console.WriteLine("Возведение числа А в натуральную степень В!");
// Console.Write("Ввведите число А - ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ввведите число B - ");
// int numB = Convert.ToInt32(Console.ReadLine());
// int numC = 1;
// int cikl = 1;
// while (cikl <= numB)
// {
//     numC = numC * numA;
//     cikl = cikl + 1;
// }
// Console.WriteLine($"Результат = {numC}");

// ВАРИАНТ 2:
Console.WriteLine("Возведение числа А в натуральную степень В!");
Console.Write("Ввведите число А - ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввведите число B - ");
int numB = Convert.ToInt32(Console.ReadLine());
int numC = 1;
for (int i = 1; i <= numB; i++)
{
    numC = numC * numA;
}
Console.WriteLine($"Результат = {numC}");

// ВАРИАНТ 3:
// Console.WriteLine("Возведение числа А в натуральную степень В!");
// Console.Write("Ввведите число А - ");
// long numA = Convert.ToInt64(Console.ReadLine());
// Console.Write("Ввведите число B - ");
// long numB = Convert.ToInt64(Console.ReadLine());
// long result = Convert.ToInt64(Math.Pow(numA, numB));
// Console.WriteLine($"Результат = {result}");