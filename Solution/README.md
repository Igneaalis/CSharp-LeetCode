# Leetcode-CSharp solutions by Igneaalis

[1. Two Sum](https://leetcode.com/problems/two-sum/)

```C#
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var dict = new Dictionary<int, int?>();
        int? no1 = null;
        int? no2 = null;
        for (int index = 0; index < nums.Length; index++)
        {
            if (dict.TryGetValue(nums[index], out no1))
            {
                no1 = dict[nums[index]];
                no2 = index;
                break;
            }
            dict[target - nums[index]] = index;
        }
        return new int[] { no1 ?? throw new ArgumentException(), no2 ?? throw new ArgumentException() };
    }
}
```