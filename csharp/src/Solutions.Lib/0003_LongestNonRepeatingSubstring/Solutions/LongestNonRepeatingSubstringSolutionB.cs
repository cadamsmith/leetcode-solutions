namespace Solutions.Lib;

/// <summary>
/// A messy linear time solution, with early completion
/// </summary>
public class LongestNonRepeatingSubstringSolutionB : BaseLongestNonRepeatingSubstringSolution
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
		Dictionary<char, int> lastOccurrences = new();

		// length of the longest nonrepeating substring
		int maxLength = 1;
		// length of the current nonrepeating substring
		int currLength = 0;

		for (int i = 0; i < s.Length; i++)
		{
			// if it is impossible to surpass the maxlength
			if (currLength + s.Length - i < maxLength)
			{
				// no need to do work, we're done
				break;
			}

			char c = s[i];

			if (!lastOccurrences.ContainsKey(c))
			{
				currLength++;
			}
			else
			{
				int lastOccurrenceIndex = lastOccurrences[c];

				int windowStart = i - currLength;

				// if character occurred before in window, start over
				if (windowStart <= lastOccurrenceIndex)
				{
					currLength -= lastOccurrenceIndex - windowStart;
				}
				// otherwise it gets added to the window
				else
				{
					currLength += 1;
				}
			}

			lastOccurrences[s[i]] = i;

			if (currLength > maxLength)
			{
				maxLength = currLength;
			}
		}

		return maxLength;
	}
}
