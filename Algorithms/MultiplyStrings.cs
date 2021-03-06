// Source : https://leetcode.com/problems/multiply-strings/ 
// Author : codeyu 
// Date : Tuesday, October 25, 2016 11:19:05 PM 

/**********************************************************************************
*
* Given two numbers represented as strings, return multiplication of the numbers as a string.
* 
* Note:
* 
* The numbers can be arbitrarily large and are non-negative.
* Converting the input string to integer is NOT allowed.
* You should NOT use internal library such as BigInteger.
* 
*
**********************************************************************************/

using System;
using System.Collections.Generic;
using Algorithms.Utils;
using System.Linq;
using System.Text;
namespace Algorithms
{
    public class Solution043 
    {
        public static string Multiply(string num1, string num2) 
        {
            if(num1 == null || num2 == null || num1.Length==0 || num2.Length==0)
                return "";
            if(num1[0]=='0')
                return "0";
            if(num2[0]=='0')
                return "0";
            StringBuilder res = new StringBuilder();
            int num = 0;
            for(int i=num1.Length+num2.Length;i>0;i--)
            {
                for(int j=Math.Min(i-1,num1.Length);j>0;j--)
                {
                    if(i-j<=num2.Length)
                    {
                        num += (int)(num1[j-1]-'0')*(int)(num2[i-1-j]-'0');
                    }
                }
                if(i!=1 || num>0)
                    res.Append(num%10);
                num = num/10;
            }
            return new String(res.ToString().Reverse().ToArray());
        }
    }
}

