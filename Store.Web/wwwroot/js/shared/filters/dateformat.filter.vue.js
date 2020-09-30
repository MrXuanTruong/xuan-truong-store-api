Vue.filter('dateago', function (date) {
    var localDate = moment.utc(date).local();
    var now = moment();

    const diff = now.diff(localDate);
    const diffDuration = moment.duration(diff);

    var value = '';
    if (diffDuration.days() > 0) {
        value += diffDuration.days() + (diffDuration.days() > 1? " days " : " day ");
    }

    if (diffDuration.hours() > 0) {
        value += diffDuration.hours() + (diffDuration.hours() > 1 ? " hours " : " hour ");
    }

    if (diffDuration.days() == 0) {
        if (diffDuration.hours() > 0) {
            value += diffDuration.minutes() + (diffDuration.minutes() > 1 ? " minutes " : " minute ");
        }
        else if (diffDuration.minutes() > 10) {
            value += diffDuration.minutes() + " minutes ";
        }
        else {
            value += "a few ";
        }
    }

    value += "ago";

    return value;
})

Vue.filter('formatDate', function (date) {
    var localDate = moment.utc(date).local();
    return moment(localDate).format('DD/MM/YYYY HH:mm');
})

Vue.filter('formatDateYYYYMMDDHHmma', function (date) {
    var localDate = moment.utc(date).local();
    return moment(localDate).format('DD-MM-YYYY HH:mm a');
})

Vue.filter('formatDatePost', function (date) {
    var localDate = moment.utc(date).local();
    return moment(localDate).format('MMM D YYYY @ h:mm');
})

Vue.filter('formatDateDDMMYY', function (date) {
    if (date) {
        var localDate = moment.utc(date).local();
        return moment(localDate).format('DD/MM/YYYY');
    }
    else {
        return '';
    }
})

Vue.filter('formatDateMMMDDYY', function (date) {
    var localDate = moment.utc(date).local();
    return moment(localDate).format('MMM DD, YYYY');
});

Vue.filter('formatDateCustom', function (date, format) {
    var localDate = moment.utc(date).local();
    return moment(localDate).format(format);
});

const dayOfWeeks = ['Chủ nhật', 'Thứ 2', 'Thứ 3', 'Thứ 4', 'Thứ 5', 'Thứ 6', 'Thứ bảy'];

Vue.filter('formatDateCustomVi', function (date) {
    var localDate = moment.utc(date).local();
    return `${dayOfWeeks[localDate.days()]}, ${localDate.date()} tháng ${localDate.format('M')}, ${localDate.year()}`;
})

