

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
            if (fadeOnDismiss) {
                $(selector).addClass("fade");
            }
            $(selector).alert("close");
        }
    },

    anchors: {
        init: function (elementId, anchorId) {
            $("#" + anchorId).attr("onclick", "return false;");
        },
        scrollIntoView: function (elementId) {
            var element = document.getElementById(elementId);
            if (element) {
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
            var c = $(selector);
            var result = c.carousel();

            var id = c.attr("id");
            c.find(".carousel-control").attr("data-target", "#" + id);
        }
    },

    modals: {
        show: function (selector) {
            console.log("Showing modal.", selector);
            $(selector).modal("show");
        }
    }
}