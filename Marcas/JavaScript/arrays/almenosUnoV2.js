function init(){
    console.log("array1 = [1, 2, 3] " + checkOneEven([1,2,3]));
    console.log("array2 = [1,3,5] " + checkOneEven([1,3,5]));
}

function checkOneEven(array){
    for (let elemento of array) {
        if (elemento % 2 == 0){
            return true;
        }
    }
    return false;
}