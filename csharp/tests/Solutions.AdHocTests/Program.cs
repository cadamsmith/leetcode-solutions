using Solutions.Lib.P0002;

try
{
	// Arrange
	ListNode l1 = ListNode.WithValues(2, 4, 3);
	ListNode l2 = ListNode.WithValues(5, 6, 4);
	Solution0002A solution = new();

	// Act
	ListNode result = (ListNode) solution.Execute(l1, l2);
	int[] values = result.GetValues().ToArray();
}
catch (Exception e)
{
	Console.WriteLine(e.ToString());
}
