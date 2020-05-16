$(document).ready(function () {
    $("#resultado").toggle();

    $("form").submit(function (event) {
        let formValido = validarFormulario();

        if (formValido === false) {            
            $("#txtPalavra").focus();
        }
        else {
            let palavraDigitada = $("#txtPalavra").val();
            $.post('/Resultado/', { palavra: palavraDigitada },
                function (data) {
                    $("h6").text(data);
                    $("#resultado").toggle(true);
                }
            );
        }

        event.preventDefault();
        event.stopPropagation();
    })
});

function validarFormulario() {
    let padrao = /[^A-Za-z]/g;
    let ehValido = true;

    if ($("#txtPalavra").val() === "") {
        $("#msgValidacao").text("Favor informar um palavra.");
        ehValido = false;
    }

    if (padrao.exec($("#txtPalavra").val()) !== null) {
        $("#msgValidacao").text("O campo palavra aceita somente letras.");
        ehValido = false;
    }

    if (ehValido) {
        $("#msgValidacao").toggle(false);
    }
    else {
        $("#msgValidacao").toggle(true);
        $("#resultado").toggle(false);
    }

    return ehValido;
}