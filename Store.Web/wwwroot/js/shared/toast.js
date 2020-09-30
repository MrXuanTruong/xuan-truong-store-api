var toastPosition = 'top-center';
Vue.prototype.$showInfoToast = function (text) {
    'use strict';
    $.toast({
        heading: 'Thông báo',
        text: text,
        showHideTransition: 'slide',
        icon: 'info',
        loaderBg: '#46c35f',
        position: toastPosition
    })
}

Vue.prototype.$showSuccessToast = function (text) {
    'use strict';
    $.toast({
        heading: 'Thành công',
        text: text,
        showHideTransition: 'slide',
        icon: 'success',
        loaderBg: '#00c851',
        position: toastPosition
    })
}

Vue.prototype.$showWarningToast  = function (text) {
    'use strict';
    $.toast({
        heading: 'Thông báo',
        text: text,
        showHideTransition: 'slide',
        icon: 'warning',
        loaderBg: '#ffbb33',
        position: toastPosition
    })
}

Vue.prototype.$showDangerToast  = function (text) {
    'use strict';
    $.toast({
        heading: 'Lỗi',
        text: text,
        showHideTransition: 'slide',
        icon: 'error',
        loaderBg: '#ff4444',
        position: toastPosition
    })
}