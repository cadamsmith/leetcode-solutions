# @param {Integer[]} nums
# @param {Integer} target
# @return {Integer[]}
def two_sum(nums, target)
    map = {}

    # map all of the nums to their locations
    nums.each_with_index do |num, i|
        num = nums[i]
        complement = target - num

        # but also check for complements along the way
        if map.key?(complement)
            return [i, map[complement]]
        end

        map[num] = i
    end

    # this line should never be reached
    []
end