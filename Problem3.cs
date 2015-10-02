/* 
Problem 3 ProjectEuler.net

The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600851475143 ?

*/

using System;

public class LargestPrimeFactor
{
  public static bool IsPrime(long N)
  {
  	bool Prime = true;
  	long sqrtOfN = (long)Math.Ceiling((double)Math.Sqrt(N));
  	for(long index = 2; index <= sqrtOfN; index++)
  	{
  		if(N % index == 0)
  		{
  			Prime = false;
  			break;
  		}
  	}
  	return Prime;
  }
  public static long FindLargestPrimeFactor(long N)
  {
  	long largestPrimeFactor = 0;
  	for(long index = 2; index <= N/2; index++)
    {
    	long divisor = (N / index);
    	if(N % divisor == 0)
    	{
	    	if(IsPrime(divisor))
			{
				largestPrimeFactor = divisor;
				break;
			}
			N = divisor;
			index--;
    	}
    	
    }
    return largestPrimeFactor;
  }
  
  public static void Main()
  {
    long N = 600851475143;
    long largestPrimeFactor = FindLargestPrimeFactor(N);
    Console.WriteLine(largestPrimeFactor);
  }
}