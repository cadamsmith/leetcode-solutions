namespace Solutions.Lib.P0001;

/// <summary>
/// Brute Force Solution
/// </summary>
public class Solution0001A : Solution0001
{
	// Time Complexity: O( N^2 )
	// Space Complexity: O( N )
    protected override int[] TwoSum(int[] nums, int target)
    {
        int count = nums.Length;

        for (int i = 0; i < count - 2; i++)
        {
            for (int j = i + 1; j < count; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }

        return new int[] { count - 2, count - 1 };
    }
}
