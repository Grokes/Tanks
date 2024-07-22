ResizeDiv(".GameField", ".GameFightField")


function ResizeDiv(sourceSelector, targetSelector) {
    const width = $(sourceSelector).css("width");
    const height = $(sourceSelector).css("height");

    $(targetSelector).css("width", width);
    $(targetSelector).css("height", height);
}