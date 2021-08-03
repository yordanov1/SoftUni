function newInventory(input) {

    let result = [];

    while (input.length) {

        let currentElement = input.shift();

        let [name, level, itemsString] = currentElement.split(' / ');

        level = Number(level);

        let items = itemsString ? itemsString.split(', ') : [];

        let currentObject = { name: name, level: level, items: items };

        result.push(currentObject);
    }

    return JSON.stringify(result);
}


console.log(newInventory(['Isacc / 25 / Apple, GravityGun',
    'Derek / 12 / BarrelVest, DestructionSword',
    'Hes / 1 / Desolator, Sentinel, Antara']
))