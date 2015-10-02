/*

Project Euler Problem 4:

A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

Find the largest palindrome made from the product of two 3-digit numbers.

*/

using System;

public class Test
{
    public static bool IsPalindrome(int mul)
    {
        string str = mul.ToString();
        bool IsPalindrome = false;
        for(int index1 = 0, index2 = str.Length - 1; index1 < index2; index1++, index2--)
            if(str[index1]!= str[index2])
                return false;
        return true;
    }
    
    public static void Main()
    {
        int Max = 0;
        for(int index1 = 101; index1 <= 999; index1++)
        {
            for(int index2 = index1; index2<= 999; index2++)
            {
                int mul = index1*index2;
                if(mul > Max)
                {
                    if(IsPalindrome(mul))
                     Max = mul;
                }
                 
            }
   
        }
        Console.WriteLine(Max);
    }
}