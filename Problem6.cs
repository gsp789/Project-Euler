/*  Project Euler Problem 6


The sum of the squares of the first ten natural numbers is,
1 pow 2 + 2 pow 2 + ... + 10 pow 2 = 385

The square of the sum of the first ten natural numbers is,
(1 + 2 + ... + 10) pow 2 = 55 pow 2 = 3025

Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.

Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

*/

using System;

public class Test
{
	public static void Main()
	{
        int n = 100;
		long sumOfSquares = (n * (n+1) * (2*n + 1))/6;
        long sumOfN = (n * (n+1))/2;
        long squareOfsumOfN = sumOfN * sumOfN;
        long result = squareOfsumOfN - sumOfSquares ;
        Console.WriteLine(result );
  }
}