using Solutions.Lib;

namespace Solutions.Tests;

public abstract class BaseLongestNonRepeatingSubstringSolutionTests<TSolution>
	: BaseSolutionTests<TSolution> where TSolution : BaseLongestNonRepeatingSubstringSolution
{
	public BaseLongestNonRepeatingSubstringSolutionTests(BaseSolutionFixture fixture)
		: base(fixture) { }

	[Fact]
	public void BaseTestCase_1()
	{
		// Arrange
		string input = "abcabcbb";
		TSolution solution = Fixture.Solution;

		// Act
		int result = (int) solution.Execute(input);

		// Assert
		int expected = 3;
		Assert.Equal(expected, result);
	}

	[Fact]
	public void BaseTestCase_2()
	{
		// Arrange
		string input = "bbbbb";
		TSolution solution = Fixture.Solution;

		// Act
		int result = (int) solution.Execute(input);

		// Assert
		int expected = 1;
		Assert.Equal(expected, result);
	}

	[Fact]
	public void BaseTestCase_3()
	{
		// Arrange
		string input = "pwwkew";
		TSolution solution = Fixture.Solution;

		// Act
		int result = (int) solution.Execute(input);

		// Assert
		int expected = 3;
		Assert.Equal(expected, result);
	}

	[Fact]
	public void ExtraTestCase_1()
	{
		// Arrange
		string input = "aab";
		TSolution solution = Fixture.Solution;

		// Act
		int result = (int)solution.Execute(input);

		// Assert
		int expected = 2;
		Assert.Equal(expected, result);
	}

	[Fact]
	public void ExtraTestCase_2()
	{
		// Arrange
		string input = "dvdf";
		TSolution solution = Fixture.Solution;

		// Act
		int result = (int)solution.Execute(input);

		// Assert
		int expected = 3;
		Assert.Equal(expected, result);
	}

	[Fact]
	public void ExtraTestCase_3()
	{
		// Arrange
		string input = "bwf";
		TSolution solution = Fixture.Solution;

		// Act
		int result = (int) solution.Execute(input);

		// Assert
		int expected = 3;
		Assert.Equal(expected, result);
	}
}