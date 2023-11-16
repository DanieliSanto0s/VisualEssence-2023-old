var btn1 = document.getElementById("btn1");
var btn2 = document.getElementById("btn2");
var btn3 = document.getElementById("btn3");
var btn4 = document.getElementById("btn4");
var btn5 = document.getElementById("btn5");
var btn6 = document.getElementById("btn6");
var btn7 = document.getElementById("btn7");
var btn8 = document.getElementById("btn8");
var btn9 = document.getElementById("btn9");
var btn10 = document.getElementById("btn10");
var btncerto = "btn4";
var acertos = 0;
var btnNen = "btn10";
var naoVer = 0;
var erros = 0;

acertos = parseInt(localStorage.getItem("acertos")) || 0;
naoVer = parseInt(localStorage.getItem("naoVer")) || 0;
erros = parseInt(localStorage.getItem("erros")) || 0;

console.log("Acertos" + acertos);
console.log("Não vejo" + naoVer);

function cbuttonF2(btn) {
    if (btn === btncerto) {
        acertos++;
        localStorage.setItem("acertos", acertos.toString());
    } else if (btn === "btn10") {
        naoVer++;
        localStorage.setItem("naoVer", naoVer.toString());
    } else {
        erros++;
        localStorage.setItem("erros", erros.toString());
        console.log("Erros: " + erros);
    }

}