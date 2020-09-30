Vue.component('hollow-dots-spinner', {
    template:
        `
            <div class="hollow-dots-spinner" :style="spinnerStyle">
                <div class="dot"></div>
                <div class="dot"></div>
                <div class="dot"></div>
            </div>
        `
    ,
    props: {
        spinnerStyle: String,
    },
    data: function () {
        return {
            // No data
        }
    },

    methods: {
    },

    computed: {
    },

    mounted: function () {
    }
})