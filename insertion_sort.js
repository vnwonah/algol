function sort(arr, n){

    let i, j;

    for(i = 1; i < n; i++){
        
        j = i;

        while((j > 0) && arr[j] < arr[j - 1]){

            let temp = arr[j - 1];
            arr[j - 1] = arr[j];
            arr[j] = temp;

            j = j - 1;
        }
    }

    return arr;
}

console.log(sort(['I','N','S','E','R','T','I','O','N','S','O','R','T'], 13));