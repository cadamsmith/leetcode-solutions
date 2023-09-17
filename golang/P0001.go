func twoSum(nums []int, target int) []int {
    count := len(nums);
	
	m := make(map[int]int);

    // map all of the nums to their locations
    for i := 0; i < count; i++ {
        num := nums[i];
        complement := target - num;

        // but also check for complements along the way
		_, hasComplement := m[complement];
        if (hasComplement) {
            return []int{i, m[complement]};
        }

		m[num] = i;
    }

    // this line should never be reached
    return []int{};
}
