/* In a given integer array nums, there is always exactly one largest element.

Find whether the largest element in the array is at least twice as much as every other number in the array.

If it is, return the index of the largest element, otherwise return -1.

Example 1:

Input: nums = [3, 6, 1, 0]
Output: 1
Explanation: 6 is the largest integer, and for every other number in the array x,
6 is more than twice as big as x.  The index of value 6 is 1, so we return 1.
 

Example 2:

Input: nums = [1, 2, 3, 4]
Output: -1
Explanation: 4 isn't at least as big as twice the value of 3, so we return -1.
 

Note:

nums will have a length in the range [1, 50].
Every nums[i] will be an integer in the range [0, 99].
 */

/**
 * @complexity Time: O(N), Space: O(1)
 * @param {number[]} nums
 * @return {number}
 */
var dominantIndex = function(nums) {

    let n = nums.length;

    if(n > 0) {

        let index_of_largest_number = 0;

        for(let i = 0; i < n; i++) {
            if(nums[index_of_largest_number] < nums[i]) {
                index_of_largest_number = i;
            }
        }

        for(let i = 0; i < n; i++) {
            if(i != index_of_largest_number && nums[i] * 2 > nums[index_of_largest_number]) {

                return -1;

            }
        }

        return index_of_largest_number;


    }

    return -1;
    
};

console.log(dominantIndex([3, 6, 1, 0]));