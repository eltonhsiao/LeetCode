using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Api;

namespace LeetCode
{
    public class ThreeSumSolution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            var output = new List<IList<int>>();
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;
                int second = i + 1;
                int third = nums.Length - 1;
                while (second < third)
                {
                    if (nums[i] + nums[second] + nums[third] > 0)
                        third--;
                    else if (nums[i] + nums[second] + nums[third] < 0)
                    {
                        second++;
                    }
                    else
                    {
                        var triple = new List<int>();
                        triple.Add(nums[i]);
                        triple.Add(nums[second]);
                        triple.Add(nums[third]);
                        output.Add(triple);
                        while (second < third && nums[second] == nums[second + 1]) second++;
                        while (second < third && nums[third] == nums[third - 1]) third--;
                        second++;
                        third--;
                    }
                }
            }

            return output;
        }
    }
}
