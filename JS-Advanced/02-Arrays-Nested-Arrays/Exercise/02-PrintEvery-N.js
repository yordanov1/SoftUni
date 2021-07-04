const print = (arr, step) => {

let result = arr.filter((el, i) => i % step === 0);

return result;

}

console.log(print(['5', 
'20', 
'31', 
'4', 
'20'], 
2
));