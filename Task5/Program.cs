//Напиши программу, которая принимает на вход 2 числа и проверяет является ли одно число квадратом другого
Console.Clear();

Console.WriteLine("Первое число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Второе число: ");
int b = int.Parse(Console.ReadLine());

if(a * a == b || b * b == a)
{
Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}