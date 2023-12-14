class Program
{
    static void Main()
    {
        
        int M = ReadInt("Введите начальное значение (M): ");
        int N = ReadInt("Введите конечное значение (N): ");

        PrintNumbersInRange(M, N);
    }

    static int ReadInt(string str)
    {
        System.Console.Write(str);
        return Convert.ToInt32(Console.ReadLine());
    }

    static void PrintNumbersInRange(int start, int end)
    {
        
        if (start > end)
            return;

        Console.Write(start + " ");
        PrintNumbersInRange(start + 1, end);
    }
}