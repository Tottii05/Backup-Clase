function init(){
    console.log("array1 = [hola, como, estamos] " + checkLength(["hola", "como", "estamos"]));
    console.log("array2 = [a, e, i] " + checkLength(["a", "e", "i"]));
}

function checkLength(array){
    for (let elemento of array) {
        if (elemento.length > 2){
            return true;
        }
    }
    return false;
}
