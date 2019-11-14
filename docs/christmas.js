//Set the date the countdown is for 
var countDownDate = new Date("Dec 24, 2019 18:00:00").getTime(); 

//update the countdown every second 
var countDownFunction = setInterval(function() {
    //Get todays date 
    var now = new Date().getTime();

    //the distance between now and the the countdown date 
    var distance = countDownDate - now; 

    //Calculations for days, hours, minutes & seconds 
    var days = Math.floor(distance / (1000 * 60 * 60 * 24));
    var hours = Math.floor((distance % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
    var minutes = Math.floor((distance % (1000 * 60 * 60)) / (1000 * 60));
    var seconds = Math.floor((distance % (1000 * 60)) / 1000);

    //output countdown in element on page 
    document.getElementById("countdown").innerHTML = days + "d " + hours + "h " + minutes + "m " + seconds + "s ";

    //if the countdown is over, write some text 
    if (distance < 0) {
        clearInterval(countDownFunction);
        document.getElementById("countdown").innerHTML = "CHRISTMAS HAPPENED"
    }
}, 1000);