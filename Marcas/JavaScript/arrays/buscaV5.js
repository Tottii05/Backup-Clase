function init(){
    console.log("array1 = [1,2,3,4,5,6,7,8,9] " + succeciveMinus([1,2,3,4,5,6,7,8,9]));
}

function succeciveMinus(array){
    let resultado = array[0];
    
    for (let i = 1; i < array.length; i++) {
        resultado -= array[i];
    }
    return resultado;
}