function radar(speed, area) {

    let maxSpeed = 0;

    switch (area) {
        case 'residential':
            maxSpeed = 20;
            break;
        case 'city':
            maxSpeed = 50;
            break;
        case 'interstate':
            maxSpeed = 90;
            break;
        case 'motorway':
            maxSpeed = 130;
            break;
    }

    let difference = maxSpeed - speed;


    if ((difference) >= 0) {

        console.log(`Driving ${speed} km/h in a ${maxSpeed} zone`);

    } else {

        difference *= -1;

        if ((difference) <= 20) {

            console.log(1111);
            console.log(`The speed is ${difference} km/h faster than the allowed speed of ${maxSpeed} - speeding`)
        }
        else if ((difference) <= 40) {

            console.log(`The speed is ${difference} km/h faster than the allowed speed of ${maxSpeed} - excessive speeding`)
        }
        else if ((difference) > 40) {

            console.log(`The speed is ${difference} km/h faster than the allowed speed of ${maxSpeed} - reckless driving`)
        }
    }

    console.log(33331);
}

radar(21, 'residential');