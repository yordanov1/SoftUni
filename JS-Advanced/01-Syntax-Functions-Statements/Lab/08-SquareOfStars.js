function stars(input) {




    for (let i = 0; i < input; i++) {

        let starsRow = '';

        for (let j = 0; j < input; j++) {

            starsRow += '*';

        }

        console.log(starsRow);
    }


}

stars(5);