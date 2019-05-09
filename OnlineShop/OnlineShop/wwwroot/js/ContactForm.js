$("#Message").on('keydown', function () {
    $("#messageLetterCounter").html(350-$(this).val().length)
})
