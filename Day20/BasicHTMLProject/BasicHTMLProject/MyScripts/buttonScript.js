$(document).ready(function () {
    $('#btn').click(function () {
        $('.banner').toggle(1000)
    })

    $('#btn').hover(function () {
        $('body').css("background-color", "red");
    }, function () {
        $('body').css("background-color", "white");
    })

})