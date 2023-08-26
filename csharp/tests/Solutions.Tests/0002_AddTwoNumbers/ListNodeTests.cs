using Solutions.Lib;

namespace Solutions.Tests;

public class ListNodeTests
{
	[Fact]
	public void WithValues_EmptyList_ThrowsArgumentException()
	{
		Assert.Throws<ArgumentException>(
			() => ListNode.WithValues(new List<int>())
		);
	}

	[Fact]
	public void WithValues_SingleValue_CreatesSingleNode()
	{
		ListNode node = ListNode.WithValues(5);

		Assert.Equal(5, node.val);
		Assert.Null(node.next);
	}

	[Fact]
	public void WithValues_MultipleValues_CreatesLinkedList()
	{
		ListNode node = ListNode.WithValues(1, 2, 3);

		Assert.Equal(1, node.val);
		Assert.NotNull(node.next);
		Assert.Equal(2, node.next.val);
		Assert.NotNull(node.next.next);
		Assert.Equal(3, node.next.next.val);
		Assert.Null(node.next.next.next);
	}

	[Fact]
	public void Equals_SameValues_ReturnsTrue()
	{
		ListNode l1 = ListNode.WithValues(1, 2, 3);
		ListNode l2 = ListNode.WithValues(1, 2, 3);

		Assert.True(l1.Equals(l2));
	}

	[Fact]
	public void Equals_DifferentValues_ReturnsFalse()
	{
		ListNode l1 = ListNode.WithValues(1, 2, 3);
		ListNode l2 = ListNode.WithValues(3, 2, 1);

		Assert.False(l1.Equals(l2));
	}

	[Fact]
	public void GetHashCode_SameValues_ReturnsSameHashCode()
	{
		ListNode l1 = ListNode.WithValues(1, 2, 3);
		ListNode l2 = ListNode.WithValues(1, 2, 3);

		Assert.Equal(l1.GetHashCode(), l2.GetHashCode());
	}
}
