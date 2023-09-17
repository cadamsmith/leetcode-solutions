using Solutions.Lib.P0006;

namespace Solutions.Tests.P0006;

public abstract class BaseZigzagConversionSolutionTests<TSolution>
    : BaseSolutionTests<TSolution> where TSolution : BaseZigzagConversionSolution
{
    public BaseZigzagConversionSolutionTests(BaseSolutionFixture fixture)
        : base(fixture) { }

    [Fact]
    public void BaseTestCase_1()
    {
        // Arrange
        string s = "PAYPALISHIRING";
        int numRows = 3;
        TSolution solution = Fixture.Solution;

        // Act
        string result = (string) solution.Execute(s, numRows);

        // Assert
        string expected = "PAHNAPLSIIGYIR";
        Assert.Equal(expected, result);
    }

    [Fact]
    public void BaseTestCase_2()
    {
        // Arrange
        string s = "PAYPALISHIRING";
        int numRows = 4;
        TSolution solution = Fixture.Solution;

        // Act
        string result = (string) solution.Execute(s, numRows);

        // Assert
        string expected = "PINALSIGYAHRPI";
        Assert.Equal(expected, result);
    }

    [Fact]
    public void BaseTestCase_3()
    {
        // Arrange
        string s = "A";
        int numRows = 1;
        TSolution solution = Fixture.Solution;

        // Act
        string result = (string) solution.Execute(s, numRows);

        // Assert
        string expected = "A";
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ExtraTextCase_1()
    {
        // Arrange
        string s = "ABCD";
        int numRows = 2;
        TSolution solution = Fixture.Solution;

        // Act
        string result = (string) solution.Execute(s, numRows);

        // Assert
        string expected = "ACBD";
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ExtraTextCase_2()
    {
        // Arrange
        string s = "ABCDE";
        int numRows = 3;
        TSolution solution = Fixture.Solution;

        // Act
        string result = (string) solution.Execute(s, numRows);

        // Assert
        string expected = "AEBDC";
        Assert.Equal(expected, result);
    }
}