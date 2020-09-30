Vue.prototype.$showDeleteConfirmMessage = function () {
    return this.$showConfirmMessage('Xác nhận', "Bạn muốn xóa thông tin này?");
}