namespace Solutions.Lib.P0003;

/// <summary>
/// Represents a sliding window containing the
/// characters in a nonrepeating substring
/// </summary>
public class SlidingWindow
{
	readonly Queue<char> _queue = new();
	readonly HashSet<char> _encountered = new();
	int _startIndex = 0;

	public int StartIndex => _startIndex;
	public int Length => _queue.Count;

	public void Add(char num)
	{
		// easy case
		if (!_encountered.Contains(num))
		{
			_queue.Enqueue(num);
			_encountered.Add(num);
			return;
		}

		// otherwise we've got to dequeue a bunch o' stuff

		// start by removing all of the ones in front of the
		// last occurrence of the number
		char top = _queue.Peek();
		while (top != num)
		{
			_queue.Dequeue();
			_encountered.Remove(top);

			top = _queue.Peek();
			_startIndex += 1;
		}

		// then requeue the number we're adding
		_queue.Dequeue();
		_queue.Enqueue(num);
		_startIndex += 1;
	}
}
