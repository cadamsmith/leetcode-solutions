namespace Solutions.Lib;

public abstract class BaseLongestNonRepeatingSubstringSolution : BaseSolution
{
	protected override object Solve(object[] parameters)
	{
		string s = (string) parameters[0];

		return LengthOfLongestSubstring(s);
	}

	protected abstract int LengthOfLongestSubstring(string s);
}
