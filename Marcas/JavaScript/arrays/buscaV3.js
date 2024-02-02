function init(){
    console.log("array1 = [1,2,3,4,5,6,7,8,9] " + checkLastEven([1,2,3,4,5,6,7,8,9]));
}

function checkLastEven(array){
    for (let i = array.length - 1; i >= 0; i--){
        if (array[i] % 2 == 0){
            return array[i];
        }
    }
}
