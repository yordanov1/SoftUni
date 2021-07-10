    function solvee(arr){

        return arr.reduce(function(result, currentValue, index, initialArr){

            if(currentValue >= result[result.length - 1] || result.length === 0){
                
                result.push(currentValue)
            }
            return result;
        }, []);
    }
     
    console.log(solvee([1, 
        3, 
        8, 
        4, 
        10, 
        12, 
        3, 
        2, 
        24]
        ));