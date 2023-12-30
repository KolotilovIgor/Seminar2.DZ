//Задача 4: Напишите программу, которая на вход
//принимает натуральное число N, а на выходе
//показывает его цифры через запятую.

Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());

int negNam = -1 * num;

while(negNam <= num)
{
    Console.Write(negNam);
    Console.Write(" ");
    negNam++;
}