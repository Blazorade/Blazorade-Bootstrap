

window.blazorbs = {
    closeAlert: function (selector, fadeOnDismiss) {
        if (fadeOnDismiss) {
            $(selector).addClass("fade");
        }
        $(selector).alert("close");
    }
}