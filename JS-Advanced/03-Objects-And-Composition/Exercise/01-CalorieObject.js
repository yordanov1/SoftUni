function calorie(input){

const objectCal = {};

for(i = 0; i < input.length; i+=2){

    objectCal[input[i]] = Number(input[i + 1]);
}

return objectCal;
}

console.log(calorie(['Yoghurt', '48', 'Rise', '138', 'Apple', '52']))