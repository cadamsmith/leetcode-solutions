using System.Text;

namespace Solutions.Lib.P0011;

/// <summary>
/// Cleaner solution, with numeralValues field
/// and recursion
/// </summary>
public class Solution0011B : Solution0011
{
	readonly Dictionary<string, int> _numeralBases = new()
	{
		{ "M", 1000 },
		{ "CM", 900 },
		{ "D", 500 },
		{ "CD", 400 },
		{ "C", 100 },
		{ "XC", 90 },
		{ "L", 50 },
		{ "XL", 40 },
		{ "X", 10 },
		{ "IX", 9 },
		{ "V", 5 },
		{ "IV", 4 },
		{ "I", 1 },
	};

	protected override string IntToRoman(int num)
	{
		StringBuilder sb = new();

		foreach ((string numeral, int baseValue) in _numeralBases)
		{
			while (num >= baseValue)
			{
				num -= baseValue;
				sb.Append(numeral);
			}
		}

		return sb.ToString();
	}
}
