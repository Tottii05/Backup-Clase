function init(){
    calcular(5,0, "division");
}

function calcular(num1, num2, operacion = "suma"){
    switch (operacion.toLocaleLowerCase()){
        case "suma":
            console.log(num1 + num2);
            break;
        case "resta":
            console.log(num1 - num2);
            break;
        case "multiplicacion":
            console.log(num1 * num2);
            break;
        case "division":
            if (num2 != 0){
                console.log(num1 / num2);
            }
            console.log("El divisor no puede ser 0");
            break;
    }
}