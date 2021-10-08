// $(document).ready(function() {
    $("#btnId").click(function(){
        var name = $("input:text").val();;
        $("#address").text("Welcome " + name);
    })
// })