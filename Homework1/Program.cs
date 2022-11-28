//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Write("Input number a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Math.Pow(a,b));