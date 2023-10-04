// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] RandomArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    var rnd = new Random();
    for(int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray( int[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("] -> ");
}

int EvenNumbersArray(int[] array)
{
    int amount = 0;
    for(int i = 0; i < array.Length - 1; i++)
    {
        if(array[i] % 2 == 0)
        {
            amount++; 
        }  
    }
    return amount;
}

int[] array = RandomArray(100, 99, 999);
PrintArray(array);

int evenNumbers = EvenNumbersArray(array);
Console.Write(evenNumbers);


