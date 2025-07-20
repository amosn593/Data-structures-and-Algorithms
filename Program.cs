// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using CommonPatterns;

//Sliding Window 
//Fixed Size Sliding Window
// Console.WriteLine("Fixed Size Sliding Window Example:");
// CommonPatterns.SlidingWindow.FixedSizeSlidingWindow();

//Variable Size Sliding Window
// Console.WriteLine("Variable Size Sliding Window Example:");
// CommonPatterns.SlidingWindow.VariableSizeSlidingWindow();

//Binary Search
// Console.WriteLine("Binary Search Example:");
// int result = CommonPatterns.BinarySearch.Search();
// Console.WriteLine($"Index of target: {result}");

//Recursive Binary Search
// Console.WriteLine("Recursive Binary Search Example:");
// int[] arr = [1, 3, 5, 7, 9, 11];
// int target = 7;
// int index = CommonPatterns.BinarySearch.RecursiveBinarySearch(arr, target, 0, arr.Length - 1);
// Console.WriteLine($"Index of target in recursive search: {index}");


// First and Last Position of Element in Sorted Array
// Console.WriteLine("First and Last Position of Element in Sorted Array Example:");
// int[] nums = [5, 7, 7, 8, 8, 8, 9, 10];
// int target = 8;
// int[] positions = CommonPatterns.BinarySearch.FirstAndLastPosition(nums, target);
// Console.WriteLine($"First and last position of {target}: [{positions[0]}, {positions[1]}]");

// Prefix Sum Pivot Index
// Console.WriteLine("Prefix Sum Pivot Index Example:");
// int[] nums = [1, 7, 3, 6, 5, 6];
// int pivotIndex = PrefixSum.PivotIndex(nums);
// Console.WriteLine($"Pivot index: {pivotIndex}");

// Subarray Sum Equals K
// Console.WriteLine("Subarray Sum Equals K Example:");
// int[] nums = [1, 2, 3];
// int k = 3;
// int count = PrefixSum.SubarraySumEqualsK(nums, k);
// Console.WriteLine($"Number of subarrays with sum {k}: {count}");

// Maximum Size Subarray Sum Equals k
Console.WriteLine("Maximum Size Subarray Sum Equals k Example:");
int[] nums = [1, -1, 5, -2, 3];
int k = 3;
int maxLen = PrefixSum.MaximumSizeSubarraySumEqualsk(nums, k);
Console.WriteLine($"Maximum size of subarray with sum {k}: {maxLen}");
