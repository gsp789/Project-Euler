/* Project Euler Problem 10



The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

Find the sum of all the primes below two million.

*/

using System;

public class SumOfPrimes
{
  public static bool isPrime(int num)
  {
    int sqrt = (int)Math.Floor(Math.Sqrt(num));
    for(int factor = 3; factor <= sqrt; )
    {
      if(num % factor == 0)
        return false;
      factor = factor + 2;
    }
    return true;
  }
  public static void Main()
  {
    long sum = 2;
    int num = 3;
    while(num < 2000000)
    {
      if(isPrime(num))
        sum += num;

      num = num + 2;
    }
    Console.WriteLine(sum);
  }
  
}