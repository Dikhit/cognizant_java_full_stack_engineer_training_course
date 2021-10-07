function display(){
    let name = document.getElementById("sname").value;
    let course = document.getElementById("course").value;
    if (name.length  === 0){
        console.log(name, course, name.length);
        document.getElementById("greet").innerHTML = "Name cannot be empty";
    }
    else{
        let greetingMsg = `Hi, ${name}. You have successfully registered for the ${course} course`;
        document.getElementById("greet").innerHTML = greetingMsg;
    }
}