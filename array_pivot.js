/* LINK: https://leetcode.com/explore/learn/card/array-and-string/201/introduction-to-array/1144/

Given an array of integers nums, write a method that returns the "pivot" index of this array.

We define the pivot index as the index where the sum of the numbers to the left of the index is equal to the sum of the numbers to the right of the index.

If no such index exists, we should return -1. If there are multiple pivot indexes, you should return the left-most pivot index.

Example 1:

Input: 
nums = [1, 7, 3, 6, 5, 6]
Output: 3
Explanation: 
The sum of the numbers to the left of index 3 (nums[3] = 6) is equal to the sum of numbers to the right of index 3.
Also, 3 is the first index where this occurs.
 

Example 2:

Input: 
nums = [1, 2, 3]
Output: -1
Explanation: 
There is no index that satisfies the conditions in the problem statement.
 

Note:

The length of nums will be in the range [0, 10000].
Each element nums[i] will be an integer in the range [-1000, 1000].
 */



/**
 * @tutorial NaiveSolution
 * @complexity O(N^2) Time, O(1) Space
 * @param {number[]} nums
 * @return {number}
 */
var pivotIndex = function(nums) {
    
    //elements with less than 3 items cannot have a pivot
    if(nums.length > 0) {

        for(let i = 0; i < nums.length; i++) {

            let left_sum = 0;
            let right_sum = 0;


            for(let j = 0; j < i; j++) {

                //add everything on left together
                left_sum += nums[j];
                
            }


            for(let j = i + 1; j < nums.length; j++) {


                //add everyting on right together
                right_sum += nums[j];
                
            }

            if(left_sum == right_sum) {

                return i;
            }
        }

    }

    return -1;
    
};

//console.log(pivotIndex([1,7,3,6,5,6]));


/**
 * @tutorial EfficientSolution
 * @complexity O(N) Time, O(1) Space
 * @param {number[]} nums
 * @return {number}
 */
var pivotIndex = function(nums) {

    let n = nums.length;

    if(n > 0) {

        let sum = 0;
        let left_sum = 0;

        for(let i = 0; i < n; i++) {

            sum += nums[i]; //sum elements O(N)
           
        }

        for(let i = 0; i < n; i++) {

            sum -= nums[i];

            if(sum == left_sum) {
                return i;
            }

            left_sum += nums[i];
        }
    }

    return -1;
    
};

console.log(pivotIndex([1,7,3,6,5,6]));