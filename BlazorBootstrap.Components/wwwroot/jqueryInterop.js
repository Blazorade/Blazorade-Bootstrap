

window.blazorbs = {
    closeAlert: function (selector, fadeOnDismiss) {
        console.log("Closing alert", selector, fadeOnDismiss);

        if (fadeOnDismiss) {
            $(selector).addClass("fade");
        }
        $(selector).alert("close");
    },

    carousel: function (selector) {
        console.log("Initializing carousel.", selector);
        var result = $(selector).carousel();

    }

}