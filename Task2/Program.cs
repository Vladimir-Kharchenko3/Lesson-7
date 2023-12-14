class Program
{
    static void Main()
    {
        int m1 = 2, n1 = 3;
        int result1 = AckermannFunction(m1, n1);
        Console.WriteLine($"A({m1}, {n1}) = {result1}");

        int m2 = 3, n2 = 2;
        int result2 = AckermannFunction(m2, n2);
        Console.WriteLine($"A({m2}, {n2}) = {result2}");
    }

    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return AckermannFunction(m - 1, 1);
        }
        else if (m > 0 && n > 0)
        {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
        else
        {
            
            throw new ArgumentException("Аргументы m и n должны быть неотрицательными.");
        }
    }
}