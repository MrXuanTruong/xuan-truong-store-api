Vue.prototype.$checkLogin = function () {
    var token = localStorage.getItem('admin_token');
    var token_expired = localStorage.getItem('admin_token_expired');
    if (token === undefined || token_expired === null) {
        gotoLoginPage();
    }
    else {

        let token_expired_date = moment(token_expired);
        let now = moment();

        let isValidExpired = token_expired_date.isAfter(now);
        if (isValidExpired) {
            gotoDashboadPage();
        }
        else {
            gotoLoginPage()
        }
    }
}

function gotoLoginPage() {
    if (Vue.prototype.$area === 'admin') {
        if (location.pathname.toLowerCase().includes('admin/login')) {
            Vue.prototype.$closePageLoading();
        }
        else {
            location.href = '/admin/login';
            Vue.prototype.$closePageLoading();
        }
    }
}

function gotoDashboadPage() {
    if (Vue.prototype.$area === 'admin'
        && location.pathname.includes('admin/login')
        && !location.pathname.includes('admin/login/nopermission')) {
        location.href = '/admin';
    }
    else {
        Vue.prototype.$closePageLoading();
    }
}

Vue.prototype.$checkLogin();