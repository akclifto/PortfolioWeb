// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
    //test script
function myfunction() {
    alert("Helloo!");
}

/* Get the name of panels to animate*/

//home page panels
var panelName = document.getElementsByClassName("panel");
prepPanel(panelName);

//education page panels
panelName = document.getElementsByClassName("edu-panel");
prepPanel(panelName);

/**
 * Iterate through panel elements by class name and add 
 * eventlistener, then animate panel.
 * @param {any} panelName : name of the class element to 
 * iterate through, selected by its name.
 */
function prepPanel(panelName) {

    for (var i = 0; i < panelName.length; i++) {
        panelName[i].addEventListener('click', animatePanel);
    }
}

/**
 * Animate panel to dropdown effect. Smooth panel with css.
 * */
function animatePanel() {

    this.classList.toggle("active");
    var content = this.nextElementSibling;
    if (content.style.maxHeight) {
        content.style.maxHeight = null;
    } else {
        content.style.maxHeight = content.scrollHeight + "px";
    }
}
