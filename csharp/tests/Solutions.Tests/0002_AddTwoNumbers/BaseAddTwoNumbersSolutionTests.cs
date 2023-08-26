using Solutions.Lib;

namespace Solutions.Tests;

public abstract class BaseAddTwoNumbersSolutionTests<TSolution> : BaseSolutionTests<TSolution>
	where TSolution : BaseAddTwoNumbersSolution
{
	public BaseAddTwoNumbersSolutionTests(BaseSolutionFixture fixture)
		: base(fixture) { }

	[Fact]
	public void BaseTestCase_1()
	{
		// Arrange
		ListNode l1 = ListNode.WithValues(2, 4, 3);
		ListNode l2 = ListNode.WithValues(5, 6, 4);
		TSolution solution = Fixture.Solution;

		// Act
		ListNode result = (ListNode) solution.Execute(l1, l2);

		// Assert
		int[] expectedValues = new int[] { 7, 0, 8 };
		Assert.True(expectedValues.SequenceEqual(result.GetValues()));
	}

	[Fact]
	public void BaseTestCase_2()
	{
		// Arrange
		ListNode l1 = ListNode.WithValues(0);
		ListNode l2 = ListNode.WithValues(0);
		TSolution solution = Fixture.Solution;

		// Act
		ListNode result = (ListNode)solution.Execute(l1, l2);

		// Assert
		int[] expectedValues = new int[] { 0 };
		Assert.True(expectedValues.SequenceEqual(result.GetValues()));
	}

	[Fact]
	public void BaseTestCase_3()
	{
		// Arrange
		ListNode l1 = ListNode.WithValues(9, 9, 9, 9, 9, 9, 9);
		ListNode l2 = ListNode.WithValues(9, 9, 9, 9);
		TSolution solution = Fixture.Solution;

		// Act
		ListNode result = (ListNode)solution.Execute(l1, l2);

		// Assert
		int[] expectedValues = new int[] { 8, 9, 9, 9, 0, 0, 0, 1 };
		Assert.True(expectedValues.SequenceEqual(result.GetValues()));
	}
}