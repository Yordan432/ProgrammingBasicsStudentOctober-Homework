﻿using System;
class SumTheAlphabet
{
    static void Main()
    {
        int sum = 0;
        string input = Console.ReadLine();

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == 'a')
            {
                sum += 1;
            }
            else if(input[i] == 'e')
            {
                sum += 2;
            }
            else if(input[i] == 'i')
            {
                sum += 3;
            }
            else if(input[i] == 'o')
            {
                sum += 4;
            }
            else if(input[i] == 'u')
            {
                sum += 5;
            }
        }
        Console.WriteLine(sum);
    }
}
