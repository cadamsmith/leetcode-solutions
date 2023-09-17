namespace Solutions.Lib.P0003;

/// <summary>
/// A cleaner linear time solution, with early completion
/// </summary>
public class Solution0003C : Solution0003
{
	// Time Complexity: O(N)
	// Space Complexity: O(1)
	protected override int LengthOfLongestSubstring(string s)
	{
		// validate parameter
		if (s is null)
		{
			throw new ArgumentNullException(nameof(s));
		}
		// handle the easiest case first
		if (s.Length == 0)
		{
			return 0;
		}

		// all of the chars encountered, along with their last occurrence
		Dictionary<char, int> lastCharacterIndices = new();

		// longest window length
		int maxLength = 1;
		// start of current window
		int currStart = 0;

		for (int i = 0; i < s.Length; i++)
		{
			// length of current window
			int windowLength = i - currStart;

			// if it is impossible to surpass the maxlength
			if (windowLength + s.Length - i < maxLength)
			{
				// no need to do more work, we're done
				break;
			}

			char c = s[i];

			// the window start only needs to change if we encounter a
			// character already in the window
			if (lastCharacterIndices.ContainsKey(c))
			{
				int lastIndex = lastCharacterIndices[c];

				if (currStart <= lastIndex)
				{
					currStart = lastIndex + 1;
				}
			}

			// remember where we saw this char last
			lastCharacterIndices[s[i]] = i;

			// recalculate the window length
			windowLength = i - currStart + 1;

			// ensure max window length is up to date
			if (windowLength > maxLength)
			{
				maxLength = windowLength;
			}
		}

		return maxLength;
	}
}
