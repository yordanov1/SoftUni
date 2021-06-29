function odd(arr) {

    let newArr = [];

    for (i = 0; i < arr.length; i++) {

        if (i % 2 != 0) {
            newArr.unshift(arr[i] * 2);
        }
    }

    return newArr;
}

console.log(odd([3, 0, 10, 4, 7, 3]));