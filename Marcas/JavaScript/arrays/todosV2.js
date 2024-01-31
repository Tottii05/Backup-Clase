function init(){
    let array = [];

    for (elemento of array) {
        if (elemento % 2 !=0){
            return false;
        }
    }
    return true;
}
console.log(init());