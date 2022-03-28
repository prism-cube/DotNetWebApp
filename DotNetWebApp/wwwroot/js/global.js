document.addEventListener("DOMContentLoaded", function () {
    let errorInputs = document.querySelectorAll('.input-validation-error');
    errorInputs.forEach(function (e) {
        // 入力チャックエラーのinputにBootStrap用のclassを付与
        e.classList.add('is-invalid');
    });
});
