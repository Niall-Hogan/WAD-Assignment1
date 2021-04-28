(function () {
    $(".burgerMenu").on("click", (ev) => {
        ev.preventDefault();
        $(this).toggleClass("animateBurger");
        $("nav").slideToggle("fast");
    });


    $(window).on("resize", function (ev) {

        if (window.innerWidth > 720) {
            $("nav").show();
        }
        if (window.innerWidth < 720) {
            $("nav").hide();
        }
    });

   
})();

