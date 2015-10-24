/* Project Euler Problem 7

By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

What is the 10 001st prime number?

*/
using System;

public class Test
{
  public static bool isPrime(long num)
  {
    if(num == 2) return true;
    if(num % 2 == 0) return false;
    long sqrt = (long)Math.Round(Math.Sqrt(num));
    for(long factor = 3; factor <= sqrt; )
    {
      if(num % factor == 0)
        return false;
      factor = factor + 2;
    }
    return true;
  }
  public static void Main()
  {
    int count = 1;
    long num = 1;
    while(count < 10001)
    {  
      num = num + 2;
      if(isPrime(num))
        count++;

    }
    Console.WriteLine(num);
  }
}