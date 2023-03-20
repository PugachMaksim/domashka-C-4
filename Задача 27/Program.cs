/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

// int a;
// int n = 0;
// Console.Write("Введите число: ");
// int.TryParse(Console.ReadLine(), out a);
// while (a > 0)
// {
//     n = n + a % 10;
//     a = a / 10;
// }
// Console.WriteLine($"{a} -> {n}");

int A;
int n = 0;
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine(), out A);
Summa(A, n);

int Summa(int chislo, int result)
{
    while (chislo > 0)
 {
     result = result + chislo % 10;
     chislo = chislo / 10;
 }
 return n = result;
}
Console.WriteLine($"{A} -> {n}");