using System;

class Program
{
    public static void Main()
    {
        PrintArray(Sort(new char[] { 'I', 'N', 'S', 'E', 'R', 'T', 'I', 'O', 'N', 'S', 'O', 'R', 'T' }, 13));
    }

    //Sort Function
    static char[] Sort(char[] arr, int n)
    {
        int i = 1, j;

        for(; i < n; i++)
        {
            j = i;

            while((j > 0) && arr[j] < arr[j - 1])
            {
                char temp = arr[j - 1];
                arr[j - 1] = arr[j];
                arr[j] = temp;
                j--;
            }

        }

        return arr;
    }

    static void PrintArray(char[] arr)
    {
        foreach(var a in arr)
        {
            Console.Write(a);
        }

    }
}
