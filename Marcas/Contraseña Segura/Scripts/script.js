const Input = "Escribe tu contraseña para saber si es segura o no";
const OK = "Ta bien";
const KO = "Ta mal";
const NUMS = "1234567890";
const MINLENGTH = 8;
const MAXLENGTH = 20;
const MINMAYUS = 1;
const MINMINUS = 2;
const SpecialChars = ['.',',','-','_','!','"','#','%','$','&','/','(',')'];

function init(){
    let password = " ";
    let lengthOk = false;
    let mayusOk = false;
    let minusOk = false;

    password = document.getElementById("pass").value;

    console.log(password);
    lengthCheck(password, lengthOk);

    console.log(mayusCheck(password, mayusOk) ? OK : KO);

    console.log(minusCheck(password, minusOk) ? OK : KO);

    console.log(sameWordCheck(password) ? KO : OK);

    console.log(spaceCheck(password) ? OK : KO);

    console.log(specialCharCheck(password) ? KO : OK);


}

function lengthCheck(password, lengthOk) {

    if (password.length >= MINLENGTH && password.length <= MAXLENGTH) {
        document.getElementById("longli").style.color="green";
        document.getElementById("longli").innerHTML+="&#10004;";
        return lengthOk = true;
    }
    else {
        document.getElementById("longli").style.color="red";
        document.getElementById("longli").innerHTML+="&#10006;";
        return lengthOk = false;
    }
}

function mayusCheck(password){
    let mayus = 0;

    for (let char of password){
        if (!NUMS.includes(char)){
            if (char == char.toUpperCase()){
                mayus++;
            }
        }
    }
    return mayus >= MINMAYUS ? true : false;
}

function minusCheck(password){
    let minus = 0;

    for (let char of password){
        if (!NUMS.includes(char)){
            if (char == char.toLowerCase()){
                minus++;
            }
        }
    }
    return minus >= MINMINUS ? true : false;
}

function sameWordCheck (password) {
    for (let i = 0; i < password.length-1; i++){
        if (password.charAt(i) == password.charAt(i+1) && password.charAt(i) == password.charAt(i+2)){   
            return true;
        }
    }
    return false;
}

function spaceCheck (password) {
    for (let i = 0; i < password.length-1; i++){
        if (password.charAt(i) == " "){   
            return false;
        }
    }
    return true;
}

function specialCharCheck (password){
    for (let i = 0; i < SpecialChars -1; i++){
        for (let j = 0; i < password.length -1; j++){
            if (SpecialChars.at(i) == password.charAt(j)){
                return true;
            }
        }
    }
    return false;
}

function changeColor(id){
    if (true) {
        document.getElementById(id).style.color="green"
    }
}