﻿using ChallengeSolutions.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace PuzzleSolutions.Y2021
{
    public static class Y2021_D1
    {
        public static string SolvePart1()
        {
            List<int> puzzleInput = MyIO.ReadIntsFromFile(2021, 1, 1);
            int numberOfIncreases = 0;
            int previousReading = 0;
            foreach (int reading in puzzleInput)
            {

                if (reading > previousReading)
                {
                    numberOfIncreases = numberOfIncreases + 1;

                    Console.WriteLine($"{reading} = (increased)");
                }
                else if (reading < previousReading)
                {
                    Console.WriteLine($"{reading} = (decreased)");
                }
                else
                {
                    Console.WriteLine($"{reading} = (equal)");
                }
                previousReading = reading;
            }
            Console.WriteLine($"Number of increases = {numberOfIncreases - 1}"); //minus one to account for the first number not being an increase or decrease
            return "I Haven't Solved part 1 yet!";
        }

        public static string SolvePart2()
        {
            return "I Haven't Solved part 2 yet!";
        }
    }
}
