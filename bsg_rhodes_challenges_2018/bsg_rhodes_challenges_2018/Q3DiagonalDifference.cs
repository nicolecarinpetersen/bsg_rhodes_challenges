using System;

// Q3
/*
    Input
    4
    566 555 917 -201
    200 605 162 341
    269 876 920 136
    -255 888 315 535
*/

public static class Q3DiagonalDifference
{
    public static void Main(string[] args)
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


    // Complete the diagonalDifference function below.
    public static int DiagonalDifference(int[][] matrix)
    {
         return 0;
    }
}