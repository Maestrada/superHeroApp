window.addEventListener("load", function (ev) {

    $("body").on("click", ".bt-show-less", function (ev) {
        let $this = $(this);
        let id = $this.attr("data-id");
        $("[data-cardid=" + id + "]").hide(500);
        $(".bt-show-more[data-id=" + id + "]").show();
        $this.hide();
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

        window.open("/?search=" + hero,"_self");
      
    }
})