/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int ShowSum (int start, int finish)
{
    if (start >= finish) return ShowSum(start, finish);
    {
      int sum = 0;
      for (int i = start; i<=finish; i++) sum += i;
      return sum;
    }
  }
  
Console.WriteLine($"Введите начало промежутка М = :");
int start = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите конец промежутка N = :");
int finish = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ShowSum(start, finish));