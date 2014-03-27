using System;
using System.Numerics;

class Tribonacci
{
    static void Main()
    {

        BigInteger t1 = BigInteger.Parse(Console.ReadLine());
        BigInteger t2 = BigInteger.Parse(Console.ReadLine());
        BigInteger t3 = BigInteger.Parse(Console.ReadLine());
        int N = Convert.ToInt32(Console.ReadLine());
        BigInteger[] arrayOfTElements = new BigInteger[N + 1];
        arrayOfTElements[0] = t1;
        arrayOfTElements[1] = t2;
        arrayOfTElements[2] = t3;
        BigInteger consecutiveElement = new BigInteger();
        if (N == 1 || N == 2 || N == 3)
        {
            if (N == 1)
            {
                Console.WriteLine(t1);
            }
            else if (N == 2)
            {
                Console.WriteLine(t2);
            }
            else if (N == 3)
            {
                Console.WriteLine(t3);
            }
            
        }
        else if (N > 3)
        {
            for (int i = 0; i < N - 3; i++)
            {
                consecutiveElement = arrayOfTElements[i] + arrayOfTElements[i + 1] + arrayOfTElements[i + 2];
                arrayOfTElements[i + 3] = consecutiveElement;
            }
            Console.WriteLine(consecutiveElement);
        }
    }
}

