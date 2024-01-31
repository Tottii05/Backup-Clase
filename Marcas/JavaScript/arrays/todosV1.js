

function init(array){
    for (let elemento of array) {
        if (typeof elemento !== "string"){
            return false;
        }
    }
    return true;
}
console.log("array1 = [hola, 2, 3.5, 2] " + init(["hola", 2, 3.5, "2"]));
console.log("array2 = [hola, que, tal] " + init(["hola", "que", "tal"]));
