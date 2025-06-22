// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function showToast(message, bgColor = "bg-success") {
    const toast = document.getElementById("toastMsg");
    const toastBody = document.getElementById("toastMessageText");

    toast.classList.remove("bg-success", "bg-danger", "bg-warning", "bg-info");
    toast.classList.add(bgColor); // Apply passed color

    toastBody.textContent = message;

    const toastInstance = new bootstrap.Toast(toast, {
        delay: 5000
    });

    toastInstance.show();
}
