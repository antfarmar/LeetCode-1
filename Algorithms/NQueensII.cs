// Source : https://leetcode.com/problems/n-queens-ii/ 
// Author : codeyu 
// Date : Friday, November 11, 2016 11:55:18 PM 

/**********************************************************************************
*
* Follow up for N-Queens problem.
* 
* Now, instead outputting board configurations, return the total number of distinct solutions.
* 
* 
*
**********************************************************************************/

using System;
using System.Collections.Generic;
using Algorithms.Utils;
using System.Text;
using System.Linq;
namespace Algorithms
{
    public class Solution052 
    {
        public static int TotalNQueens(int n) 
        {
            IList<int> res = new List<int>();
            res.Add(0);
            helper(n,0,new int[n], res);  
            return res[0];   
        }
        private static void helper(int n, int row, int[] columnForRow, IList<int> res)
        {
            if(row == n)
            {
                res[0] = res[0] + 1;
                return;
            }
            for(int i=0;i<n;i++)
            {
                columnForRow[row] = i;
                if(check(row,columnForRow))
                {
                    helper(n,row+1,columnForRow,res);
                }
            }
        }
        private static bool check(int row, int[] columnForRow)
        {
            for(int i=0;i<row;i++)
            {
                if(columnForRow[row]==columnForRow[i] || Math.Abs(columnForRow[row]-columnForRow[i])==row-i)
                    return false;
            }
            return true;
        }
    }
}

