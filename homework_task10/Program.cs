//Напишите программу,которая принимает на вход 3х значное число и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.WriteLine("Введите трёхзначное число: ");

int a = int.Parse(Console.ReadLine());

a = ((a / 10)% 10);

Console.WriteLine(a);

