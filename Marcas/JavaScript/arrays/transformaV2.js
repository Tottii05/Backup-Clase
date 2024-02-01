function init(){
    console.log("array1 = [1,2,3,4] " + multNumber([1,2,3,4], 4));
    console.log("array2 = [2,4,6,8] " + multNumber([2,4,6,8], 7));
}

function multNumber(array, num){
    for (let i = 0; i < array.length; i++){
        array[i] = array[i] * num;
    }
    return array;
}