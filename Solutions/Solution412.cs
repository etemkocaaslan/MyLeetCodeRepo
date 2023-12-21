using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class Solution412
    {
        //Given an integer n, return a string array answer(1-indexed) where:

        //answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
        //answer[i] == "Fizz" if i is divisible by 3.
        //answer[i] == "Buzz" if i is divisible by 5.
        //answer[i] == i(as a string) if none of the above conditions are true.

        public IList<string> FizzBuzz(int n)
        {
            var list = new List<string>(n);
            for (int i = 1; i <= n; i++)
            {
                string item = (i % 3 == 0, i % 5 == 0) switch
                {
                    (true, true) => "FizzBuzz",
                    (true, false) => "Fizz",
                    (false, true) => "Buzz",
                    (false, false) => i.ToString(),
                };

                list.Add(item);
            }

            return list;
        }

    }
}
