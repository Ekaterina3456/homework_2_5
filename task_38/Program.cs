//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void CreateAray(double[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        double num = new Random().NextDouble();
        array[i] = new Random().Next(-99,100)+num;
    }
}

void PrintArray (double[] array)
{
    foreach (double item in array)
        Console.Write($"{Math.Round(item,4)} ");
    Console.WriteLine();
}

double MinMaxNum (double[] array)
{
    double minnum = array[0];
    double maxnum = array[1];
    double result = 0;
    for (int i =0; i<array.Length; i++)
    {
        if (array[i]<minnum)
            minnum = array[i];
    }
    for (int i=0; i<array.Length; i++)
    {
        if (array[i]>maxnum)
            maxnum = array[i];
    }
    result = maxnum - minnum;
    return result;
}




double[] array = new double [10];
CreateAray(array);
PrintArray(array);
Console.WriteLine($"Разница между максимальным и минимальным значениями равна: {MinMaxNum(array)}");