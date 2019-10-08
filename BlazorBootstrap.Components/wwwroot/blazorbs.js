

window.blazorbs = {
    alerts: {
        dismiss: function(selector, fadeOnDismiss) {
            console.log("Dismissing alert", selector, fadeOnDismiss);

            if (fadeOnDismiss) {
                $(selector).addClass("fade");
            }
            $(selector).alert("close");
        }
    },

    carousels: {
        carousel: function(selector) {
            console.log("Initializing carousel.", selector);
            var c = $(selector);
            var result = c.carousel();

            var id = c.attr("id");
            c.find(".carousel-control").attr("data-target", "#" + id);
        }
    }
}