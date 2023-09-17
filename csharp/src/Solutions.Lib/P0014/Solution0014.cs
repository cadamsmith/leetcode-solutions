namespace Solutions.Lib.P0014;

public abstract class Solution0014 : BaseSolution
{
    protected override object Solve(object[] parameters)
    {
        string[] strs = (string[]) parameters[0];

        return LongestCommonPrefix(strs);
    }

    protected abstract string LongestCommonPrefix(string[] strs);
}
