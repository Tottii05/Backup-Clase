function init(){
    const COLORS = ['white', 'blue', 'green', 'violet', 'yellow', 'red', 'orange', 'cyan'];
    let master  = ["", "", "", ""];

    for (let i = 0; i < master.length; i++){
        master[i] = randomFill(COLORS.length, COLORS)
    }
    console.log(master);
}
function randomFill (length, COLORS){
    return COLORS[Math.floor(Math.random() * length)];
}
