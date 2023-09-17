using Solutions.Lib.P0014;

namespace Solutions.Tests.P0014;

public abstract class Solution0014Tests<TSolution>
    : BaseSolutionTests<TSolution> where TSolution : Solution0014
{
    public Solution0014Tests(BaseSolutionFixture fixture) : base(fixture) { }

    [Fact]
    public void BaseTestCase_1()
    {
        // Arrange
        string[] strs = new string[] { "flower", "flow", "flight" };
        TSolution solution = Fixture.Solution;

        // Act
        object[] parameters = new object[] { strs };
        string result = (string) solution.Execute(parameters);

        // Assert
        string expected = "fl";
        Assert.Equal(expected, result);
    }

    [Fact]
    public void BaseTestCase_2()
    {
        // Arrange
        string[] strs = new string[] { "dog", "racecar", "car" };
        TSolution solution = Fixture.Solution;

        // Act
        object[] parameters = new object[] { strs };
        string result = (string) solution.Execute(parameters);

        // Assert
        string expected = string.Empty;
        Assert.Equal(expected, result);
    }
}