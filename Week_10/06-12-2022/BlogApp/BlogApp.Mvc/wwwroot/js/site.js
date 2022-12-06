function convertToShortDate(dateSting) {
    const shortDate = new Date(dateSting).toLocaleDateString('tr-Tr');
    return shortDate;
}
function convertFirstLetterToUpperCase(text) {
    text = text.toString();
    const convertedText = text.charAt(0).toUpperCase() + text.slice(1).toLowerCase();
    return convertedText;
}
