//Задача 4: Напишите программу, которая на вход
//принимает натуральное число N, а на выходе
//показывает его цифры через запятую.
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
for(int i=1;i<=num;i++)
{
if (i % 2 == 0)
    System.Console.Write(i+ " ");
} 