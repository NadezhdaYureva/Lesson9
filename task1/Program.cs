// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

void RecursiveMToN(int M, int N)
{
    if (N < M)
    {
        return;
    }
    else
    {
        {
            if (M % 2 == 0)
            {
                System.Console.Write($"{M}  ");
            }
            RecursiveMToN(M + 1, N);
        }
    }
}

int Prompt(string console)
{
    System.Console.WriteLine(console);
    string numberStr = Console.ReadLine();
    return int.Parse(numberStr);
}

void Solve()
{
    int m = Prompt("Введите число M");
    int n = Prompt("Введите число N");
    RecursiveMToN(m, n);

}

Solve();