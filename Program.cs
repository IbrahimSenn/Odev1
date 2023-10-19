using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_project
{
    internal class Program
    {
         class Result
        { 
            public static void plusMinus(List<int> arr)
            {
            int neg = 0;
            int f = 0;
            int pos  = 0;
            int d  = 0;
            int zero = 0;
            int g = 0;
            int v = arr.Count;

                foreach (var item in arr)
                {
                if (item <0)
                {
                    neg++;  
                }
                else if (item > 0)
                {
                    pos++;
                }
                else
                {
                    zero++;
                }
                }

                d = pos/v;
            Console.WriteLine(d.ToString("0.######") );

                f = neg / v;
            Console.WriteLine(f.ToString("0.######"));

                g = zero / v;
            Console.WriteLine(g.ToString("0.######"));

        }

        }

        class Solution
        {
            public static void Main(string[] args)
            {
                //int n = Convert.ToInt32(Console.ReadLine().Trim());

                List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

                Result.plusMinus(arr);
            }

        }
    }
}
