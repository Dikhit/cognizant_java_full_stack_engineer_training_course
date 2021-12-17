$(document).ready(function() {
    $("#each_ex").click(function(){
        var container = [];
        $("ul li a").each(function(index, element){
            container.push(element.innerHTML);
        })

        $("ul li a").each(function(_, element){
            $(element).css("background-color", "red");
        })
        
        for (let index = 0; index < container.length; index++) {
            const element = `<span> ${container[index]} <br /> </span>`;
            $("#msg_ex").append(element);
        }
        
    })
})