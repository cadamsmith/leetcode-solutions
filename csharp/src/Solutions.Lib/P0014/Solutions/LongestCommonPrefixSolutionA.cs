namespace Solutions.Lib.P0014;

public class LongestCommonPrefixSolutionA : BaseLongestCommonPrefixSolution
{
    protected override string LongestCommonPrefix(string[] strs)
    {
        // if there's only one word, then it is a common prefix
        if (strs.Length == 1)
        {
            return strs[0];
        }

        // set up our work area
        Array.Sort(strs);
        string prefix = string.Empty;

        // only need to look at two words
        string l = strs[0];
        string r = strs[strs.Length - 1];

        // the longest prefix length possible
        int maxLength = Math.Min(l.Length, r.Length);

        // build up that prefix
        int i = 0;
        while (i < maxLength && l[i] == r[i])
        {
            prefix += l[i];
            i += 1;
        }

        return prefix;
    }
}
