function largestNumber(num1, num2, num3) {

    let arr = [num1, num2, num3];

    let maxNum = Math.min();

    if (num1 > num2 && num1 > num3) {
        maxNum = num1;
    }
    else if(num2 > num1 && num2 > num3){
        maxNum = num2
    }
    else if(num3 > num1 && num3 > num2){
        maxNum = num3
    }

    return `The largest number is ${maxNum}.`;
}

console.log(largestNumber(5, -3, 16));
console.log(largestNumber(-3, -5, -22.5));