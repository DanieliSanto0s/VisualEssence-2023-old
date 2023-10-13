var btn1 = document.getElementById("btn1");
var btn2 = document.getElementById("btn2");
var btn3 = document.getElementById("btn3");
var btn4 = document.getElementById("btn4");
var btn5 = document.getElementById("btn5");
var btn6 = document.getElementById("btn6");
var btncerto = "btn3";
var acertos = 0;


acertos = localStorage.getItem("acertos", acertos)
console.log(acertos);



function cbuttonF3(btn) {

    if (btn == btncerto) {
        acertos++;

        console.log(acertos);

        acertos = localStorage.setItem("acertos", acertos)
    }

    else {

        console.log(acertos);
    }



}





