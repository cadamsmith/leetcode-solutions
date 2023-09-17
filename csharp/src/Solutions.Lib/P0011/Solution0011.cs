namespace Solutions.Lib.P0011;

public abstract class Solution0011 : BaseSolution
{
	protected override object Solve(object[] parameters)
	{
		int num = (int) parameters[0];

		return IntToRoman(num);
	}

	protected abstract string IntToRoman(int num);
}
