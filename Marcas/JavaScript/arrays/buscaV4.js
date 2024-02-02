function init(){
    console.log("array1 = [1,2,3,4,5,6,7,8,9] " + sumAllArray([1,2,3,4,5,6,7,8,9]));
}

function succeciveMinus(array){
    let total = 0;
    for (num of array){
        total += num;
    }
    return total;
}