// register modal component
Vue.component('modal', {
    template: `#modal-template`,
    props: {
        size: String,
        show: Boolean,
        noFooter: Boolean,
    },
    data: function () {
        return {

        }
    },
    methods: {

        close: function (e) {
            this.$emit('close');
        },

        updateBody: function () {
            if ($('.modal').hasClass('show')) {
                $('body').addClass('has-modal');
            }
            else {
                $('body').removeClass('has-modal');
            }
        }
    },

    computed: {
        showFooter() {
            if (this.noFooter == undefined) {
                return true;
            }

            if (this.noFooter == true) {
                return false;
            }
            else {
                return true;
            }
        }
    },

    mounted() {
        this.updateBody();
    },

    created() {
        this.updateBody();
    },

    beforeDestroy() {
        this.updateBody();
    },
})