function init(){
    console.log("array1 = [hola, 2, 3.5, 2] " + checkString(["hola", 2, 3.5, "2"]));
    console.log("array2 = [hola, que, tal] " + checkString(["hola", "que", "tal"]));
}

function checkString(array){
    for (let elemento of array) {
        if (typeof elemento !== "string"){
            return false;
        }
    }
    return true;
}
