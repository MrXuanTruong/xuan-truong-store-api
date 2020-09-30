Vue.filter('currency', function (value) {
    if (value == null) {
        return '';
    }
    var valueTemp = value.toString();
    valueTemp = valueTemp.replace(/\B(?=(\d{3})+(?!\d))/g, ",");
    return valueTemp;
});