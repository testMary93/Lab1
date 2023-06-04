using System;

class Program
{
    static void Main()
    {
        int number = 5;
        int factorial = CalculateFactorial(number);

        Console.WriteLine("Факториал числа {0} равен {1}", number, factorial);
    }
    static int CalculateFactorial(int n)
    {
        if (n == 0)
            return 1;
        else
            return n * CalculateFactorial(n - 1);
    }
}
