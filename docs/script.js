//Changing the text on the button between text and date & time 
function buttonClick() {
    var x = document.getElementById('button');
    if (x.innerHTML === "Click me for Date and Time!") {
        x.innerHTML = Date();
    } else {
        x.innerHTML = "Click me for Date and Time!"
    }
}

//Changing the button text between quotes from Daybreak 
function changeText() {
    var x = document.getElementById("button2");
    if (x.innerHTML === "The sunflower is food and medicine.") {
      x.innerHTML = "The sunflower is also a hyperaccumulator, which means it can remove radiation and heavy metals from contaminated soil.";
    } else {
      x.innerHTML = "The sunflower is food and medicine.";
    }
  } 

function addElement() {
      //creates new p element 
    var para = document.createElement("p");
      //code creates text node
    var node = document.createTextNode("Here is the newly added element done with JS");
      //appending the text node to the p element 
    para.appendChild(node);

      //finds existing element
    var element = document.getElementById("objectAdd");
      //appends new element to existing element
    element.appendChild(para);
  } 

function removeElement() {
      var elmnt = document.getElementById("para1");
      elmnt.remove();
  }

function commentSection() {  
  var firstname = document.getElementById("fname").value;
  var lastname = document.getElementById("lname").value;
  var comment = document.getElementById("comment").value;
  var answer = "Name: " + firstname + " " + lastname + "<br>" + " " + "Comment: " + comment;
  document.getElementById("section").innerHTML += answer + "<br>";   
  }