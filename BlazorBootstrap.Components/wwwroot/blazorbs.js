

window.blazorbs = {
    hide: function (elementId) {
        console.log("Hiding element", elementId);
        $("#" + elementId).addClass("d-none");
    },
    show: function (elementId) {
        console.log("Showing element", elementId);
        $("#" + elementId).removeClass("d-none");
    },
    alerts: {
        dismiss: function(selector, fadeOnDismiss) {
            console.log("Dismissing alert", selector, fadeOnDismiss);

            if (fadeOnDismiss) {
                $(selector).addClass("fade");
            }
            $(selector).alert("close");
        }
    },

    anchors: {
        init: function (elementId, anchorId) {
            console.log("Initializing anchor.", elementId, anchorId);
            $("#" + anchorId).attr("onclick", "return false;");
        },
        scrollIntoView: function (elementId) {
            var element = document.getElementById(elementId);
            if (element) {
                console.log("Scrolling element into view.", elementId);
                element.scrollIntoView();
                window.location.hash = elementId;
            }
            else {
                console.warn("Could not find element by id.", elementId);
            }
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