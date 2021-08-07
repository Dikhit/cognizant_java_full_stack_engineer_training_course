// let feedbackContainer = [];
// let isDone = false;

// function addFeedback(){
//     const feedback = document.getElementById("feedback").value;
//     feedbackContainer.push(feedback);
//     document.getElementById("feedback").value = ""

//     if (!isDone) {
//         isDone = true;
//         const result = document.getElementById("result")
//         result.style.border = "5px solid #000000";
//         const heading_data = document.createElement("h1");
//         heading_data.innerHTML = "Feedback Details";
//         result.appendChild(heading_data);

//         const details = document.createElement("b");
//         details.innerHTML = "Successfully Added Feedback Details!";
//         result.appendChild(details);
//     }
// }

// function displayFeedback(){
//     const result = document.getElementById("result")
//     result.innerHTML = ""
//     result.style.border = "5px solid #000000";
//     result.style.width = "50%"
//     const heading_data = document.createElement("h1");
//     heading_data.innerHTML = "Feedback Details";
//     result.appendChild(heading_data);
//     feedbackContainer.map(( element, index) => {
//         const feedbackNum = document.createElement("p");
//         index += 1
//         feedbackNum.innerHTML = "Feedback " + index;
//         result.appendChild(feedbackNum);
//         const text = document.createElement('p');
//         text.innerHTML = element;
        
//         result.appendChild(text);
//     })
// }


var j=[];
var k='';
function addFeedback(){
j[j.length]=document.getElementById("feedback").value;
document.getElementById("feedback").value="";
document.getElementById("result").innerHTML="<h1>Feedback Details</h1><br><b>Successfully Added Feedback Details!</b>";
  
}

function displayFeedback(){

for(var i=0;i<j.length;i++){
    var a = i+1
    k=k+"Feedback "+a +"<br>"+j[i]+"<br>";
}    
document.getElementById("result").innerHTML="<h2>Feedback Details</h2>"+k ;
}