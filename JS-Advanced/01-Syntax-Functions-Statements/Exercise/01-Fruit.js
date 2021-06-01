function print(fruit, weight, money) {

    let weightInKG = weight / 1000;
    let moneyWeNeed = money * (weight / 1000);

    return (`I need $${moneyWeNeed.toFixed(2)} to buy ${weightInKG.toFixed(2)} kilograms ${fruit}.`);
}

console.log(print('orange', 2500, 1.80));