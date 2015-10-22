/* Project Problem 5



2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

*/

using System;

public class main
{
  public static void Main()
  {
    int lcmOf1To20 = 1;
    for(int num = 2; num <= 20; num++)
      lcmOf1To20 *=( num/gcd(lcmOf1To20 , num));
    Console.WriteLine(lcmOf1To20 );
  }

  public static int gcd(int a, int b)
  {
    while(b > 0)
    {
      a %= b;
      if(a == 0 ) return b;
      b %= a;
    }
    return a;
  }
}