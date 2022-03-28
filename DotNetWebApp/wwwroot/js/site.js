// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(function () {
    $('.toast').toast({ animation: true, autohide: true, delay: 3000 });

    $(".toast").toast("show");

    $("#showToastBtn").on("click", function () {
        $(".toast").toast("show");
    });
});