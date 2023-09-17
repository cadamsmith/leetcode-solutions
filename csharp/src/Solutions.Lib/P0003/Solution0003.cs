namespace Solutions.Lib.P0003;

public abstract class Solution0003 : BaseSolution
{
	protected override object Solve(object[] parameters)
	{
		string s = (string) parameters[0];

		return LengthOfLongestSubstring(s);
	}

	protected abstract int LengthOfLongestSubstring(string s);
}
