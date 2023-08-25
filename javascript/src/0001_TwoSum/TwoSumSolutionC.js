import { BaseTwoSumSolution } from './BaseTwoSumSolution.js';

// Brute Force Solution
export class TwoSumSolutionC extends BaseTwoSumSolution {
	// Time Complexity: O( N )
	// Space Complexity: O( N )
	twoSum(nums, target) {
		const count = nums.length;
		const map = new Map();

		// map all of the nums to their locations
		for (let i = 0; i < count; i++)
		{
			const num = nums[i];
			map.set(num, i);
		}

		// search for a num complement in the array
		for (let i = 0; i < count; i++)
		{
			const num = nums[i];
			const complement = target - num;

			// making use of our quick lookup map
			if (map.has(complement)) {
				const complementIndex = map.get(complement);

				if (i !== complementIndex) {
					return [i, complementIndex];
				}
			}
		}

		// this line should never be reached
		return [];
	}
}
