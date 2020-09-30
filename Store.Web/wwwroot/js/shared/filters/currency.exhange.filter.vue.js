Vue.filter('currencyExchange', function (value) {
    if (value == null) {
        return 0;
    }

    if (Vue.prototype.$locale == 'en') {
        let rate = Vue.prototype.$getConfiguration('ExchangeRate');
        rate = parseFloat(rate);
        let result = parseFloat(value) / rate;
        result = Math.round(result * 100) / 100;
        return result;
    }

    return value;
});