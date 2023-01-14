//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16



Console.Clear();

Console.WriteLine("Задача 25");
Console.Write("Введите первое число");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число");
int J = Convert.ToInt32(Console.ReadLine());
// Либо просто Console.Write(Math.Pow(N, J));
int M = 1;
for(int i=0; i < J; i++)
{
M = M * N;
}
Console.Write(M);

