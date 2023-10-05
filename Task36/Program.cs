// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// Метод ввода для одномерного массива


int[] OneDemensionalyArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    var rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        // Заполнили случайными числами.
        array[i] = rnd.Next(minValue, maxValue + 1);
    }
    return array;
}
// Метод вывода для одномерного массива
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("] -> ");
}
// Cумма элементов, стоящих на нечётных позициях.
int SumOfUnevenelements(int[] array)
{
    int sum = 0;
    for (int i = 0; i <= array.Length - 1; i++)
    {
        if(i % 2 == 1) sum = sum + array[i];
    }
    return sum;
}
// Задали одномерный массив
int[] array = OneDemensionalyArray(4, -99, 99);
// Распечатали одномерный массив.
PrintArray(array);
// Вывели сумму чисел на нечетных позициях массива.
int sumOfUnevenElements = SumOfUnevenelements(array);
Console.WriteLine(sumOfUnevenElements);