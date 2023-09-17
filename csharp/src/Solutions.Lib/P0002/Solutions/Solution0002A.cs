namespace Solutions.Lib.P0002;

/// <summary>
/// A messy one-pass O(N) solution
/// </summary>
public class Solution0002A : Solution0002
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

		int v1 = l1.val;
		int v2 = l2.val;

		(int digit, int carry) = AddTwoDigits(v1, v2);
		ListNode list = new(digit);
		ListNode curr = list;

		l1 = l1.next;
		l2 = l2.next;

		while (l1 is not null || l2 is not null)
		{
			// calculations
			v1 = l1?.val ?? 0;
			v2 = l2?.val ?? 0;
			(digit, carry) = AddTwoDigits(v1, v2, carry);

			// make the next ListNode
			curr.next = new ListNode(digit);
			
			// move all the pointers forward
			curr = curr.next;
			if (l1 is not null)
			{
				l1 = l1.next;
			}
			if (l2 is not null)
			{
				l2 = l2.next;
			}
		}

		if (carry != 0)
		{
			curr.next = new ListNode(carry);
		}

		return list;
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
