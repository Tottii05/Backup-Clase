function init(){
    const Input = "Escribe tu contraseña para saber si es segura o no";
    let password = " ";
    let lengthOk = false;
    let mayusOk = false;
    let minusOk = false;

    password = prompt(Input);

    lengthOk = lengthCheck(password, lengthOk);
    console.log(lengthOk);

    mayusOk = mayusCheck(password, mayusOk);
    console.log(mayusOk);

    minusOk = minusCheck(password, minusOk);
    console.log(minusOk);
}

function lengthCheck(password, lengthOk) {
    const MINLENGTH = 8;
    const MAXLENGTH = 20;

    console.log(password.length);
    if (password.length >= MINLENGTH && password.length <= MAXLENGTH) {
        return lengthOk = true;
    }
    else {
        return lengthOk = false;
    }
}

function mayusCheck(password, mayusOk){
    const MINMAYUS = 1;
    let mayus = 0;

    for (let char of password){
        if (char == char.toUpperCase()){
            mayus++;
        }
    }
    return mayus >= MINMAYUS ? true : false;
}

function minusCheck(password, minusOk){
    const MINMINUS = 1;
    let minus = 0;

    for (let char of password){
        if (char == char.toLowerCase()){
            minus++;
        }
    }
    return minus >= MINMINUS ? true : false;
}

function SameWord(password, )