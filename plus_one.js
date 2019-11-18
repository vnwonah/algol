/**
 * @param {number[]} digits
 * @return {number[]}
 */
var plusOne = function(digits) {

    let n = digits.length;

    if(n < 1) {
        return [1];
    }

    if(digits[n - 1] < 9) {

        digits[n - 1] += 1;
    } 
    else {

        let index = [n - 1];
        let extra = 1;

        while(index > -1 && digits[index] + extra > 9) {

            let temp = (digits[index] + extra).toString().split("");
            digits[index] = parseInt(temp[1]);
            extra = parseInt(temp[0]);
            index--;
        }

        if(index < 0 && extra > 0) {
            digits.unshift(extra);
        }
        else {
            digits[index] += extra;
        }

    }

    return digits;
    
};

console.log(plusOne([1,9]))