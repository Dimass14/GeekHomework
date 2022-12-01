//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
        int[] array = new int[size];
        for(int i = 0; i < size; i++)
            array[i] = new Random().Next(minValue, maxValue + 1);
        return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int PositiveNum(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0)
            count++;
    return count;
}
Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min three digit possible number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max three digit possible number: ");
int max = Convert.ToInt32(Console.ReadLine());
if(min > 99 || min < 100 && max > 99 || max < 1000)
{
    int[] myArray = CreateRandomArray(n, min, max);
    ShowArray(myArray);
    Console.WriteLine(PositiveNum(myArray));
}
else
    Console.WriteLine("ERORR!");