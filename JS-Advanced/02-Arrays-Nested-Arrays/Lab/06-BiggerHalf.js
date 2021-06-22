function firstTwoSmallest(arr){

    arr.sort((a, b) => a - b);
    
    let sliceArr = arr.slice(Math.floor(arr.length / 2));
    
    return sliceArr;
    
    }
    
    console.log(firstTwoSmallest([30, 15, 50, 5]))