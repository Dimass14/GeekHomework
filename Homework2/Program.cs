//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int DigitSum(int number)
{
    int sum = 0;
    while(number != 0)
    {
        if(number > 0 || number < 10)
            sum = sum + number;
        if(number > 9 || number < 100)
        {
            sum = sum + number;
        }
    }
    return sum;
}
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The sum of digits in number {num} is {DigitSum(num)}");
// я не понял что надо засунуть внутрь