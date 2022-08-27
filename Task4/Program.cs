// Напишите прогпамму, которая принимакет на вход число, и проверяет одновременно кратно ли оно 7 и 23/

Console.Clear();
Console.Write("Введите число");

int n = int.Parse(Console.Readline());

Console.WriteLine(n % 7 == 0 && n % 23 == 0 ? "Да" : "Нет");
