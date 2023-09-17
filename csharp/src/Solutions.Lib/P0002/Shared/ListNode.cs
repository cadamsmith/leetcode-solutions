namespace Solutions.Lib.P0002;

public class ListNode
{
	public int val;
	public ListNode next;
	
	public ListNode(int val = 0, ListNode next = null)
	{
		this.val = val;
		this.next = next;
	}

	public static ListNode WithValues(params int[] nums)
	{
		return WithValues(nums.AsEnumerable());
	}

	public static ListNode WithValues(IEnumerable<int> nums)
	{
		if (!nums.Any())
		{
			throw new ArgumentException("Must supply one or more values", nameof(nums));
		}

		ListNode list = new(nums.ElementAt(0));
		ListNode curr = list;

		for (int i = 1; i < nums.Count(); i++)
		{
			curr.next = new ListNode(nums.ElementAt(i));
			curr = curr.next;
		}

		return list;
	}

	public IEnumerable<int> GetValues()
	{
		ListNode curr = this;
		List<int> values = new();

		while (curr != null)
		{
			values.Add(curr.val);
			curr = curr.next;
		}

		return values;
	}

	public override bool Equals(object obj)
	{
		if (obj is null || !GetType().Equals(obj.GetType()))
		{
			return base.Equals(obj);
		}

		ListNode list = (ListNode) obj;

		return GetValues().SequenceEqual(list.GetValues());
    }

	public override int GetHashCode()
	{
		IEnumerable<int> values = GetValues();
		HashCode hash = new();

		foreach (int value in values)
		{
			hash.Add(value);
		}

		return hash.ToHashCode();
	}
}
