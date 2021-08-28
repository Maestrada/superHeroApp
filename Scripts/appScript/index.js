$("body").on("click", ".bt-show-more", function (ev) {
    let $this = $(this);
    let id = $this.attr("data-id");
    $("[data-cardid=" + id + "]").show();
});

$("body").on("click", ".bt-show-less", function (ev) {
    let $this = $(this);
    let id = $this.attr("data-id");
    $("[data-cardid=" + id + "]").hide();
});

$(".bt-clear").on("click", function (ev) {
    $(".input-search").val("");
    $(".div-search").empty();
});

$(".input-search").on("keyup", function (ev) {
    var code = (e.keyCode ? e.keyCode : e.which);
    if (code == 13) {
        searchHero();
        e.preventDefault();
    }
});

function searchHero() {
    let hero = $(".input-search").val();

    if (hero.trim() == "") {
        $(".alert-div").show();
        setTimeout(function () {
            $(".alert-div").hide();
        }, 2000);
        return;
    }

    $.ajax({})
        .done(function (data) {

        })
        .fail(function (a, b, c) {
            alert("An error was occurred, please try again later.")
        });
}