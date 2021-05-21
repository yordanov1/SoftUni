function strringLength(input1, input2, input3){

let counter1 = input1.length;
let counter2 = input2.length;
let counter3 = input3.length;

let counter = counter1 + counter2 + counter3;
let average = Math.floor(counter  / 3 );

console.log(counter);
console.log(average);

}

strringLength('chocolate', 'ice cream', 'cake');