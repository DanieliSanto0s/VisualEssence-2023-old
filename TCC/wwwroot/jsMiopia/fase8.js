var btn1 = document.getElementById("btn1");
var btn2 = document.getElementById("btn2");
var btn3 = document.getElementById("btn3");
var btn4 = document.getElementById("btn4");
var btn5 = document.getElementById("btn5");
var btn6 = document.getElementById("btn6");
var btncerto = "btn5";
var acertos = 0;
var total = 0;


acertos = localStorage.getItem("acertos", acertos)
console.log(acertos);



function cbuttonF8(btn) {

    if (btn == btncerto) {
        acertos++;

        acertos = localStorage.setItem("acertos", acertos)

        console.log(acertos);

    }

    else {

        console.log(acertos);
    }



}


$.ajax({
    type: "POST",
    url:"/Controller/Miopia,
})
// Get the modal
var modal = document.getElementById("myModal");

// Get the button that opens the modal
var btn = document.getElementById("myBtn");

// Get the <span> element that closes the modal
var span = document.getElementsByClassName("close")[0];

// When the user clicks on the button, open the modal
btn.onclick = function () {
    modal.style.display = "block";
}

// When the user clicks on <span> (x), close the modal
span.onclick = function () {
    modal.style.display = "none";
}

// When the user clicks anywhere outside of the modal, close it
window.onclick = function (event) {
    if (event.target == modal) {
        modal.style.display = "none";
    }
}


