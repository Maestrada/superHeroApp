window.addEventListener("load", function (ev) {

    if ($(".input-search").val().trim()) {
        searchHero();
    }

    $("body").on("click", ".bt-show-more", function (ev) {
        let $this = $(this);
        let id = $this.attr("data-id");
        $("[data-cardid=" + id + "]").show(500);
        $(".bt-show-less[data-id=" + id + "]").show();
        $this.hide();
    });

    $("body").on("click", ".bt-show-less", function (ev) {
        let $this = $(this);
        let id = $this.attr("data-id");
        $("[data-cardid=" + id + "]").hide(500);
        $(".bt-show-more[data-id=" + id + "]").show();
        $this.hide();
    });

    $(".bt-clear").on("click", function (ev) {
        $(".input-search").val("");
        $(".div-search").empty();
    });

    $(".input-search").on("keyup", function (e) {
        var code = (e.keyCode ? e.keyCode : e.which);
        if (code == 13) {
            searchHero();
            e.preventDefault();
        }
    });

    $(".bt-search").on("click", function (ev) {
        searchHero();
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

        $(".div-search").empty()
        $(".div-search").addClass("loading loading--full-height");

        $.ajax({
            type: "Post",
            url: "Home/SearchHero",
            data: { 'search': hero },
            contentType: "application/x-www-form-urlencoded;charset=utf-8",
        })
            .always(function (a, b, c) {
                $(".div-search").removeClass("loading loading--full-height");
            })
            .done(function (data) {
                $(".div-search").html(data);
                setTimeout(function (ev) {                   
                    // Activate tooltips
                    $('[data-toggle="tooltip"]').tooltip();
                }, 500);
            })
            .fail(function (a, b, c) {
                alert("An error was occurred, please try again later.")
            });
    }
})