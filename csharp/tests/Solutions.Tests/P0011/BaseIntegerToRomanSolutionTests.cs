using Solutions.Lib.P0011;

namespace Solutions.Tests.P0011;

public abstract class BaseIntegerToRomanSolutionTests<TSolution>
	: BaseSolutionTests<TSolution> where TSolution : BaseIntegerToRomanSolution
{
	public BaseIntegerToRomanSolutionTests(BaseSolutionFixture fixture)
		: base(fixture) { }

	[Fact]
	public void BaseTestCase_1()
	{
		// Arrange
		int num = 3;
		TSolution solution = Fixture.Solution;

		// Act
		string result = (string) solution.Execute(num);

		// Assert
		string expected = "III";
		Assert.Equal(expected, result);
	}

	[Fact]
	public void BaseTestCase_2()
	{
		// Arrange
		int num = 58;
		TSolution solution = Fixture.Solution;

		// Act
		string result = (string) solution.Execute(num);

		// Assert
		string expected = "LVIII";
		Assert.Equal(expected, result);
	}

	[Fact]
	public void BaseTestCase_3()
	{
		// Arrange
		int num = 1994;
		TSolution solution = Fixture.Solution;

		// Act
		string result = (string) solution.Execute(num);

		// Assert
		string expected = "MCMXCIV";
		Assert.Equal(expected, result);
	}

	[Fact]
	public void ExtraTestCase_1()
	{
		// Arrange
		int num = 3999;
		TSolution solution = Fixture.Solution;

		// Act
		string result = (string)solution.Execute(num);

		// Assert
		string expected = "MMMCMXCIX";
		Assert.Equal(expected, result);
	}

	[Fact]
	public void ExtraTestCase_2()
	{
		// Arrange
		int num = 400;
		TSolution solution = Fixture.Solution;

		// Act
		string result = (string)solution.Execute(num);

		// Assert
		string expected = "CD";
		Assert.Equal(expected, result);
	}
}