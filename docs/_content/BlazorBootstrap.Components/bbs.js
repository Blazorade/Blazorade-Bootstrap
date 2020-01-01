

window.blazorBootstrap = {
    hide: function (elementId) {
        $("#" + elementId).addClass("d-none");
    },
    show: function (elementId) {
        $("#" + elementId).removeClass("d-none");
    },
    alerts: {
        dismiss: function(selector) {
            $(selector).alert("close");
        }
    },

    anchors: {
        init: function (anchorId) {
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
        hide: function (selector) {
            $(selector).modal("hide");
        },
        show: function (selector) {
            $(selector).modal("show");
        },
        toggle: function (selector) {
            $(selector).modal("toggle");
        }
    }
}