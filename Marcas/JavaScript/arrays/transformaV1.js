function init(){
    console.log("array1 = [hola, que, tal] " + checkOneEven(["hola", "que", "tal"]));
    console.log("array2 = [a,e,i] " + checkOneEven(["a","e","i"]));
}

function checkOneEven(array){
    let newArray = [];
    for (let elemento of array) {
        newArray.push(elemento.length);
    }
    return newArray
}