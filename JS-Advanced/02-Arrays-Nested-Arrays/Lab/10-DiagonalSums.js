function diagonalSums(matrix) {

    let diagonalSum1 = 0;
    let diagonalSum2 = 0;

    for (let i = 0; i < matrix.length; i++) {

        diagonalSum1 += matrix[i][i];
        diagonalSum2 += matrix[i][matrix.length - i - 1];
    }

    console.log(diagonalSum1, diagonalSum2);
}

diagonalSums([[3, 5, 17],
              [-1, 7, 14],
              [1, -8, 89]]
            );