// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// Console.Write("Введите число num = ");
// long num = Convert.ToInt64(Console.ReadLine());
// long work = 1;
// long i = 1;
// // for (long i = 1; i <= num; i++)
// // {
// //     work = work * i;
// // }
// // Console.WriteLine($"Произведение от 1 до числа {num} равно {work}");
// if (num <= 20)
// {
//     while (i <= num)
//     {
//         work = work * i;
//         i++;
//     }
//     Console.WriteLine($"Произведение от 1 до числа {num} равно {work}");
// }
// else
// {
//     Console.WriteLine($"Произведение всех чисел до {num} слишком велико. Введите число менее 21");
// }

Console.Write("Введите число num = ");
long num = Convert.ToInt64(Console.ReadLine());
long work = 1;
if (num <= 20)
{
    for (long i = 1; i <= num; i++)
    {
        work = work * i;
    }
    Console.WriteLine($"Произведение от 1 до числа {num} равно {work}");
}
else
{
    Console.WriteLine($"Произведение всех чисел до {num} слишком велико. Введите число менее 21");
}
