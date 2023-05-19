// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Console.Write("Введите число = ");
// int num = Convert.ToInt32(Console.ReadLine());
// int summ = 0;
// for (int i = 1; i <= num; i++)
// {
//     summ = summ + i;
//     }
// Console.WriteLine($"Сумма чисел = {summ}");

// ВАРИАНТ 2:
int num = Convert.ToInt32(new Random().Next(0, 99));
Console.WriteLine($"Нахождение суммы от 1 до числа {num};");
int summ = 0;
int num2 = 1;
while (num2 <= num)
{
    summ = summ + num2;
    num2 = num2 +1;
}
Console.WriteLine($"Сумма чисел = {summ}");