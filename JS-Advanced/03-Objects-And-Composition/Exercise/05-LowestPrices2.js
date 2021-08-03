function solve(input) {
    
    let log = {};

    while (input.length) {
        let sale = input.shift();
        let [town, product, price] = sale.split(' | ');

        if (!log[product]) {
            log[product] = { town, price: Number(price) }
        } else {
            log[product] = log[product].price <= Number(price) ? log[product] : { town, price: Number(price) };
        }
    }

    let result = [];

    for (const product in log) {
        result.push(`${product} -> ${log[product].price} (${log[product].town})`)
    }
    return result.join('\n');

}


console.log(solve(['Sofia City | Audi | 100000',
    'Sofia City | BMW | 100000',
    'Sofia City | Mitsubishi | 10000',
    'Sofia City | Mercedes | 10000',
    'Sofia City | NoOffenseToCarLovers | 0',
    'Mexico City | Audi | 1000',
    'Mexico City | BMW | 99999',
    'New York City | Mitsubishi | 10000',
    'New York City | Mitsubishi | 1000',
    'Mexico City | Audi | 100000',
    'Washington City | Mercedes | 1000']));