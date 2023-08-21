using Solutions.Lib;

namespace Solutions.Tests;

public abstract class TwoSumSolutionTests<TSolution> : BaseSolutionTests<TSolution>
    where TSolution : TwoSumSolution
{
    public TwoSumSolutionTests(BaseSolutionFixture fixture)
        : base(fixture) { }

    public static IEnumerable<object[]> BaseTestCasesData =>
        new List<object[]>
        {
            new object[]
            { 
                new int[] { 2, 7, 11, 15 },
                9,
                new int[] { 0, 1 }
            },
            new object[]
            {
                new int[] { 3, 2, 4 },
                6,
                new int[] { 1, 2 }
            },
            new object[]
            {
                new int[] { 3, 3 },
                6,
                new int[] { 0, 1 }
            }
        };

    [Theory]
    [MemberData(nameof(BaseTestCasesData))]
    public void BaseTestCases(int[] nums, int target, int[] expected)
    {
        // Arrange
        TSolution solution = Fixture.Solution;

        // Act
        int[] result = (int[]) solution.Execute(nums, target);

        // Assert
        Assert.Equal(expected, result);
    }
}