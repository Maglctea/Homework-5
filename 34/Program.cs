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

int CountTwoDigitInt(int[] array)
{
    int count = 0;
    foreach (int i in array)
    {
        if (i % 2 == 0) count++;
    }
    return count;
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
Console.WriteLine($"Количество четных чисел = {CountTwoDigitInt(array)}");


