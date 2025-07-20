namespace CommonPatterns;

public static class SlidingWindow
{
    public static void FixedSizeSlidingWindow()
    {
        /*
        Problem: Find the maximum sum of any subarray of size k = 3
        Input: nums = [2, 1, 5, 1, 3, 2]
        Expected Output: 9 (subarray [5,1,3])
        */

        int[] nums = [2, 1, 5, 1, 3, 2];
        int k = 3;
        int windowSum = 0;
        int maxSum = 0;

        for (int i = 0; i < nums.Length; i++)
        {

            windowSum += nums[i];

            if (i >= k - 1)
            {
                maxSum = Math.Max(maxSum, windowSum);
                windowSum -= nums[i - (k - 1)];
            }
        }
        Console.WriteLine(maxSum); // Output: 9
    }

    public static void VariableSizeSlidingWindow()
    {
        /*
            Problem: Find the smallest subarray whose sum ≥ 7
           Input: nums = [2, 1, 5, 2, 3, 2]
           Expected Output: 2 (subarray [5,2] or [2,3,2])

        */
        int[] nums = { 2, 1, 5, 2, 3, 2 };
        int target = 7;
        int left = 0, sum = 0;
        int minLen = int.MaxValue;

        for (int right = 0; right < nums.Length; right++)
        {
            sum += nums[right];

            while (sum >= target)
            {
                minLen = Math.Min(minLen, right - left + 1);
                sum -= nums[left];
                left++;
            }
        }

        Console.WriteLine(minLen == int.MaxValue ? 0 : minLen); // Output: 2
    }

    public static void LongestSubstringWithoutRepeatingCharacters()
    {
        /*
            Problem: Find the length of the longest substring without repeating characters
            Input: s = "abcabcbb"
            Expected Output: 3 (substring "abc")
        */
        string s = "abcabcbb";
        int left = 0, maxLength = 0;
        HashSet<char> charSet = [];

        for (int right = 0; right < s.Length; right++)
        {
            while (charSet.Contains(s[right]))
            {
                charSet.Remove(s[left]);
                left++;
            }
            charSet.Add(s[right]);
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        Console.WriteLine(maxLength); // Output: 3
    }
}