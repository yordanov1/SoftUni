function solve(arr) {

    let result = arr
        .slice(0)
        .sort((a, b) => a.localeCompare(b))
        .map((name, index, initialArray) => {
            let result = `${index + 1}.${name}`
            return result;
        });

    return result.join('\n');

}