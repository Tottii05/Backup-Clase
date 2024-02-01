function init(){
    calcularMedia("pedro", "juan", "federico");
}

function calcularMedia(){
    let arrayNombres = [];
    for (elemento of arguments) {
        arrayNombres.push(elemento)
    }
    console.log(arrayNombres);
}