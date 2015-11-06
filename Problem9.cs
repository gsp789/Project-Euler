/* Project Euler Problem 9

A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
a pow 2 + b pow 2 = c pow 2

For example, 3 pow 2 + 4 pow 2 = 9 + 16 = 25 = 52.

There exists exactly one Pythagorean triplet for which a + b + c = 1000.
Find the product abc.
*/

using System;

public class Triplet
{
  public static void Main()
  {
    int totalSum = 1000;
    bool found = false;
    int a, b = 1, c = 1;
    for(a = 1; a < totalSum/2; a++)
    {
      for(b = a; b < totalSum/2; b++)
      {
        c = totalSum - a - b;
        if((a * a + b * b) == (c * c))
        {
          found = true;
          break;
        }
      }
      if(found)
        break;
    }

    Console.WriteLine(a + " " + b + " " + c);
    Console.WriteLine(a * b * c);
  }
}