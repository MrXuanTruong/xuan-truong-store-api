Vue.component("check-box", {
    template: `
        <div class="form-check form-check-flat form-check-primary">
            <label class="form-check-label">
                <input type="checkbox" class="form-check-input" v-model="option.Checked" v-on:change="onChanged">
                {{option.Text}}
                <i class="input-helper"></i>
            </label>
        </div>
    `,

    props: {
        option: Object,
    },

    methods: {
        onChanged: function (e) {
            this.$emit('on-changed', this.option);
        }
    },

    mounted: function () {

    },
});