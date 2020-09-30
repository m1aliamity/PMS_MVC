function NumericValue(e,value) {
    var keyCode = e.keyCode || e.which;
    var regex = /^[0-9]+$/;
    var isValid = regex.test(String.fromCharCode(keyCode));
    if (!isValid) {
        alert("Only Numeric and Comma , allowed.");
        return false
    }
    if (value.length > 10) {
        alert("Only Numeric and Comma , allowed.");
        return false;
    }
    return isValid;
}