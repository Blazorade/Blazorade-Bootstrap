

window.blazorBootstrap = {
    hide: function (elementId) {
        $("#" + elementId).addClass("d-none");
    },
    show: function (elementId) {
        $("#" + elementId).removeClass("d-none");
    },
    registerEventCallback: function (selector, eventName, callbackTarget, callbackMethodName, singleEvent) {
        $(selector).on(eventName, function () {
            if (singleEvent) {
                $(selector).off(eventName);
            }

            if (callbackMethodName) {
                callbackTarget.invokeMethodAsync(callbackMethodName);
            }
            else {
                console.warn("No callback method was specified for event callback.", selector, eventName);
            }
        });
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

    collapses: {
        hide: function (selector) {
            $(selector).collapse("hide");
        },
        show: function (selector) {
            $(selector).collapse("show");
        },
        toggle: function (selector) {
            $(selector).collapse("toggle");
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
    },

    toasts: {
        init: function (selector, autoHide, delay) {
            $(selector).toast({
                animation: true,
                autohide: autoHide,
                delay: delay
            });
        },
        hide: function (selector) {
            $(selector).toast("hide");
        },
        show: function (selector) {
            $(selector).toast("show");
        }
    }
}