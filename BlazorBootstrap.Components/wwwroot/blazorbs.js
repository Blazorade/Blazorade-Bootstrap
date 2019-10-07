

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
            var result = $(selector).carousel();
        }
    }
}