using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommonPatterns;

public static class PrefixSum
{
    public static int[] ComputePrefixSum(int[] nums)
    {
        int[] prefixSum = new int[nums.Length];
        prefixSum[0] = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            prefixSum[i] = prefixSum[i - 1] + nums[i];
        }

        return prefixSum;
    }

    public static int GetRangeSum(int[] prefixSum, int left, int right)
    {
        if (left == 0)
            return prefixSum[right];
        else
            return prefixSum[right] - prefixSum[left - 1];
    }

    public static int PivotIndex(int[] nums)
    {
        // Find the pivot index where the sum of elements to the left equals the sum of elements to the right



        // int[] prefixSum = ComputePrefixSum(nums);

        // int totalSum = prefixSum[nums.Length - 1];

        // for (int i = 0; i < nums.Length; i++)
        // {
        //     if (prefixSum[i] == totalSum - prefixSum[i - 1])
        //         return i;
        // }

        // return -1;

        /*
        // Alternative approach without prefix sum
        // Find the pivot index where the sum of elements to the left equals the sum of elements to the right
        // if (nums.Length == 0) return -1;
            int total = nums.Sum();
            int leftSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (leftSum == total - leftSum - nums[i])
                    return i;
                leftSum += nums[i];
            }
            return -1;
        */

        int total = nums.Sum();
        int leftSum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (leftSum == total - leftSum - nums[i])
                return i;
            leftSum += nums[i];
        }
        return -1;
    }

    public static int SubarraySumEqualsK(int[] nums, int k)
    {
        var map = new Dictionary<int, int> { { 0, 1 } };
        int sum = 0, count = 0;

        foreach (var num in nums)
        {
            sum += num;
            if (map.ContainsKey(sum - k))
                count += map[sum - k];

            if (!map.ContainsKey(sum))
                map[sum] = 0;
            map[sum]++;
        }

        return count;
    }

    public static int MaximumSizeSubarraySumEqualsk(int[] nums, int k)
    {
        var map = new Dictionary<int, int>();
        int sum = 0, maxLen = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];

            if (sum == k)
                maxLen = i + 1;

            if (map.ContainsKey(sum - k))
                maxLen = Math.Max(maxLen, i - map[sum - k]);

            if (!map.ContainsKey(sum))
                map[sum] = i;
        }

        return maxLen;
    }
}