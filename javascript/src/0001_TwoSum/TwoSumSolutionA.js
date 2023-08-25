import { BaseTwoSumSolution } from './BaseTwoSumSolution.js';

// Brute Force Solution
export class TwoSumSolutionA extends BaseTwoSumSolution {
	// Time Complexity: O( N^2 )
	// Space Complexity: O( N )
	twoSum(nums, target) {
		const count = nums.length;

		for (let i = 0; i < count - 2; i++) {
			for (let j = i + 1; j < count; j++) {
				if (nums[i] + nums[j] == target) {
					return [i, j];
				}
			}
		}

		return [count - 2, count - 1];
	}
}
