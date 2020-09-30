Vue.component("group-check-box", {
    template: `
        <ul :class="className + ' group-check-box list-none-style'">
            <li class="form-group" v-if="!options.length"><i>Không có option nào!</i></li>
            <li class="form-group" v-else v-for="(option, index) in options" :key="option.Id">
                <check-box :option="option" v-on:on-changed="onItemChanged"></check-box>
                <group-check-box v-show="option.Checked" :class-name="'sub'" v-if="option.Children && option.Children.length" :options="option.Children"></group-check-box>
            </li>
        </ul>
    `,
    props: {
        options: Array,
        className: {
            type: String,
            default: ''
        },
    },
    methods: {
        onItemChanged: function (option) {
            this.$emit('on-item-changed', option);
        }
    },
    mounted: function () {
    },
});