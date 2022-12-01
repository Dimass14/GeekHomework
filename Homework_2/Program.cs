//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
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
int Sum(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 0)
            sum += 0;
        else
            sum = sum + array[i];
    }
    return sum;
}
Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible number: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);
Console.WriteLine(Sum(myArray));