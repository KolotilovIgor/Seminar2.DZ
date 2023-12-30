//Задача 3: Напишите программу, которая принимает
//на вход целое число из отрезка [10, 99] и показывает
//наибольшую цифру числа.
int num = new Random().Next(10,100);
Console.WriteLine(num);
int num1 = num/10;
int num2 = num % 10;
if (num1 > num2)
{
    Console.WriteLine("Цифра 1 больше цифры 2: " + num1 + " " + num2);
}
else
{
    Console.WriteLine("Цифра 2 больше цифры 1: " + num1 + " " + num2);
}