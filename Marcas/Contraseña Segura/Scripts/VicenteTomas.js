const NUMS = "1234567890";
const MINLENGTH = 8;
const MAXLENGTH = 20;
const MINMAYUS = 1;
const MINMINUS = 2;
const MINNUMS = 1;
const SpecialChars = ['.',',','-','_','!','"','#','%','$','&','/','(',')'];

function init(){
    let password = " ";

    password = document.getElementById("pass").value;

    lengthCheck(password);
    mayusCheck(password);
    minusCheck(password);
    numCheck(password);
    sameWordCheck(password);
    spaceCheck(password);
    specialCharCheck(password);

}

function lengthCheck(password) {

    if (password.length >= MINLENGTH && password.length <= MAXLENGTH) {
        document.getElementById("longli").style.color="green";
        document.getElementById("longli").innerHTML+="&#10004;";
    }
    else {
        document.getElementById("longli").style.color="red";
        document.getElementById("longli").innerHTML+="&#10006;";
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
    if (mayus >= MINMAYUS) {
        document.getElementById("mayusli").style.color="green";
        document.getElementById("mayusli").innerHTML+="&#10004;";
    }
    else {
        document.getElementById("mayusli").style.color="red";
        document.getElementById("mayusli").innerHTML+="&#10006;";
    }
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
    if (minus >= MINMINUS) {
        document.getElementById("minusli").style.color="green";
        document.getElementById("minusli").innerHTML+="&#10004;";
    }
    else {
        document.getElementById("minusli").style.color="red";
        document.getElementById("minusli").innerHTML+="&#10006;";
    }
}

function numCheck(password){
    let nums = 0;

    for (let char of password){
        if (NUMS.includes(char)){
            nums++;
        }
    }
    if (nums >= MINNUMS) {
        document.getElementById("numli").style.color="green";
        document.getElementById("numli").innerHTML+="&#10004;";
    }
    else {
        document.getElementById("numli").style.color="red";
        document.getElementById("numli").innerHTML+="&#10006;";
    }
}

function sameWordCheck (password) {
    for (let i = 0; i < password.length-1; i++){
        if (password.charAt(i) == password.charAt(i+1) && password.charAt(i) == password.charAt(i+2)){   
            document.getElementById("sameli").style.color="red";
            document.getElementById("sameli").innerHTML+="&#10006;";
        }
    }
    document.getElementById("sameli").style.color="green";
    document.getElementById("sameli").innerHTML+="&#10004;";
}

function spaceCheck (password) {
    for (let i = 0; i < password.length-1; i++){
        if (password.charAt(i) == " "){   
            document.getElementById("spaceli").style.color="red";
            document.getElementById("spaceli").innerHTML+="&#10006;";
        }
    }
    document.getElementById("spaceli").style.color="green";
    document.getElementById("spaceli").innerHTML+="&#10004;";
}

function specialCharCheck (password){
    for (let i = 0; i < SpecialChars -1; i++){
        for (let j = 0; i < password.length -1; j++){
            if (SpecialChars.at(i) == password.charAt(j)){
                document.getElementById("specialli").style.color="green";
                document.getElementById("specialli").innerHTML+="&#10004;";
            }
        }
    }
    document.getElementById("specialli").style.color="red";
    document.getElementById("specialli").innerHTML+="&#10006;";
}

function showHidePass (){
    
    if (pass.type === "password"){
        pass.type = "text";
        document.getElementById("mostrar").src="ojoabierto.png";
    }
    else {
        pass.type = "password";
        document.getElementById("mostrar").src="ojocerrado.png";
    }
}