namespace Solutions.Lib;

/// <summary>
/// A cleaner linear time solution, with early completion and a
/// specialized data structure
/// </summary>
public class LongestNonRepeatingSubstringSolutionD : BaseLongestNonRepeatingSubstringSolution
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

		// longest window length
		int maxLength = 1;
		SlidingWindow window = new();

		for (int i = 0; i < s.Length; i++)
		{
			// if it is impossible to surpass the maxlength
			if (window.Length + s.Length - i < maxLength)
			{
				// no need to do more work, we're done
				break;
			}

			char character = s[i];
			window.Add(character);

			// ensure max window length is up to date
			if (window.Length > maxLength)
			{
				maxLength = window.Length;
			}
		}

		return maxLength;
	}
}
