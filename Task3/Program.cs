class Program
{
    static void Main()
    {
        int arraySize = ReadInt("Введите размер массива: ");

        int[] array = new int[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            array[i] = i + 1;
        }

        PrintArrayReverse(array, array.Length - 1);
    }

    static int ReadInt(string str)
    {
        System.Console.Write(str);
        return Convert.ToInt32(Console.ReadLine());
    }

    static void PrintArrayReverse(int[] arr, int index)
    {

        if (index < 0)
            return;

        Console.Write(arr[index] + " ");

        PrintArrayReverse(arr, index - 1);
    }
}