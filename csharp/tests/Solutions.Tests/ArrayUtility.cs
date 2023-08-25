using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Tests;

internal static class ArrayUtility
{
	public static bool IsEqualWhenSorted(int[] nums1, int[] nums2)
	{
		Array.Sort(nums1);
		Array.Sort(nums2);

		return nums1.SequenceEqual(nums2);
	}
}
