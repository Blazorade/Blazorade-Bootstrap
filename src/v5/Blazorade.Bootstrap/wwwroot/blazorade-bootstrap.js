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