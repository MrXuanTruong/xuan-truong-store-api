// register modal component
Vue.component('no-data-found', {
    template:
        `
            <div class="no-data-found text-center bg-white p-5">
                <div class="d-block text-center"><img class="" src="/themes/namthanh/images/page-not-found.gif" /></div>
                <div class="font-weight-500 font-size-18px">{{getMessage}}</div>
                <a href="/" class="btn back-home mt-4 text-uppercase font-weight-500"><i class="mdi mdi-arrow-left"></i>Trang chủ</a>
            </div>
        `
    ,
    props: {
        message: String,
    },
    data: function () {
        return {
        }
    },
    computed: {
        getMessage: () => {
            if (!this.message) {
                return "Không tìm thấy dữ liệu!";
            }

            return this.message;
        }
    },
    created: function () {
        
    }
})