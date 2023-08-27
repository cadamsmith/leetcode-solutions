namespace Solutions.Lib;

public abstract class BaseIntegerToRomanSolution : BaseSolution
{
	protected override object Solve(object[] parameters)
	{
		int num = (int) parameters[0];

		return IntToRoman(num);
	}

	protected abstract string IntToRoman(int num);
}
