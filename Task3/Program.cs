// Напишите программу, которая на вход будет принимать 2 числа и выводить, является ли 
//второе число кратным первому.
// Если число2 не кратно числу 1, то программа выводит остаток деления.
Console.Clear();
int num1 = Convert.ToInt32(Console.Readline());
int num2 = Convert.ToInt32(Console.Readline());

if (num1 % num2 == 0)
{
    //Console.WriteLine(num1);
    //Console.WriteLine(num2);
    Console.WriteLine("Кратно");
}
else
{
    //Console.Write(num1 );
    //Console.WriteLine(num2);
    Console.Write($"Не кратно");
    Console.Wtiteline(num1 % num2);
}