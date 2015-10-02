/*

Project Euler Problem 1 updated solution

*/

using System;

public class Test
{
    public static void Main()
    {
        int N = 999;
        int sum = 0;
        int SumOfMultiplesOf3 = 3*((N/3) * ((N/3) + 1))/2;
        int SumOfMultiplesOf5 = 5*((N/5)*((N/5) + 1))/2;
        int SumOfMultiplesOf15 = 15*(N/15*((N/15) + 1))/2;
        sum = SumOfMultiplesOf3 + SumOfMultiplesOf5 - SumOfMultiplesOf15;
        Console.WriteLine(sum);
    }
}