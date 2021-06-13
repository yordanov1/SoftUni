function solve(n, k) {

    const sum = (a, b) => a + b;
    const isNotZero = e => e > 0;

    let operationsMap = {
        true: x => x.reduce(sum, 0),
        false: x => x.filter(isNotZero).slice(-k).reduce(sum, 0)
    }

    let result = new Array(n)
    result[0] = 1

    for (let i = 1; i < n; i++) {
        result[i] = operationsMap[i <= k](result)
    }

    return result
}

console.log(solve(6, 3))