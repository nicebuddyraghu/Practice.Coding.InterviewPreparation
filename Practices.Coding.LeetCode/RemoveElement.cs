using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class RemoveElement
    {
        internal class Solution
        {
            internal int RemoveElement(int[] nums, int val)
            {

                if (nums == null)
                    return 0;

                if (nums.Length > 100)
                    return 0;

                if (val > 100 || val < 0)
                    return 0;

                bool isValid = true;
                var newnumlist = new System.Collections.Generic.List<int>();

                foreach (var num in nums)
                {
                    if (num != val)
                    {
                        if (num > 50 || num < 0)
                        {
                            isValid = false;
                            break;
                        }

                        newnumlist.Add(num);
                    }
                }

                if (!isValid)
                    return 0;

                var index = 0;

                foreach (var num in newnumlist)
                {
                    nums[index] = num;
                    index++;
                }

                return newnumlist.Count;
            }
        }
    }
}
