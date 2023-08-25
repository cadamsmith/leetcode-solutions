import { BaseTwoSumSolution } from './BaseTwoSumSolution.js';

// Brute Force Solution
export class TwoSumSolutionD extends BaseTwoSumSolution {
	// Time Complexity: O( N )
	// Space Complexity: O( N )
	twoSum(nums, target) {
		const count = nums.length;
		const map = new Map();

		// map all of the nums to their locations
		for (let i = 0; i < count; i++) {
			const num = nums[i];
			const complement = target - num;

			// but also check for complements along the way
			if (map.has(complement)) {
				return [i, map.get(complement)];
			}

			map.set(num, i);
		}

		throw new Error('No solution found.');
	}
}
