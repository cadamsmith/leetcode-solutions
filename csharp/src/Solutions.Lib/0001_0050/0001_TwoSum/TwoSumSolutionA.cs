namespace Solutions.Lib;

public class TwoSumSolutionA : TwoSumSolution
{
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
