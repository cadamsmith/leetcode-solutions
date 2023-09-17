using System.Text;

namespace Solutions.Lib.P0006;

public class ZigzagConversionSolutionA : BaseZigzagConversionSolution
{
    protected override string Convert(string s, int numRows)
    {
        if (numRows == 1)
        {
            return s;
        }

        StringBuilder sb = new();

        // magic number
        int k = 2 * (numRows - 1);
        // which row we are on
        int row = 0;

        // first row
        for (int i = 0; i < s.Length; i += k)
        {
            sb.Append(s[i]);
        }
        row += 1;

        // middle rows
        while (row < numRows - 1)
        {
            int l = k - (2 * row);
            int r = k - l;

            bool isOnDiagonal = false;
            int inc;
            for (int i = row; i < s.Length; i += inc)
            {
                sb.Append(s[i]);

                inc = isOnDiagonal ? r : l;
                isOnDiagonal = !isOnDiagonal;
            }

            row += 1;
        }

        // last row
        if (numRows > 1)
        {
            // last row
            for (int i = row; i < s.Length; i += k)
            {
                sb.Append(s[i]);
            }
        }

        return sb.ToString();
    }
}
