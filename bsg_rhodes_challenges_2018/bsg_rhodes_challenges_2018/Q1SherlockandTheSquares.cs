using System;

// Q1
/*
    Input:
    Test case 1 = 3 9
    Test case 2 = 17 24
    Test case 3 = 50 56
    Test case 4 = 113 120
*/

public static class Q1SherlockandTheSquares
{
    public static void Main(string[] args)
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

    // Complete the squares function below.
    public static int Squares(int a, int b)
    {
        return 0;
    }
}
