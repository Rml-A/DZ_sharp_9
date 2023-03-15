// Задача 68: Функция Аккермана
// m = 2, n = 3 -> A(m,n) = 29

System.Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int Ackerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Ackerman(m - 1, 1);
    else if (m > 0 && n > 0) return Ackerman(m - 1, Ackerman(m, n - 1));
    return Ackerman(m,n);
}


System.Console.WriteLine(Ackerman(m, n));