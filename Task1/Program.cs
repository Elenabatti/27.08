//Напишите программу, которая выводит случайное число из отрезка [10, 99]
//Показывает наибольшую цифру числа

Console.Clear();

int num = new Random().Next(10, 100); //74

int a1 = num / 10;
int a2 = num % 10;
 Console.WriteLine(num);

 int max = a1;
 if(a2 > max){
    max = a2;
 }
 Console.WriteLine(max);