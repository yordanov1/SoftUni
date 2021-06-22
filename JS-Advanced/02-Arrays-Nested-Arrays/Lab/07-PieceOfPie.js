function pieceOfPie(arr, first, second){

let positionFirst = arr.indexOf(first);
let positionSecond = arr.indexOf(second);

let pieceArr = arr.slice(positionFirst, positionSecond + 1);

return pieceArr;

}

console.log(pieceOfPie(['Pumpkin Pie',
'Key Lime Pie',
'Cherry Pie',
'Lemon Meringue Pie',
'Sugar Cream Pie'],
'Key Lime Pie',
'Lemon Meringue Pie'
));