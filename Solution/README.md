# Leetcode-CSharp solutions by Igneaalis

[4. Median of Two Sorted Arrays](https://leetcode.com/problems/median-of-two-sorted-arrays/)

```C#
public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int sumLenght = nums1.Length + nums2.Length;
        int midIndex = sumLenght / 2;
        int firstArrayIndex = 0, secondArrayIndex = 0, result = 0, prev = 0;

        for (int k = 0; k <= midIndex; k++)
        {
            prev = result;
            if (secondArrayIndex == nums2.Length)
            {
                
                result = nums1[firstArrayIndex];
                firstArrayIndex = firstArrayIndex + 1;
            }
            else if (firstArrayIndex == nums1.Length)
            {
                result = nums2[secondArrayIndex];
                secondArrayIndex = secondArrayIndex + 1;
            }
            else if (nums1[firstArrayIndex] > nums2[secondArrayIndex])
            {
                result = nums2[secondArrayIndex];
                secondArrayIndex = secondArrayIndex + 1;
            }
            else
            {
                
                result = nums1[firstArrayIndex];
                firstArrayIndex = firstArrayIndex + 1;
            }
        }
        nums1 = null;
        nums2 = null;
        GC.Collect();
        return sumLenght % 2 == 0 ? (result + prev) / 2.0 : result;
    }
}
```
