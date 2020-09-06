// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
    //test script
function myfunction() {
    alert("Helloo!");
}

/**
 * Animated panels for Home page, slide down. This
 * expands and collapes home screen section panels on click.
 */
var panel = document.getElementsByClassName("panel");

for (var i = 0; i < panel.length; i++) {
    panel[i].addEventListener("click", function () {
        this.classList.toggle("active");
        var content = this.nextElementSibling;
        if (content.style.maxHeight) {
            content.style.maxHeight = null;
        } else {
            content.style.maxHeight = content.scrollHeight + "px";
        }
    });
}



function animatePanel(panelName) {

    var panel = document.getElementsByClassName("panel");

    panelName.classList.toggle("active");
    var content = this.nextElementSibling;
    if (content.style.maxHeight) {
        content.style.maxHeight = null;
    } else {
        content.style.maxHeight = content.scrollHeight + "px";
    }
}


