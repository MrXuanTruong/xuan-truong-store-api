var vue = new Vue({
    el: '#page-content',
    data: {
        model: vueDataJson,
        username: null,
        password: null,
        isRemember: false,
        isSubmit: false,
        operatorService: new OperatorService(),
        errors: [],
        urls: {
            dashboard: "/admin/dashboard",
        },
        errorMessages: {
            username: {
                required: "Username is requried"
            },
            password: {
                required: "Password is requried"
            }
        }
    },
    methods: {

        getUserInfo: function () {
            var self = this;
            this.operatorService.getCurrentUser()
                .then(function (res) {
                    self.operatorInfo = res.data;
                    self.$setUserInfo(res.data);
                    if (isNullOrEmpty(self.model.ReturnUrl)) {
                        location.href = self.urls.dashboard;
                    }
                    else {
                        location.href = self.model.ReturnUrl;
                    }
                })
                .catch(function (error) {
                    self.errors = ['Có lỗi trong quá trình thao tác.'];
                })
                .finally(function () {
                    self.isSubmit = false;
                });
        },

        onClickBtnLogin: function () {
            var self = this;
            this.errors = [];

            if (isNullOrEmpty(this.username)) {
                this.errors.push(this.errorMessages.username.required);
            }
            if (isNullOrEmpty(this.password)) {
                this.errors.push(this.errorMessages.password.required);
            }

            if (this.errors.length == 0) {
                self.isSubmit = true;
                var request = {
                    UserName: this.username,
                    Password: this.password,
                };

                this.operatorService.loginUser(request)
                    .then(function (response) {
                        if (response.data.result) {
                            localStorage.setItem('admin_token', response.data.accessToken);
                            localStorage.setItem('admin_token_expired', response.data.expiredDate);

                            base_axios.defaults.headers.Authorization = `Bearer ${response.data.accessToken}`;
                            self.getUserInfo();
                        }
                        else {
                            self.errors = response.data.messages;
                        }
                    })
                    .catch(function (error) {
                        console.log(error)
                        self.errors = ['Có lỗi trong quá trình thao tác.'];
                    })
                    .finally(function () {
                        self.isSubmit = false;
                    });
            }
        },
    },

    mounted() {
        
    },

    created: function () {

    }
});