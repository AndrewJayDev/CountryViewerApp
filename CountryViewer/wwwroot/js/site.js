//global variables...
let selectedID;
let previouslySelectedDiv;

let screenIsClear = true

//function which saves the id of country when clicked to variable selectedID

function saveID(id) {
    selectedID = id;
    console.log(id);
}
// function which toggles the display to show the desired country 

function toggleCountry() {
    //if screen is clear
    if (screenIsClear) {
        //select the ID
        var x = document.getElementById(selectedID);
        //change div of that ID to showing
        x.style.display = "block";
        //store value as previously selected div
        previouslySelectedDiv = selectedID
        //change screenclear to false
        screenIsClear = false

        //otherwise...
    } else {
        //select div currently showing on screen
        var y = document.getElementById(previouslySelectedDiv);
        //remove div from display
        y.style.display = "none";
        //select new div to show
        var x = document.getElementById(selectedID);
        //show new div
        x.style.display = "block";
        //store value as previously selected div
        previouslySelectedDiv = selectedID
        //change screenclear to false
        screenIsClear = false
    }

}


