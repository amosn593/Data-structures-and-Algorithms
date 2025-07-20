namespace CommonPatterns;

public static class BinarySearch
{
    public static int Search()
    {

        int[] nums = [2, 1, 5, 1, 3, 2, 9, 10, 12, 15];
        int target = 9;

        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] == target)
                return mid;
            else if (nums[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1;
    }

    public static int RecursiveBinarySearch(int[] arr, int target, int low, int high)
    {
        if (low > high)
            return -1; // Not found`

        int mid = low + (high - low) / 2;

        if (arr[mid] == target)
            return mid;
        else if (arr[mid] < target)
            return RecursiveBinarySearch(arr, target, mid + 1, high);
        else
            return RecursiveBinarySearch(arr, target, low, mid - 1);
    }

    public static int[] FirstAndLastPosition(int[] nums, int target)
    {
        int first = -1, last = -1;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
            {
                first = i;
                last = i;
                while (i < nums.Length && nums[i + 1] == target)
                {
                    last = i + 1;
                    i++;
                }
                return [first, last];
            }
        }

        return [first, last];

    }
}
