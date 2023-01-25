function getScreenWidth() {
    return window.innerWidth;
}

function setOnResizeEvent(dotnetHelper) {
    window.addEventListener('resize', function(){
        dotnetHelper.invokeMethodAsync('UpdatePageSize');
    });
}