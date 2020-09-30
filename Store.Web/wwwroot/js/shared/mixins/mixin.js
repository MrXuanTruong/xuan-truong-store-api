// define a mixin object
var mixin = {
    methods: {
        showLoading: function () {
            this.loader = this.$loading.show({
                container: null,
                canCancel: false,
                color: '#f8020d',
                loader: 'spinner',
                backgroundColor: '#fff',
                opacity: 0.5,
                width: 50,
                height: 50,
            });
        },

        hideLoading: function () {
            this.loader.hide();
        },
    },
    computed: {
        isMobile: function () {
            return this.$isMobile();
        },
    },
}

Vue.mixin(mixin);