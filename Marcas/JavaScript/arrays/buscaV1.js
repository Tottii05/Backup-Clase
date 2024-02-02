function init(){
    console.log("array1 = [cinco, a, e, empanada] " + checkItemLenth(["cinco", "a", "e", "empanada"]));
}

function checkItemLenth(array){
    let newArray = [];

    for (item of array){
        if (item.length >= 5) {
            newArray.push(item);
        }
    }
    return newArray;
}