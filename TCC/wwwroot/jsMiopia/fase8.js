
var btn1 = document.getElementById("btn1");
var btn2 = document.getElementById("btn2");
var btn3 = document.getElementById("btn3");
var btn4 = document.getElementById("btn4");

var btncerto = "btn2";

var btnNen = "btn4";

var jogo = 1;

var acertos = parseInt(localStorage.getItem("acertos")) || 0;
var naoVer = parseInt(localStorage.getItem("naoVer")) || 0;
var erros = parseInt(localStorage.getItem("erros")) || 0;

function cbuttonF8(btn) {
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

console.log("Acertos" + acertos);
console.log("Não vejo" + naoVer);

$("#btn1, #btn2, #btn3, #btn4").on('click', function () {
    var acertos = localStorage.getItem("acertos");

    if (acertos >= 6) {
        window.location.href = '/Miopia/GoodResult';
    }

    else {
        window.location.href = '/Miopia/BadResult';
    }

});

jQuery(document).ready(function () {
    jQuery("#btn1, #btn2, #btn3, #btn4").click(function () {

        var acertosCont = localStorage.getItem("acertos")

        $.ajax({
            url: '/Miopia/Fase8',
            type: 'POST',
            contenttype: false,
            data: { acertos: acertosCont},
            success: function (result) {
                // Handle success
            },
            error: function (xhr, status, error) {
                // Handle error
            }
        });
    });
});
