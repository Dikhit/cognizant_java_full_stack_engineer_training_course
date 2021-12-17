console.log("working")

$(document).ready(function() {
    $("#form").click(function(){
       var value = 0;

        if($("#red").is(":checked")){
            value += 1;
        }
        if($("#black").is(":checked")){
            value += 1;
        }
        if($("#blue").is(":checked")){
            value += 1;
        }
        if($("#green").is(":checked")){
            value += 1;
        }
        $("#result").text(value + " boxes are checked");
    })
})