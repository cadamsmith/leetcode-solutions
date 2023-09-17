use std::collections::HashMap;

impl Solution {
    pub fn two_sum(nums: Vec<i32>, target: i32) -> Vec<i32> {
        let count = nums.len();
        let mut map: HashMap<i32, usize> = HashMap::with_capacity(count);

        // map all of the nums to their locations
        for (i, num) in nums.into_iter().enumerate() {
            let complement = target - num;

            // but also check for complements along the way
            
            if let Some(&complement_index) = map.get(&complement) {
                return vec![i as i32, complement_index as i32];
            }

            map.insert(num, i);
        }

        // this line should never be reached
        unreachable!();
    }
}