namespace Solutions.Lib;

/// <summary>
/// A cleaner Two-pass Hash Table solution
/// </summary>
public class TwoSumSolutionC : TwoSumSolution
{
	// Time Complexity: O( N )
	// Space Complexity: O( N )
	protected override int[] TwoSum(int[] nums, int target)
	{
		int count = nums.Length;
		Dictionary<int, int> map = new();

		// map all of the nums to their locations
		for (int i = 0; i < count; i++)
		{
			int num = nums[i];
			map[num] = i;
		}

		// search for a num complement in the array
		for (int i = 0; i < count; i++)
		{
			int num = nums[i];
			int complement = target - num;

			// making use of our quick lookup map
			if (map.ContainsKey(complement))
			{
				int complementIndex = map[complement];

				if (i != complementIndex)
				{
					return new int[] { complementIndex, i };
				}
			}
		}

		return new int[] { count - 2, count - 1 };
	}
}
