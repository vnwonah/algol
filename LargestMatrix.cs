using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello World!");
    }

    public static int largestMatrix(List<List<int>> arr)
    {
        if(!(arr is object) || arr.Count == 0)
            return 0;

        int max_width = 1;
        int current_size = arr.Count;

        while(current_size > 0)
        {
            int possible_square_count = current_size * current_size;

            for(int i = 0; i < possible_square_count; i++)
            {
                

            }
        }



        return max_width;
    }
}