function biggestElement(matrix) {

    let biggestElementofMatrix = Number.MIN_VALUE;

    for (let row of matrix) {

        for (let number of row) {

            if (number > biggestElementofMatrix) {
                biggestElementofMatrix = number;
            }
        }
    }

    return biggestElementofMatrix;
}

console.log(biggestElement([[20, 50, 10],
[8, 33, 145]]
));