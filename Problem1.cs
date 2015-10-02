/*If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

Find the sum of all the multiples of 3 or 5 below 1000.*/

using System;

public class Test
{
    public static void Main()
    {
        int N = 1000;
        int sum = 0;
        for(int index = 1; index < 1000; index++)
        {
            if(index % 3 == 0 || index % 5 == 0)
                sum += index;
        }
        Console.WriteLine(sum);
    }
}