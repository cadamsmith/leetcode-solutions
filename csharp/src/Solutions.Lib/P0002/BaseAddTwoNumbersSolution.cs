namespace Solutions.Lib.P0002;

public abstract class BaseAddTwoNumbersSolution : BaseSolution
{
	protected override object Solve(object[] parameters)
	{
		ListNode l1 = (ListNode) parameters[0];
		ListNode l2 = (ListNode) parameters[1];

		return AddTwoNumbers(l1, l2);
	}

	protected abstract ListNode AddTwoNumbers(ListNode l1, ListNode l2);
}
