var btn1 = document.getElementById("btn1");
var btn2 = document.getElementById("btn2");
var btn3 = document.getElementById("btn3");
var btn4 = document.getElementById("btn4");
var btn5 = document.getElementById("btn5");
var btn6 = document.getElementById("btn6");
var btncerto = "btn4";
var acerto = 0;

function cbuttonF1(btn) {

    if (btn == btncerto) {
        acerto = "Valor Recbido";


        console.log(acerto);
        alert(acerto);

        acerto = localStorage.setItem("acerto", acerto)
    }

    else {
        alert("botaoo erradp")
    }



}

        console.log(btncerto);