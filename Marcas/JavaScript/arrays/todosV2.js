function init(){
    console.log("array1 = [1,2,3,4] " + checkEven([1,2,3,4]));
    console.log("array1 = [2,4,6,8] " + checkEven([2,4,6,8]));
}

function checkEven(array) {
    for (elemento of array) {
        if (elemento % 2 !=0){
            return false;
        }
    }
    return true;
}