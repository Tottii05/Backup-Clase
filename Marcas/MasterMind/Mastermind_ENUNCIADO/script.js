//Declaración de constantes.
const MAX_INTENTOS = 10;
const MAX_COMBI_COLORES = 4;
const COLORS = ['white', 'blue', 'green', 'violet', 'yellow', 'red', 'orange', 'cyan'];
const GREY = "grey";
const WHITE = "white";
const BLACK = "black";


//Declaración de variables globales.
const master = [];
const userCombi = [];
const finalResult = [];
var intento = 0;
var aciertos = 0;

function init() {
    //1. Genera el código random del master
    for (let i = 0; i < MAX_COMBI_COLORES; i++) {
        master[i] = COLORS[Math.floor(Math.random() * COLORS.length)]
    }
    console.log("master es:");
    console.log(master)
    //2. Crea todas las filas según el número de intentos.
    for (let i = 0; i < MAX_COMBI_COLORES; i++) {
        let nuevoDiv = document.createElement("div");
        nuevoDiv.className = "UserInputColor" + i;
        nuevoDiv.innerHTML = ROW_RESULT;
        document.getElementById("Result").appendChild(nuevoDiv);
        let elementos = document.getElementsByClassName("UserInputColor" + i);
        for (let j = 0; j < elementos.length; j++) {
            elementos[j].style.width = "80%";
        }
    }    
}



/* Llamaremos a esta función desde el botón HTML de la página para comprobar la propuesta de combinación que nos ha
introducido el usuario.
Informamos al usuario del resultado y del número de intentos que lleva*/
function Comprobar() {
    const finalResult = [];

    for (let i = 0; i < userCombi.length; i++){
        if (userCombi[i] === master[i]){
            finalResult.push(BLACK);
        }
        else if (master.includes(userCombi[i])){
            finalResult.push(WHITE);
        }
        else {
            finalResult.push(GREY);
        }
    }

    console.log("Los resultados son:");
    console.log(finalResult);
    pintarResultados("white");
}


/** Procedimiento que se ejecuta cada vez que el usuario selecciona un color, hasta el número máximo de colores permitidos en la combinación. */
function añadeColor(color) {
    if (userCombi.length < MAX_COMBI_COLORES) {
        userCombi.push(color);
        document.getElementById("combiText").value = userCombi.join("-");
        document.getElementById("combiText").style.textAlign = "center";
        console.log("user combi es:");
        console.log(userCombi);
    }
}

function pintarResultados(color) {
    let fila = document.querySelectorAll(".cel.flex");
    let cuadrado = document.querySelectorAll(".celUserCombi.flex");
    for (let elemnto of cuadrado){
        elemnto.style.color = "red";
    }
}

/** Template con el código HTML que corresponde a cada fila de juego/intento. */
const ROW_RESULT = `<div class="rowResult w100 flex wrap">
    <div class="rowUserCombi w75 flex wrap">
       <div class="w25">
           <div class="celUserCombi flex"></div>
       </div>
       <div class="w25">
           <div class="celUserCombi flex"></div>
       </div>
       <div class="w25">
           <div class="celUserCombi flex"></div>
       </div>
       <div class="w25">
           <div class="celUserCombi flex"></div>
       </div>
    </div>
    <div class="rowCercleResult w25 flex wrap center">
       <div class="w40 h40">
            <div class="cercleResult flex"></div>
       </div>
       <div class="w40 h40">
           <div class="cercleResult flex"></div>
       </div>
       <div class="w40 h40">
           <div class="cercleResult flex"></div>
       </div>
       <div class="w40 h40">
           <div class="cercleResult flex"></div>
       </div>
    <div>
</div>`;