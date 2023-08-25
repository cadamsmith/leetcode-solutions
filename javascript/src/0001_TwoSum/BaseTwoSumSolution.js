import { BaseSolution } from '../BaseSolution.js';

export class TwoSumSolution extends BaseSolution {
	solve(nums, target) {
		return twoSum(nums, target);
	}

	twoSum() {
		throw new Error('method not implemented');
	}
}
