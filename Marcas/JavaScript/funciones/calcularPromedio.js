function init(){
    calcularMedia(7,5,9);
}

function calcularMedia(){
    let cant = 0;
    let suma = 0;
    for (let i = 0; i < arguments.length; i++){
        suma += arguments[i];
        cant++;
    }
    console.log(suma / cant);
}