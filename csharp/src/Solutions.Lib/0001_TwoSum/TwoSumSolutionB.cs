namespace Solutions.Lib;

/// <summary>
/// A messy Two-pass Hash Table solution
/// </summary>
public class TwoSumSolutionB : TwoSumSolution
{
	// Time Complexity: O( N )
	// Space Complexity: O( N )
	protected override int[] TwoSum(int[] nums, int target)
    {
		int count = nums.Length;
		Dictionary<int, int> complementMap = new();

		// find all the complements, and point them to their
		// corresponding numbers
		for (int i = 0; i < count; i++)
		{
			int num = nums[i];
			int complement = target - num;

			complementMap[complement] = i;
		}

		// this time, we'll search for a num that is one of the
		// complements from earlier
		for (int i = 0; i < count; i++)
		{
			int num = nums[i];

			if (complementMap.ContainsKey(num))
			{
				int complementIndex = complementMap[num];

				if (complementIndex == i)
				{
					continue;
				}

				return new int[] { complementIndex, i };
			}
		}

		return new int[] { count - 2, count - 1 };
	}
}
