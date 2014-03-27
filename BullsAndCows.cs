using System;

class BullsAndCows
{
    static void Main()
    {
        string secretNumber = Console.ReadLine();
        int[] secretNumberArray = new int[4];//test 1234
        int[] guessNumberArray = new int[4];//guess number = 1234

        for (int i = 0; i < 4; i++)
        {
            secretNumberArray[i] = Convert.ToInt32(Convert.ToString(secretNumber[i]));
        }
        //bulls test number = 2
        int b = Convert.ToInt32(Console.ReadLine());
        int bullsCount = 0;
        //cows
        int c = Convert.ToInt32(Console.ReadLine());
        int cowsCount = 0;
        bool noBullsOrCows = true;

        for (int i = 1111; i < 10000; i++)
        {
            //Separate digits from int "i" into new array - checkNumberArray 
            int[] checkNumberArray = new int[4];
            checkNumberArray[3] = i % 10;
            checkNumberArray[2] = (i / 10) % 10;
            checkNumberArray[1] = (i / 100) % 10;
            checkNumberArray[0] = (i / 1000);
            if (checkNumberArray[0] != 0 && checkNumberArray[1] != 0 && checkNumberArray[2] != 0 && checkNumberArray[3] != 0)
            {
                for (int d = 0; d < 4; d++)//Loop for counting bulls position test number=5681
                {
                    if (checkNumberArray[d] == secretNumberArray[d])
                    {
                        bullsCount = bullsCount + 1;
                    }
                }
                if (c != 0)
                {
                    for (int q = 0; q < 4; q++)//Loop for counting cows number test number=5681
                    {
                        if (checkNumberArray[q] != secretNumberArray[q])
                        {
                            for (int h = 3; h >= 0; h--)
                            {

                                if (checkNumberArray[q] == secretNumberArray[h] && secretNumberArray[h] != checkNumberArray[h])
                                {
                                    cowsCount = cowsCount + 1;
                                }
                            }
                        }
                    }
                }
                if (bullsCount == b && cowsCount == c)
                {
                    for (int g = 0; g < 4; g++)
                    {
                        Console.Write(checkNumberArray[g]);
                        noBullsOrCows = false;
                    }
                    Console.Write(" ");
                }
                bullsCount = 0;
                cowsCount = 0;
            }
        }
        if (noBullsOrCows == true)
        {
            Console.WriteLine("No");
        }
    }
}


