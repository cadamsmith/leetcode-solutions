﻿using Solutions.Lib;

namespace Solutions.Tests;

public abstract class TwoSumSolutionTests<TSolution> : BaseSolutionTests<TSolution>
    where TSolution : TwoSumSolution
{
    public TwoSumSolutionTests(BaseSolutionFixture fixture)
        : base(fixture) { }

	[Fact]
	public void BaseTestCase_1()
	{
		// Arrange
		int[] nums = new int[] { 2, 7, 11, 15 };
		int target = 9;
		TSolution solution = Fixture.Solution;

		// Act
		int[] result = (int[]) solution.Execute(nums, target);

		// Assert
		int[] expected = new int[] { 0, 1 };
		Assert.True(TwoSumSolutionTests<TSolution>.IsEqualWhenSorted(result, expected));
	}

	[Fact]
	public void BaseTestCase_2()
	{
		// Arrange
		int[] nums = new int[] { 3, 2, 4 };
		int target = 6;
		TSolution solution = Fixture.Solution;

		// Act
		int[] result = (int[]) solution.Execute(nums, target);

		// Assert
		int[] expected = new int[] { 1, 2 };
		Assert.True(TwoSumSolutionTests<TSolution>.IsEqualWhenSorted(result, expected));
	}

	[Fact]
	public void BaseTestCase_3()
	{
		// Arrange
		int[] nums = new int[] { 3, 3 };
		int target = 6;
		TSolution solution = Fixture.Solution;

		// Act
		int[] result = (int[]) solution.Execute(nums, target);

		// Assert
		int[] expected = new int[] { 0, 1 };
		Assert.True(TwoSumSolutionTests<TSolution>.IsEqualWhenSorted(result, expected));
	}

	[Fact]
	public void ExtraTestCase_1()
	{
		// Arrange
		int[] nums = new int[] { 2, 5, 5, 11 };
		int target = 10;
		TSolution solution = Fixture.Solution;

		// Act
		int[] result = (int[]) solution.Execute(nums, target);

		// Assert
		int[] expected = new int[] { 1, 2 };
		Assert.True(TwoSumSolutionTests<TSolution>.IsEqualWhenSorted(result, expected));
	}

	static bool IsEqualWhenSorted(int[] nums1, int[] nums2)
	{
		Array.Sort(nums1);
		Array.Sort(nums2);

		return nums1.SequenceEqual(nums2);
	}
}