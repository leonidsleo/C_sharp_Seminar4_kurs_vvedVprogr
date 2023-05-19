//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
Console.WriteLine("Сумма всех цифр введенного числа!");
Console.Write("Введите число - ");
int num = Convert.ToInt32(Console.ReadLine());
int size = (int)Math.Log10(num) + 1;
//Console.WriteLine($"Длинна {size}");
int summ = 0;
for (int i = 1; i <= size; i++)
{
    int num2 = num % 10;
    summ = summ + num2;
    num = num / 10;
}
Console.WriteLine($"Сумма {summ}");