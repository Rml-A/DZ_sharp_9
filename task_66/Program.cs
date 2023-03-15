// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

System.Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

int SumElements(int m, int n, int sum)
{
    sum+=m;

    if (m == n)
    {
        return sum;
    }
    return SumElements(m + 1, n, sum);
}

System.Console.WriteLine(SumElements(m, n, 0));