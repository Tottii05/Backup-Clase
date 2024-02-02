function init(){
    console.log("array1 = [hola, empanada, perro, ensalada, pito] " + checkLastStartP(["hola", "empanada", "perro", "ensalada", "pito"]));
}

function checkLastStartP(array){
    for (let i = array.length - 1; i >= 0; i--){
        if (array[i].toLowerCase().startsWith("p")){
            return array[i];
        }
    }
}
