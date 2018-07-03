using System;
using System.IO;

namespace bsg_rhodes_challenges_2018
{
    public class RunThis
    {
        // Q1
        public static void TestSquares(string[] args)
        {
            TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] ab = Console.ReadLine().Split(' ');

                int a = Convert.ToInt32(ab[0]);

                int b = Convert.ToInt32(ab[1]);

                int result = Q1SherlockandTheSquares.Squares(a, b);

                textWriter.WriteLine(result);
            }

            textWriter.Flush();
            textWriter.Close();
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
        static void TestDiagonal(string[] args)
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
    }
}
