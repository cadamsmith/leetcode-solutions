namespace Solutions.Lib.P0002;

/// <summary>
/// A cleaner one-pass O(N) solution
/// </summary>
public class Solution0002B : Solution0002
{
	// Time Complexity: O(N)
	// Space Complexity: O(N)
	protected override ListNode AddTwoNumbers(ListNode l1, ListNode l2)
	{
		// arguments must be non-null
		if (l1 is null)
		{
			throw new ArgumentNullException(nameof(l1));
		}
		if (l2 is null)
		{
			throw new ArgumentNullException(nameof(l2));
		}

		ListNode head = new();
		ListNode current = head;
		int carry = 0;

		while (l1 is not null || l2 is not null)
		{
			// calculations
			int v1 = l1?.val ?? 0;
			int v2 = l2?.val ?? 0;
			(int digit, carry) = AddTwoDigits(v1, v2, carry);

			// make the next ListNode
			current.next = new ListNode(digit);

			// move all the pointers forward
			current = current.next;
			l1 = l1?.next;
			l2 = l2?.next;
		}

		if (carry != 0)
		{
			current.next = new ListNode(carry);
		}

		return head.next;
	}

	static (int digit, int carry) AddTwoDigits(int d1, int d2, int carry = 0)
	{
		const int Base = 10;

		int sum = d1 + d2 + carry;

		int newCarry = sum / Base;
		int newDigit = sum % Base;

		return (newDigit, newCarry);
	}
}
