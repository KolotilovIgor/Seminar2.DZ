//Задача 4: Напишите программу, которая на вход
//принимает натуральное число N, а на выходе
//показывает его цифры через запятую.

Console.WriteLine("введите число");
string? num = Console.ReadLine();
char[] arr = num.ToCharArray();
Console.WriteLine();
for (int i = 0; i < num.Length; i++)
      {
         Console.Write("{1}, ", i, arr[i]);
     }
