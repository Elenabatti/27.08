//Напишите программу, которая выводит случайное число из 
//отрезка [10, 99] и показывает наибольшую цифру числа
// 78->8
//12->2
//85->8

//Console.Clear();

//int num = new Random().Next(100, 1000);

//int a1 = num / 100;
//int a2 = num % 10;

//Console.Write(a1);
//Console.WriteLine(a2);

int n = new Random().Next(100,1000);
//int a = n / 100;
//int b = n % 10;
Console.WriteLine(n);
Console.WriteLine((n / 100)*10 +n % 10);