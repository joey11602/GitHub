function showMe(character) {
    var characterType = character.getAttribute("data-character-type");
    alert(characterType + " live in the " + character.innerHTML + ".");
}