// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void CreateArray(int[] array)
{
    for (int i=0; i<array.Length; i++)
        array [i] = new Random().Next(100,1000);
}

void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item} ");
    Console.WriteLine();
}

int Find(int[] array)
{
    int count = 0;
    for (int i=0; i<array.Length; i++)
        if (array[i]%2==0)
            count++;
    return count;
}



Console.WriteLine("Введите размерность массива");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int [num];
CreateArray(array);
PrintArray(array);
Console.WriteLine($"Количество чётных чисел в массиве равно: {Find(array)}");

