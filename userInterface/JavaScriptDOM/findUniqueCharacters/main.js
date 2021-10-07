function modifyString(str){
    str = str.toLowerCase();
    str = str.replace( ' ', '');
    return str;
}


function uniqueCharacters(str){
    let result = "";
    let myDict = {};

    for (let i = 0; i < str.length; i++){
        let char = str.charAt(i);
        if (! myDict[char]){
            myDict[char] = 1
            result += char;
        }
    }

    value = modifyString(result);
    return value;
    
}  

let text = "Welcome to the Javascript course";
console.log(uniqueCharacters(text));

    
    