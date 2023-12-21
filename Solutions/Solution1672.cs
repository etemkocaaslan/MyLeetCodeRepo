using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class Solution1672
    {
        public int MaximumWealth(int[][] accounts)
        {
            int RichestCustomerWealth = 0;
            for (int i = 0; i < accounts.Length; i++)
            {
                int Wealth = 0;
                Array.ForEach(accounts[i], value => Wealth += value);

                if (Wealth > RichestCustomerWealth)
                    RichestCustomerWealth = Wealth;
            }
            return RichestCustomerWealth;
        }
    }
}
