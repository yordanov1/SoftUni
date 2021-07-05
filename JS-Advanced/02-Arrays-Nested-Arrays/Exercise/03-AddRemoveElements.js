function addRemove(arr) {

    let result = [];
    let firsNumber = 1;

    for (let i = 0; i < arr.length; i++) {

        if (arr[i] === 'add') {

            result.push(firsNumber);

        } else {

            result.pop();

        }

        firsNumber++;
    }

    return result.length != 0 ? result.join('\n') : 'Empty';
}

console.log(addRemove(['add',
    'add',
    'remove',
    'add',
    'add']
));



