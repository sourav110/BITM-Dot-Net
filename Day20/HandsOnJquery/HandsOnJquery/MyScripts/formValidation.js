$('#login-form').submit(function () {
    var name = $('#name').val();
    if (name == "") {
        alert("please enter name");
        return false;
    }
    else {
        alert("your name is " + name);
    }
})