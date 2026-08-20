window.blazoradeBootstrap = window.blazoradeBootstrap || {};

window.blazoradeBootstrap.registerEventCallback = function (selector, eventName, callbackTarget, callbackMethodName, singleEvent) {
    const element = document.querySelector(selector);
    if (!element) {
        return;
    }

    const callback = () => {
        if (singleEvent) {
            element.removeEventListener(eventName, callback);
        }

        callbackTarget.invokeMethodAsync(callbackMethodName);
    };

    element.addEventListener(eventName, callback);
};

window.blazoradeBootstrap.alerts = window.blazoradeBootstrap.alerts || {};

window.blazoradeBootstrap.alerts.dismiss = function (selector) {
    const element = document.querySelector(selector);
    if (element) {
        bootstrap.Alert.getOrCreateInstance(element).close();
    }
};

window.blazoradeBootstrap.accordions = window.blazoradeBootstrap.accordions || {};

window.blazoradeBootstrap.accordions.show = function (selector) {
    const element = document.querySelector(selector);
    if (element) {
        bootstrap.Collapse.getOrCreateInstance(element).show();
    }
};

window.blazoradeBootstrap.accordions.hide = function (selector) {
    const element = document.querySelector(selector);
    if (element) {
        bootstrap.Collapse.getOrCreateInstance(element).hide();
    }
};

window.blazoradeBootstrap.accordions.toggle = function (selector) {
    const element = document.querySelector(selector);
    if (element) {
        bootstrap.Collapse.getOrCreateInstance(element).toggle();
    }
};