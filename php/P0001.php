class Solution {

    /*
    * @param Integer[] $nums
    * @param Integer $target
    * @return Integer[]
    */
    function twoSum($nums, $target) {
        $map = array();
        
        foreach ($nums as $index => $num) {
            $complement = $target - $num;

            if (array_key_exists($complement, $map)) {
                return [$map[$complement], $index];
            }

            $map[$num] = $index;
        }

        // If no solution is found, return an empty array
        return array();
    }
}