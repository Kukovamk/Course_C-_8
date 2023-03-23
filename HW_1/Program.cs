 // 1: Задайте значения M и N. Напишите программу, которая выведет все чётные
// натуральные числа в промежутке от M до N с помощью рекурсии.



void NumsFromTo(int M, int N)
{
    if (M > N) return;
    if (M % 2 == 0 & M > 0)
    System.Console.Write($"{M}, ");
    NumsFromTo(M + 1, N);
}
System.Console.Write("Введите первое число: ");
int Num = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите второе число: ");
int Num2 = int.Parse(Console.ReadLine()!);


NumsFromTo(Num, Num2);