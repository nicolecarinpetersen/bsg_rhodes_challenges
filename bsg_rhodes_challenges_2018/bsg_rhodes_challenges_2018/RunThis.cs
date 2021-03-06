﻿using System;
using System.IO;

namespace bsg_rhodes_challenges_2018
{
    public class RunThis
    {

        public static void Main(string[] args)
        {
            TestSquares();
            TestDigitalRoot();
            TestDiagonal();
            TestTimeTravel();
            TestBestTo100();
        }

        // Q1
        /*
            Input:
            Test case 1 = 3 9
            Test case 2 = 17 24
            Test case 3 = 50 56
            Test case 4 = 113 120
        */
        public static void TestSquares()
        {
            Console.WriteLine("Enter the start and end values");

            string[] ab = Console.ReadLine().Split(' ');

            int a = Convert.ToInt32(ab[0]);

            int b = Convert.ToInt32(ab[1]);

            int result = Q1SherlockandTheSquares.Squares(a, b);

            Console.WriteLine(result);

            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();

        }

        // Q2
        /*
            Input:
            Test case 1 = 254
            Test case 2 = 0
            Test case 3 = 1426872
            Test case 4 = 78521
        */
        public static void TestDigitalRoot()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Q2DigitalRoots.DigitalRoot(number));

            Console.WriteLine();
            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
        }

        // Q3
        /*
            Input
            4
            566 555 917 -201
            200 605 162 341
            269 876 920 136
            -255 888 315 535
        */
        static void TestDiagonal()
        {
            Console.WriteLine("Start by entering the array size.");

            int n = Convert.ToInt32(Console.ReadLine());

            int[][] arr = new int[n][];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = Q3DiagonalDifference.DiagonalDifference(arr);

            Console.WriteLine(result);
            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();

        }

        // Q4
        static void TestTimeTravel()
        {
            TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[][] arr = new int[n][];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = Q3DiagonalDifference.DiagonalDifference(arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }

        // Q5
        public static void TestBestTo100()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Q2DigitalRoots.DigitalRoot(number));

            Console.WriteLine();
            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
        }
    }
}
