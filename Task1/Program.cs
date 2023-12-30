//Задача 1: Напишите программу, которая принимает
//на вход число и проверяет, кратно ли оно
//одновременно 7 и 23
Console.Write("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int result1 = num % 7;
int result2 = num % 23;

if ((result1 == 0) && (result2 ==0 ))
{
    Console.Write("Число кратно 7 и 23");
}
else
{
    Console.Write("Число некратно 7 и 23");
}
