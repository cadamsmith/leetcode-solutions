using System.Text;

namespace Solutions.Lib.P0011;

/// <summary>
/// Messy iterative first solution, with string builder
/// </summary>
public class IntegerToRomanSolutionA : BaseIntegerToRomanSolution
{
	protected override string IntToRoman(int num)
	{
		StringBuilder sb = new();

		while (num / 1000 > 0)
		{
			sb.Append('M');
			num -= 1000;
		}

		if (num / 100 == 9)
		{
			sb.Append("CM");
			num -= 900;
		}
		if (num / 100 >= 5)
		{
			sb.Append('D');
			num -= 500;
		}
		if (num / 100 == 4)
		{
			sb.Append("CD");
			num -= 400;
		}
		while (num / 100 > 0)
		{
			sb.Append('C');
			num -= 100;
		}

		if (num / 10 == 9)
		{
			sb.Append("XC");
			num -= 90;
		}
		if (num / 10 >= 5)
		{
			sb.Append('L');
			num -= 50;
		}
		if (num / 10 == 4)
		{
			sb.Append("XL");
			num -= 40;
		}
		while (num / 10 > 0)
		{
			sb.Append('X');
			num -= 10;
		}

		if (num == 9)
		{
			sb.Append("IX");
			num -= 9;
		}
		if (num >= 5)
		{
			sb.Append('V');
			num -= 5;
		}
		if (num == 4)
		{
			sb.Append("IV");
			num -= 4;
		}
		while (num > 0)
		{
			sb.Append('I');
			num -= 1;
		}

		return sb.ToString();
	}
}
