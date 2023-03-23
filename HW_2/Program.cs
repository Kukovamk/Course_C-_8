// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.

void SumNums(int M, int N, int sum)
{
    if (M > N) return;
        sum = sum + (M ++);
        Console.Write($"{sum}, ");
         SumNums(M, N, sum);
       
}
Console.Write("Введите первое число: ");
int Num = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int Num2 = int.Parse(Console.ReadLine()!);

SumNums(Num, Num2, 0);
