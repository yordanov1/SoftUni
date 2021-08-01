function details(input) {

    function getEngine(power) {

        const engines = [{ power: 90, volume: 1800 },
        { power: 120, volume: 2400 },
        { power: 200, volume: 3500 }];

        const engine = {};

        for (i = 0; i < engines.length; i++) {
            if (power <= engines[i].power) {
                engine.power = engines[i].power;
                engine.volume = engines[i].volume;
                break;
            }
        }

        return engine;
    }

    function getCarriage(color, carriage) {

        return {
            type: carriage,
            color: color
        }
    }

    function getWheels(wheelsize) {

        let size = wheelsize % 2 === 0 ? wheelsize - 1 : wheelsize;

        return [size, size, size, size];
    }

    return {
        model: input.model,
        engine: getEngine(input.power),
        carriage: getCarriage(input.color, input.carriage),
        wheels: getWheels(input.wheelsize)
    }
}

console.log(details({
    model: 'VW Golf II',
    power: 90,
    color: 'blue',
    carriage: 'hatchback',
    wheelsize: 14
}
));
