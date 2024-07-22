ResizeDiv(".GameField", ".GameFightField")
$("#NewGameButton").on("click", StartGameBtnClicked)

function ResizeDiv(sourceSelector, targetSelector) {
    const width = $(sourceSelector).css("width");
    const height = $(sourceSelector).css("height");

    $(targetSelector).css("width", width);
    $(targetSelector).css("height", height);
}

function StartGameBtnClicked(event) {
    $.post("/StartGame")
        .done(function (data) {
            $(".GameField").remove();
            const element = $(".GameContainer");
            const html = element.html();
            $(".GameContainer").html(html + data);
            $("#NewGameButton").on("click", StartGameBtnClicked)
        })
        .fail(function (data) {
            console.error("Cannot proceed [POST /StartGame]", data)
        })
}