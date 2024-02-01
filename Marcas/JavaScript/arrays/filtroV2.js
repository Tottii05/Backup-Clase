function init(){
    console.log("array1 = [1,2,3,4] " + fiveMultiples([1,2,3,4]));
    console.log("array1 = [5,10,15,20] " + fiveMultiples([5,10,15,20]));
}

function fiveMultiples(array){
    let arrayFives = [];

    for (elemento of array){
        if(elemento % 5 == 0) {
            arrayFives.push(elemento);
        }
    }
    return arrayFives;
}