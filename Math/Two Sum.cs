using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class Solution {
    public  int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> Num = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                Num[nums[i]]=i;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                int a = target - nums[i];
                if (Num.ContainsKey(a)&&Num[a]!=i) return new int[] { Num[a], i };
                
            }
            return null;
}
}
}