console.log("Working!!")

$(document).ready(function(){
    var customerContainer = []
    let i = 0;
    $(".add-row").click(function(){
        var element = $("#name").val();
        customerContainer.push(element);

        for (let index = i; index < customerContainer.length; index++) {
            var id = index + "tr";
            var tr = `<tr id=${id}> <td> <input type="checkbox" name="record" id=${index}> </td> <td> ${customerContainer[index]} </td> </tr>`;
            $("form table tbody").append(tr);         
        }
        i += 1;
    })


    $(".delete-row").click(function(){
        for (let index = 0; index < customerContainer.length; index++) {
            if( $("#" + index).is(":checked") ){
                $("#" + index + "tr").remove();
            }            
        }
    })
})