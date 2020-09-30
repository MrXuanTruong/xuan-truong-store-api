Vue.filter('friendlyUrl', function (value) {
    if (value !== null && value != undefined) {
        return friendly_url(value);
    }
    return null;
})

function friendly_url(str) {
    const a = 'àáãảạăằắẵẳặâầấẫẩậòóõỏọôồốỗổộơờớỡởợèéẽẻẹêềếễểệùúũủụưừứữửựìíĩỉịỳýỹỷỵđàáäâãåăæąçćčđďèéěėëêęğǵḧìíïîįłḿǹńňñòóöôœøṕŕřßşśšșťțùúüûǘůűūųẃẍÿýźžż·/_,:;'
    const b = 'aaaaaaaaaaaaaaaaaoooooooooooooooooeeeeeeeeeeeuuuuuuuuuuuiiiiiyyyyydaaaaaaaaacccddeeeeeeegghiiiiilmnnnnooooooprrsssssttuuuuuuuuuwxyyzzz------'
    const p = new RegExp(a.split('').join('|'), 'g')

    return str.toString().toLowerCase()
        .replace(/\s+/g, '-') // Replace spaces with -
        .replace(p, c => b.charAt(a.indexOf(c))) // Replace special characters
        .replace(/&/g, '-and-') // Replace & with 'and'
        .replace(/[^\w\-]+/g, '') // Remove all non-word characters
        .replace(/\-\-+/g, '-') // Replace multiple - with single -
        .replace(/^-+/, '') // Trim - from start of text
        .replace(/-+$/, '') // Trim - from end of text
}