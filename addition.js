/*
 * This program adds two numbers without 
 * explicitly using the plus (+) operator.
 * 
 * Of course some of the builtin methods used
 * may use the operation somewhere :)
 */



 
let x = 100;
let y = 150;
let z = 350;

//Two numbers
console.log("x + y is: " + add(x, y));

//Three numbers
console.log("x + y + z is: " + add(x, add(y, z)));


function add(x, y) {

    //checks
    if (x == 0) {
        return y;
    }
    if (y == 0) {
        return x;
    }

    //create tallies
    x_arr = createTallies(x);
    y_arr = createTallies(y);


    let r_arr = [];
    var longestArr = (x_arr.length > y_arr.length ? x_arr : y_arr).length;

    //pad arrays to be same length
    for (let i = 0; i < longestArr; i++) {

        if (x_arr.length < longestArr) {
            x_arr.unshift('0');
        }
        if (y_arr.length < longestArr) {
            y_arr.unshift('0');
        }
    }

    let current_position = longestArr - 1;
    let buffer = 0;
    for (; current_position > -1; current_position--) {

        let count = getPipeCount(x_arr[current_position].toString()) + getPipeCount(y_arr[current_position].toString());
        if (!isNaN(buffer) && buffer != 0) {

            let temp_x = [...x_arr];
            let temp_y = [...y_arr];
            count = add(count, buffer);
            buffer = 0;

            x_arr = temp_x;
            y_arr = temp_y;
        }

        let countLength = count.toString().length;

        if (countLength == 1) {
            r_arr.unshift(count);
        }
        else {
            if (current_position == 0) {
                r_arr.unshift(count);
            }
            else {
                let values = count.toString().split('');
                let lastValueIndex = values.length - 1;
                r_arr.unshift(values[lastValueIndex]);
                buffer = parseInt(values.slice(0, lastValueIndex));
            }
        }

    }
    return parseInt(r_arr.join(""));
}

function createTallies(number) {

    let arr = [];
    let temp = number.toString().split('');
    temp.forEach(function (item, index) {
        arr.push(('|'.repeat(item)));
    });

    return arr;
}

function getPipeCount(string) {

    let count = 0;
    var char_array = string.split('');
    char_array.forEach(function (item, index) {
        if (item == '|') {
            count++;
        }
    });
    return count;
}

