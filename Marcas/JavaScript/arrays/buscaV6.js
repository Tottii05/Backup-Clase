function init(){
    console.log("array1 = [1,2,3,4,5,6,7,8,9] " + succeciveMinusLast([1,2,3,4,5,6,7,8,9]));
}

function succeciveMinusLast(array){
    let resultado = array[array.length-1];
    
    for (let i = array.length-2; i >= 0; i--) {
        resultado -= array[i];
    }
    return resultado;
}