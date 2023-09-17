namespace Solutions.Lib.P0006;

public abstract class Solution0006 : BaseSolution
{
    protected override object Solve(object[] parameters)
    {
        string s = (string) parameters[0];
        int numRows = (int) parameters[1];

        return Convert(s, numRows);
    }

    protected abstract string Convert(string s, int numRows);
}
