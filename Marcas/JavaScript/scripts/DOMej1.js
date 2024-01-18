function init(){
    /*Ej 1*/
    let primerp = document.querySelector("#lipsum > p");
    console.log(primerp);

    let segundop = document.querySelector("#lipsum > p+p");
    console.log(segundop);

    let ultimoli = document.querySelectorAll("li");
    console.log(ultimoli[ultimoli.length-1]);

    let labelsexo = document.querySelectorAll("label");
    console.log(labelsexo[labelsexo.length-1]);

    /*EJ 2*/
    let allp = document.querySelectorAll("p");
    for (let i = 0; i < allp.length -1; i++){
        allp[i].setAttribute("id", "id_añadido"+[i]);
    }

    document.getElementById("button1").value = "Aceptar";
    document.getElementById("button2").value = "Rechazar";

    let bluelabel = document.getElementById("input2");
    bluelabel.style.backgroundColor="lightblue";
}