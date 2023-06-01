// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void CreateAray(int[] array)
{
    for(int i=0; i<array.Length; i++)
        array[i] = new Random().Next(-99,100);
}

void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item} ");
    Console.WriteLine();
}

int Summ (int[] array)
{
    int sum = 0;
    for (int i=0; i<array.Length; i++)
    {
        if (i%2 != 0)
            sum += array[i];
    }
    return sum;
}



Console.WriteLine("сгенирирован массив");
int[] array = new int [15];
CreateAray(array);
PrintArray(array);
Console.WriteLine($"сумма элементов стоящих на нечётных позициях равна: {Summ(array)}");