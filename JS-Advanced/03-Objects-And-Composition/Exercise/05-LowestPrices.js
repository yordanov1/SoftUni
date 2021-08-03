function lowest(input) {

    let colector = [];

    for (i = 0; i < input.length; i++) {

        let [town, product, price] = input[i].split(' | ');

        let newObject = {
            product: product,
            price: Number(price),
            town: town
        }

        let flag = true;

        for (let item of colector) {

            if (item.product == newObject.product) {
                if (item.price > newObject.price) {
                    item.price = newObject.price;
                    item.town = newObject.town;
                }
                flag = false;
            }
        }

        if (flag == true) {

            colector.push(newObject);
        }
    }

    colector.forEach(x => console.log(`${x.product} -> ${x.price} (${x.town})`));
}




lowest(['Sofia City | Audi | 100000',
    'Sofia City | BMW | 100000',
    'Sofia City | Mitsubishi | 10000',
    'Sofia City | Mercedes | 10000',
    'Sofia City | NoOffenseToCarLovers | 0',
    'Mexico City | Audi | 1000',
    'Mexico City | BMW | 99999',
    'New York City | Mitsubishi | 10000',
    'New York City | Mitsubishi | 1000',
    'Mexico City | Audi | 100000',
    'Washington City | Mercedes | 1000']);