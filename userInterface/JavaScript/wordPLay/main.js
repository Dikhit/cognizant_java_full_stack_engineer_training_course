function wordPlay(number){
    let string = "";
    if(number > 50){
        return "Range is High";
    }
    else if (number < 1){
        return "Not Valid";
    }

    for (let index = 1; index < number+1; index++) {
        if(index % 3 === 0 && index % 5 === 0) {
            string += " Jump";
        }
        else if (index % 3 === 0){
            string += " Tap";
        }
        else if (index % 5 === 0){
            string += " Clap";
        }
        else{
            string += " " +index.toString();
        }
    }

    return string;

}


console.log(wordPlay(16));
