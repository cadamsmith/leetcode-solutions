class Solution {
  List<int> twoSum(List<int> nums, int target) {
    Map<int, int> map = {};

    for (int i = 0; i < nums.length; i++) {
      int num = nums[i];
      int complement = target - num;

      if (map.containsKey(complement)) {
        return [map[complement]!, i];
      }

      map[num] = i;
    }

    // If no solution is found, return an empty list
    return [];
  }
}
