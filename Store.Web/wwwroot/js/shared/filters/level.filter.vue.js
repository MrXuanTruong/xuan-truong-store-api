Vue.filter('level', function (value, level, format) {
    if (value !== null && value != undefined) {
        var html = '';
        for (var i = 1; i < level; i++) {
            html += format;
        }
        if (html !== '')
            html += ' ';

        html += value;
        return html;
    }
    return null;
})