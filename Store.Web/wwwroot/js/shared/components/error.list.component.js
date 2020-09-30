// Show list message errors
Vue.component('error-list', {
    template: 
        `
            <div v-if="errors && errors.length" class="alert alert-warning error" role="alert">
                <ul class="list-unstyled m-0">
                    <li v-for="error in errors">{{ error }}</li>
                </ul>
            </div>
        `
    ,
    props: {
        errors: Array,
    },
    data: function () {
        return {
            
        }
    },
})