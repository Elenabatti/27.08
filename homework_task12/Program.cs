//Напишите программу,которая на вход принимает цифру, обозначающую день недели
// и проверяет является ли этот день выходным

Console.Clear();
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
if (n <= 5) Console.WriteLine("нет");

else 
{
    Console.WriteLine("да, сегодня выходной");
}
