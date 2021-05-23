function sum(num1, num2){

let number1 = Number(num1);
let number2 = Number(num2);

let all = 0;

for(let i = number1; i <= number2; i++){

all += i;

}

return all;

}

console.log(sum(-8, 20));