using System;

class SandGlass
{
    static void Main()
    {
        int N = Convert.ToInt32(Console.ReadLine());
        string[] arrayOfSandGlass = new string[N];

        for (int i = 0; i < N; i++)
        {
            arrayOfSandGlass[i] = "*";
            Console.Write(arrayOfSandGlass[i]);
        }
        Console.WriteLine();
        for (int i = 1; i <= N / 2; i++)
        {
            arrayOfSandGlass[i - 1] = ".";
            arrayOfSandGlass[N - i] = ".";
            for (int k = 0; k < N; k++)
            {
                Console.Write(arrayOfSandGlass[k]);
            }
            Console.WriteLine();
        }
        for (int i = N / 2; i >= 1; i--)
        {
            arrayOfSandGlass[N - i] = "*";
            arrayOfSandGlass[i - 1] = "*";
            for (int k = 0; k < N; k++)
            {
                Console.Write(arrayOfSandGlass[k]);
            }
            Console.WriteLine();
        }
    }
}
