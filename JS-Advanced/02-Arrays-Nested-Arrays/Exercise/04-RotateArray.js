function rotatePrint(array, n) {

    for (let i = 0; i < n; i++) {

        let popar = array.pop();
        array.unshift(popar);

    }

  console.log(array.join(' '))
}

rotatePrint(['Banana', 
'Orange', 
'Coconut', 
'Apple'], 
15
);


