

window.blazoradeBootstrap = {
    hide: function (elementId) {
        $("#" + elementId).addClass("d-none");
    },
    show: function (elementId) {
        $("#" + elementId).removeClass("d-none");
    },
    registerEventCallback: function (selector, eventName, callbackTarget, callbackMethodName, singleEvent, callbackParameters) {
        $(selector).on(eventName, function (params) {
            if (singleEvent) {
                $(selector).off(eventName);
            }

            if (callbackMethodName) {
                let args = {};
                if (callbackParameters && callbackParameters.length) {
                    for (var i = 0; i < callbackParameters.length; i++) {
                        args[callbackParameters[i]] = params[callbackParameters[i]];
                    }
                }

                callbackTarget.invokeMethodAsync(callbackMethodName, args);
            }
            else {
                console.warn("No callback method was specified for event callback.", selector, eventName);
            }
        });
    },

    alerts: {
        dismiss: function (selector) {
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
        carousel: function (selector, autoStart, interval) {
            var c = $(selector);


            let activeItem = c.find(".carousel-item.active");
            if (!activeItem.length) {
                c.find(".carousel-item").first().addClass("active");
            }

            let options = {
                "interval": interval,
                "ride": autoStart ? "carousel" : false
            };
            c.carousel("dispose");
            c.carousel(options);
        },
        command: function (selector, command) {
            $(selector).carousel(command);
        },
        slideCount: function (selector) {
            var c = $(selector);
            var items = c.find(".carousel-item");
            return items.length;
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
    },

    console: console
};
