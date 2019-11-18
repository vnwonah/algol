using System;
using System.Collections.Generic;

class Program {

    public static void Main() 
    {

        int[,] a = new int[3,4]{{1,2,3,4}, {5,6,7,8}, {9,10,11,12}};
        a[0,0] = 1;
        a[0,1] = 2;
        a[0,2] = 3;
        a[1,0] = 4;

        /*

        1,2,3   
        4,5,6
        7,8,9

        cases pointer is at origin, //just print
        pointer is at top, goto next column
        pointer is at bottom,
        poiter is at mid
        
        
        */

        Print2DArray(a);
    }


    private static int[] Print2DArray(int[,] arr)
    {
        List<int> results = new List<int>();
        int rowLenght = arr.GetLength(0);
        int columnLength = arr.GetLength(1);
        int flag = 1; //0 = go down; 1 = go up;
        
        
        int i = 0;
        int j = 0;

        do 
        {

        /*

        1,2,3   
        4,5,6
        7,8,9
        
        
        */
            //Console.WriteLine("i: " + i + " j: " + j + " flag: " + flag);
            results.Add(arr[i,j]);

            if (flag == 0)
            {
                if(j == 0)
                {
                    //left side of box
                    if(i < rowLenght - 1)
                    {
                        //there are rows below so go down
                        i++;
                        flag = 0;
                    }
                    else 
                    {
                        //no rows below go forward
                        j++;
                        i--;
                        flag = 1;
                    }
                }
                else if(i == rowLenght - 1) 
                {
                    //go up
                    flag = 1;
                    j++;

                }
                else
                {
                    //keep going down
                    i++;
                    j--;
                }
                
            }
            else if (flag == 1)
            {
                if(j == columnLength - 1)
                {
                    //go down
                    flag = 0;
                    i++;
                }
                else if (i == 0)
                {
                    //go down
                    flag = 0;
                    j++;
                }
              
                else
                {
                    //keep going up
                    i--;
                    j++;

                }


               
            }
        } 
        while (i < rowLenght && j < columnLength);

        return results.ToArray();


    }
}