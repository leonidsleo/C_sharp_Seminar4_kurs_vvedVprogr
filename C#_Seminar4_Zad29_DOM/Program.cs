//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int size = 8;
Console.WriteLine($"Массив из {size} элементов;");
int[] massif = new int[size];
for (int i = 0; i < size; i++)
{
    massif[i] = new Random().Next(-999, 999);
}
Console.WriteLine("Massif [{0}]", string.Join(", ", massif));