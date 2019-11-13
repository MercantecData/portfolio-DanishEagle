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
  var input = document.getElementById("fname");
  input.addEventListener("keyup", function(event) {
      // Number 13 is the "Enter" key on the keyboard
      if (event.keyCode === 13) {
          document.getElementById("section").innerHTML += input.value + "<br>";
      }
  })
 }

function submitAnswer() {
    document.getElementById("section").innerHTML += commentSection() + "<br>";
} 