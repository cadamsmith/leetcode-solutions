namespace Solutions.Lib;

public abstract class TwoSumSolution : BaseSolution
{
    protected override int[] Solve(object[] parameters)
    {
        int[] nums = (int[]) parameters[0];
        int target = (int) parameters[1];

        return TwoSum(nums, target);
    }

    protected abstract int[] TwoSum(int[] nums, int target);
}
