function init(){
    console.log("array1 = [perro, zebra, gato, Zorro] " + zEnjoyer(["perro", "zebra", "gato", "Zorro"]));
}

function zEnjoyer(array){
    let arrayz = [];

    for (elemento of array){
        if(elemento.toLowerCase().startsWith("z")) {
            arrayz.push(elemento);
        }
    }
    return arrayz;
}