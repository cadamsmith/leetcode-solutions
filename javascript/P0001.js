/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
function twoSum(nums, target) {
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

    // this line should never be reached
    return [];
};