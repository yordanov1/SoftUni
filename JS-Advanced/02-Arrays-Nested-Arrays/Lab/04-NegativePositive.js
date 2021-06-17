function sort(arr) {

    let newArr = [];

    for (let i = 0; i < arr.length; i++) {
        if (arr[i] < 0) {
            newArr.unshift(arr[i]);
        } else {
            newArr.push(arr[i]);
        }
    }

    return newArr;
}

console.log(sort([7, -2, 8, 9]));