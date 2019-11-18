using System;
using System.Text;
using System.Linq;
using System.Numerics;

class Program
{

    public static void Main()
    {

        PrintArray(PlusOne(new int[] { 7,2,8,5,0,9,1,2,9,5,3,6,6,7,3,2,8,4,3,7,9,5,7,7,4,7,4,9,4,7,0,1,1,1,7,4,0,0,6}));

    }

    public static int[] PlusOne(int[] digits)
    {

        int n = digits.Length;

        if (n > 0)
        {

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                sb.Append(digits[i]);
            }

            string digitsString = sb.ToString();
            BigInteger digitsLongPlusOne = BigInteger.Parse(digitsString) + 1;
            string digitsLongPlusOneString = digitsLongPlusOne.ToString();

            n = digitsLongPlusOneString.Length;
        

            int[] arr = new int[n];
            
            for(int i = 0; i < n; i++)
            {
                arr[i] = Int32.Parse(digitsLongPlusOneString[i].ToString());
            }


            return arr;

           

        }

        return digits;

    }

    static void PrintArray(int[] arr)
    {
        foreach (var a in arr)
        {
            Console.Write(a);
        }

    }
}
