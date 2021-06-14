function even(arr) {

    let newArr = [];

    for (let i = 0; i < arr.length; i++)
        if (i % 2 === 0) {
            newArr.push(arr[i]);
        }
    
        return newArr.join(' ');
}

console.log(even(['20', '30', '40', '50', '60']))
