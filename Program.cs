using System;

class UniqueQuiz4
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please Enter Input : ");
        int rowCount = int.Parse(Console.ReadLine());
        int range = int.Parse(Console.ReadLine());
        int checkRange = 1 + range * 2;
        int[] population = new int[rowCount];
        int[] result = new int[rowCount - checkRange + 1];
        Console.WriteLine("Please Enter Number for Calculate : ");

        for (int i = 0; i < rowCount; i++)
        {
            population[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < rowCount - checkRange + 1; i++)
        {
            for (int j = 0; j < checkRange; j++)
            {
                result[i] += population[j + i];
            }
        }

        PrintMaxValue(result);
    }

    static void PrintMaxValue(int[] array)
    {
        int maxValue = FindMax(array);
        Console.WriteLine("Result is : [ " + maxValue + " ]");
    }

    static int FindMax(int[] array)
    {
        int max = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (max >= array[i])
                max = max;
            else
                max = array[i];
        }
        return max;
    }
}