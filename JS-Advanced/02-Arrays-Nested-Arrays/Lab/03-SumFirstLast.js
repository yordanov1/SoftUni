function sum(arr) {

   let first = Number(arr.shift());
   let last = Number(arr.pop());

   return first + last;

}

console.log(sum(['20', '30', '40']));
