namespace CommonPatterns;

public static class TwoPointers
{
    public static void FindPairWithGivenSum(int[] arr, int targetSum)
    {
        var left = 0;
        var right = arr.Length - 1;
        while (left < right)
        {
            var currentSum = arr[left] + arr[right];
            if (currentSum == targetSum)
            {
                Console.WriteLine($"Pair found: {arr[left]}, {arr[right]}");
                return;
            }
            if (currentSum < targetSum)
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        Console.WriteLine("No pair found");
    }

    public static int RemoveDuplicates(int[] arr)
    {
        if (arr.Length == 0) return 0;

        int uniqueIndex = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] != arr[uniqueIndex])
            {
                uniqueIndex++;
                arr[uniqueIndex] = arr[i];
            }
        }
        return uniqueIndex + 1;
    }

    public static int LongestSubstringWithoutRepeatingCharacters(string s)
    {
        var charIndexMap = new Dictionary<char, int>();
        int maxLength = 0;
        int start = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (charIndexMap.ContainsKey(s[i]))
            {
                start = Math.Max(start, charIndexMap[s[i]] + 1);
            }
            charIndexMap[s[i]] = i;
            maxLength = Math.Max(maxLength, i - start + 1);
        }
        return maxLength;
    }

    public static string ReverseString(string s)
    {
        char[] charArray = s.ToCharArray();
        int left = 0;
        int right = charArray.Length - 1;
        while (left < right)
        {
            (charArray[right], charArray[left]) = (charArray[left], charArray[right]);
            left++;
            right--;
        }
        return new string(charArray);
    }


    public static bool IsPalindrome(string s)
    {
        int left = 0;
        int right = s.Length - 1;
        while (left < right)
        {
            if (s[left] != s[right]) return false;
            left++;
            right--;
        }
        return true;
    }

    public static void MainMethod()
    {
        // Two Pointers Example: Find Pair with Given Sum
        // Console.WriteLine("Two Pointers Example: Find Pair with Given Sum");
        // int[] arr = [1, 2, 3, 4, 6];
        // int targetSum = 10;
        // FindPairWithGivenSum(arr, targetSum);
        // Console.WriteLine();

        // Two Pointers Example: Remove Duplicates from Sorted Array
        // Console.WriteLine("Two Pointers Example: Remove Duplicates from Sorted Array");
        // int[] sortedArr = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];
        // Console.WriteLine($"Array Before removing duplicates: [{string.Join(", ", sortedArr)}]");
        // int newLength = RemoveDuplicates(sortedArr);
        // Console.WriteLine($"New Array after removing duplicates: [{string.Join(", ", sortedArr.Take(newLength))}]");
        // Console.WriteLine();

        // Two Pointers Example: Longest Substring Without Repeating Characters
        // Console.WriteLine("Two Pointers Example: Longest Substring Without Repeating Characters");
        // string inputString = "abcabcbb";
        // int longestSubstringLength = LongestSubstringWithoutRepeatingCharacters(inputString);
        // Console.WriteLine($"Longest substring without repeating characters in '{inputString}': {longestSubstringLength}");

        // Two Pointers Example: Reverse String
        Console.WriteLine("Two Pointers Example: Reverse String");
        string strToReverse = "hello";
        string reversedString = ReverseString(strToReverse);
        Console.WriteLine($"Reversed string of '{strToReverse}': {reversedString}");

        // Two Pointers Example: Check if String is Palindrome
        Console.WriteLine("Two Pointers Example: Check if String is Palindrome");
        string palindromeString = "racecar";
        bool isPalindrome = IsPalindrome(palindromeString);
        Console.WriteLine($"Is '{palindromeString}' a palindrome? {isPalindrome}");
    }
}

