int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

int SumTwoDigitPosition(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum += array[i];
    }
    return sum;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine("]");
}


int[] array = CreateArrayRndInt(10, 100, 1000);

PrintArray(array);
Console.WriteLine($"Сумма чисел на четных позициях = {SumTwoDigitPosition(array)}");


