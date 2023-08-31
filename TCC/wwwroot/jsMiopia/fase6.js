var btn1 = document.getElementById("btn1");
var btn2 = document.getElementById("btn2");
var btn3 = document.getElementById("btn3");
var btn4 = document.getElementById("btn4");
var btn5 = document.getElementById("btn5");
var btn6 = document.getElementById("btn6");
var btncerto = "btn4";
var acertos = 0;
var total = 0;


acertos = localStorage.getItem("acertos", acertos)
console.log(acertos);

function cbuttonF6(btn) {

    if (btn == btncerto) {
        acertos++;

        acertos = localStorage.setItem("acertos", acertos)
        console.log(acertos);

    }

    else {

        console.log(acertos);
    }



}





