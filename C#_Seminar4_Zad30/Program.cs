// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int ind = 0; // индекс массива
int size = 8; // задаем длинну массива
Random value = new Random(); 
int[] massif = new int[size]; // создаем массив заданной длинны, за длинну берем длинну числа num.
while (ind < size) 
{
    massif[ind] = value.Next(0,2);
    ind = ind + 1;
}
Console.WriteLine("Massif [{0}]", string.Join(", ", massif)); // команда выводит на экран массив

// вариант2 создания массива из числа состоящего до 8 знаков (просто меняем size)

// int size = 5; // задаем длинну массива через переменную (что бы можно было менять длинну централизовано)
// Console.Write($"Введите число из {size} знаков - ");
// int num = Convert.ToInt32(Console.ReadLine());
// int ind = 0; // индекс массива
// int [] massif = new int[size]; // создаем массив
// while (ind < size) // условие до которого работает цикл
// {
//     massif[ind] = num % 10; // присваивание каждому индоксу массива значения
//     ind = ind + 1;
//     num = num / 10;
// }
// Console.WriteLine(string.Join(", ", massif)); // команда вывода в консоль массива
// Console.WriteLine("Massif [{0}]", string.Join(", ", massif)); // команда вывода в консоль массива
// int [] arr = new int[size]; // теперь разворачиваем массив, что бы соответствовал введенному числу
// int ind2 = 0;
// ind = ind - 1;
// while (ind2 < size)
// {
//     arr[ind2] = massif[ind];
//     ind2 = ind2 + 1;
//     ind = ind - 1;
// }
// Console.WriteLine("Развернутый массив, соответствующий введенному числу:");
// Console.WriteLine("Arr [{0}]", string.Join(", ", arr));