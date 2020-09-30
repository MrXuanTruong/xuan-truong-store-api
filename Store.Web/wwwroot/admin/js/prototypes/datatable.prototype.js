Vue.prototype.$getAjaxSource = function (url, method) {
    if (!method) {
        method = 'GET';
    }
    return {
        url: url,
        type: method,
        headers: { 'Authorization': "Bearer " + Vue.prototype.$getToken() },
        error: function (jqXHR, exception, errorThrown) {
            Vue.prototype.$handleRequestError(jqXHR.status);
        }
    }
}

Vue.prototype.$defaultTableSettings = {
    "processing": true,
    "serverSide": true,
    "aLengthMenu": [
        [10, 20, 50, 100],
        [10, 20, 50, 100]
    ],
    "iDisplayLength": 20,
    "language": {
        search: "",
        "processing": loadingHtml,
    },
};