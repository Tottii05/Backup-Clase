function init(){
    saludar("juan");
    saludar("saludos", "Pedro");
}

function saludar(nombre, saludo = "hola"){
    console.log(saludo + " " + nombre);
}