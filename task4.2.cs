//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11

//82 -> 10

//9012 -> 12



Console.Clear();

Console.WriteLine("Задача 27");
Console.Write("Напишите число");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (n > 0)
{
   sum += n % 10;
   n = n / 10;
   }

Console.Write(sum);

