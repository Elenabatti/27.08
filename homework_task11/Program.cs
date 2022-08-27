
Console.Clear();

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());

if( n <= 99) Console.Write("третей цифры нет");
else{

while
(n > 999)
{
    n = n / 10;
}
   Console.Write($"{n % 10 } ");
}