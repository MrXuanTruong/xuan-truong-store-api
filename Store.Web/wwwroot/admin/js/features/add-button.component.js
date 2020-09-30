Vue.component("add-button", {
    template:
        `
        <button type="button" v-on:click="onClick" class="btn btn-primary btn-icon-prepend btn-sm">
            <i class="fa" :class="icon"></i>
            {{text}}
        </button>
    `,
    props: {
        text: String,
        icon: String
    },
    methods: {
        onClick: function() {
            this.$emit("on-click");
        }
    },
    mounted: function () {
        
    },
});