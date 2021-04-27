import { Modal } from "../lib/bootstrap/dist/js/bootstrap.bundle";

(function () {
    $(".RecipeImage").on("click", function (ev) {
        console.log("Clicked!");
    });
})();


(function () {
    $(".burgerMenu").on("click", function (ev) {
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

