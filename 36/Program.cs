double[] CreateArrayRndFloat(int size, double min, double max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 2);
    }
    return array;
}

double FindMax(double[] array)
{
    double max = array[0];
    foreach (double i in array)
    {
        if (i > max) max = i; 
    }
    return max;
}

double FindMin(double[] array)
{
    double min = array[0];
    foreach (double i in array)
    {
        if (i < min) min = i; 
    }
    return min;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    foreach (double item in array)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine("]");
}


double[] array = CreateArrayRndFloat(10, -1000, 1000);

PrintArray(array);
Console.WriteLine($"Разница максимума и минимума = {FindMax(array) - FindMin(array)}");


