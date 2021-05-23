function mathOperations(num1, num2, operation) {

    let result = 0; 

    switch (operation) {
        case '+': result = num1 + num2; break;
        case '-': result = num1 - num2; break;
        case '*': result = num1 * num2; break;
        case '/': result = num1 / num2; break;
        case '%': result = num1 % num2; break;
        case '**': result = num1 ** num2; break;
    }

    return result;
}

console.log(mathOperations(3, 5.5, '*'));