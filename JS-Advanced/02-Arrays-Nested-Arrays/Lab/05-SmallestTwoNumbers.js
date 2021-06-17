function firstTwoSmallest(arr){

arr.sort((a, b) => a - b);

let sliceArr = arr.slice(0,2);

return sliceArr.join(' ');

}

console.log(firstTwoSmallest([30, 15, 50, 5]))