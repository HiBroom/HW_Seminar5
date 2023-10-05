// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// Метод для ввода массива.


double[] GetDoubleMasive(int length, int minValue, int maxValue)
{
    double[] array = new double[length];
    var rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.NextDouble() * (maxValue - minValue) + minValue;
    }
    return array;
}
// Метод для вывода массива
void PrintDoubleArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]:F2}; ");
    }
    Console.Write($"{array[array.Length - 1]:F2}");
    Console.Write("] => ");
}
// Мнимальный элемент массива.
double MinElement(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length - 1; i++)  //
    {
        if (min > array[i]) min = array[i];
    }        
    return min;
}
// Максимальный элемент массива.
double MaxElement(double[] array)
{

    double max = array[0];
    for (int i = 1; i <= array.Length - 1; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}



double[] array = GetDoubleMasive(5, 0, 100);
PrintDoubleArray(array);

double maxElement = MaxElement(array);
double minElement = MinElement(array);
Console.WriteLine($"{maxElement:F2} - {minElement:F2} = {maxElement - minElement:F2}");
