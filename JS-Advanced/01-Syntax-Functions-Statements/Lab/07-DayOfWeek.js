function dayOfWeek(inpun){

let number = 'error';

if(inpun === 'Monday'){
number = 1;
}
else if(inpun === 'Tuesday'){
    number = 2;
}
else if(inpun === 'Wednesday'){
    number = 3;
}
else if(inpun === 'Thursday'){
    number = 4;
}
else if(inpun === 'Friday'){
    number = 5;
}
else if(inpun === 'Saturday'){
    number = 6;
}
else if(inpun === 'Sunday'){
    number = 7;
}

return number;

}

console.log(dayOfWeek('Saturday'));

