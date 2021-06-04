function sameNumbers(number) {

    const text = number.toString();
    const firstSymbol = text[0];
    let all = 0;

    let flag = true;

    for (let i = 1; i < text.length; i++) {

        if (text[i] != firstSymbol) {
            flag = false;
            break;
        }
    }

    for (let i = 0; i < text.length; i++) {

        all += Number(text[i]);        
    }

    return `${flag}\n${all}`
}

console.log(sameNumbers(2222222))

