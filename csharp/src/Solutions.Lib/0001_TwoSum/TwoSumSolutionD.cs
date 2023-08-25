namespace Solutions.Lib;

/// <summary>
/// A One-Pass Hash Table solution
/// </summary>
public class TwoSumSolutionD : TwoSumSolution
{
	// Space Complexity: O( N )
	// Time Complexity: O( N )
	protected override int[] TwoSum(int[] nums, int target)
	{
		int count = nums.Length;
		Dictionary<int, int> map = new();

		// map all of the nums to their locations
		for (int i = 0; i < count; i++)
		{
			int num = nums[i];
			int complement = target - num;

			// but also check for complements along the way
			if (map.ContainsKey(complement))
			{
				return new int[] { i, map[complement] };
			}

			map[num] = i;
		}

		throw new ArgumentException("No solution found.");
	}
}
