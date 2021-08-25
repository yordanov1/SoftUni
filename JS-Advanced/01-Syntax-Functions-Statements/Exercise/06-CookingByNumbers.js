function cooking(number, command1, command2, command3, command4, command5) {

    let numberInt = Number(number);

    const arr = [command1, command2, command3, command4, command5];

    for (let i = 0; i < 5; i++) {

        if (arr[i] == 'chop') {
            numberInt /= 2;
            console.log(numberInt);            
        }

        if (arr[i] == 'dice') {
            numberInt = Math.sqrt(numberInt);         
            console.log(numberInt);
        }

        if (arr[i] == 'spice') {
            numberInt++;
            console.log(numberInt);
        }

        if (arr[i] == 'bake') {
            numberInt *= 3;
            console.log(numberInt);
        }

        if (arr[i] == 'fillet') {
            let subtract = numberInt * 0.2;
            numberInt -= subtract;
            console.log(numberInt);
        }
    }
}


cooking('9', 'dice', 'spice', 'chop', 'bake', 'fillet');


