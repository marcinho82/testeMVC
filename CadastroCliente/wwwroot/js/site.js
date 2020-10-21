// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$("#cep").on('blur', function () {

    $.getJSON("https://viacep.com.br/ws/"+ $("#cep").val() + "/json/?callback=?", function (data) {

        $("#logradouro").val(data.logradouro);
        $("#bairro").val(data.bairro);
        $("#cidade").val(data.localidade);
        $("#estado").val(data.uf);       

    });




});

