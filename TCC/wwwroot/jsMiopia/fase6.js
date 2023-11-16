
var btn1 = document.getElementById("btn1");
var btn2 = document.getElementById("btn2");
var btn3 = document.getElementById("btn3");
var btn4 = document.getElementById("btn4");

var btncerto = "btn3";

var btnNen = "btn4";

var acertos = parseInt(localStorage.getItem("acertos")) || 0;
var naoVer = parseInt(localStorage.getItem("naoVer")) || 0;
var erros = parseInt(localStorage.getItem("erros")) || 0;

function cbuttonF6(btn) {
    if (btn === btncerto) {
        acertos++;
        localStorage.setItem("acertos", acertos.toString());
    }
    else if (btn === "btn4") {
        naoVer++;
        localStorage.setItem("naoVer", naoVer.toString());
    }
    else {
        erros++;
        localStorage.setItem("erros", erros.toString());
        console.log("Erros: " + erros);
    }
}

