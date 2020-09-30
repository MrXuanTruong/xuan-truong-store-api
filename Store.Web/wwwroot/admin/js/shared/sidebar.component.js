var vue_menus = new Vue({
    el: '#sidebar',

    data: {
        operatorInfo: null,
        avatarText: '',
        menus: [],
    },

    methods: {
        onClickBtnLogout: function () {
            localStorage.setItem('admin_token', null);
            localStorage.setItem('admin_token_expired', null);
            location.href = '/admin/login';
        },

        getUserInfo: function () {
            this.operatorInfo = this.$getUserInfo();
            if (this.operatorInfo) {
                this.avatarText = this.getAvatarText(this.operatorInfo.fullname);
                this.initMenus();
            }
            else {
                this.onClickBtnLogout();
            }
        },
        initMenus: function () {
            let menuOrigin = [];

            let bookingMenus = {
                name: 'Quản lý đơn hàng',
                subMenus: [
                    { icon: 'mdi mdi-format-list-bulleted-type', name: 'Đơn hàng', code: null, url: '/admin/booking' },
                ]
            };
            menuOrigin.push(bookingMenus);
            var systemMenus = {
                name: 'Hệ thống',
                subMenus: [
                    { icon: 'mdi mdi-account-multiple', name: 'Người dùng', code: null, url: '/admin/operator' },// PERMISSIONS.MANAGE_OPERATOR
                ]
            };
            menuOrigin.push(systemMenus);

            //var smsMenus = {
            //    name: 'SMS Marketing',
            //    subMenus: [
            //        { icon: 'mdi mdi-contacts', name: 'Contact', code: '', url: '/admin/contact' },
            //        { icon: 'mdi mdi-account-group', name: 'Nhóm', code: '', url: '/admin/contactgroup' },
            //        { icon: 'mdi mdi-page-layout-header-footer', name: 'Templates', code: '', url: '/admin/smstemplate' },
            //        { icon: 'mdi mdi-message-text', name: 'SMS', code: '', url: '/admin/smsquicksend' },
            //    ]
            //};
            //menuOrigin.push(smsMenus);

            var self = this;
            menuOrigin.forEach((menu) => {
                var menus = [];
                menu.subMenus.forEach((subMenu) => {
                    let hasPermission = self.checkPermission(subMenu.code);
                    if (hasPermission) {
                        menus.push(subMenu);
                    }
                });

                if (menus.length) {
                    menus.splice(0, 0, { icon: '', name: menu.name, code: '' });
                };

                self.menus.push(...menus);
            });
        },

        isActive: function (href) {
            let path = window.location.pathname + window.location.search;
            return path.toLowerCase() == href.toLowerCase();
        },

        checkPermission: function (permissionCode) {
            return this.$checkPermission(permissionCode);
        },

        getAvatarText: function (name) {
            name = name.trim();
            var result = '';
            var arrays = name.split(' ');

            if (arrays.length >= 2) {
                result = arrays[0][0] + arrays[arrays.length - 1][0];
            }

            if (result.length <= 1) {
                if (name.length >= 2) {
                    result = name.substring(0,2);
                }
                else {
                    result = name;
                }
            }

            return result.toUpperCase();
        }
    },

    computed: {
       
    },

    mounted() {
        
    },

    created() {
        this.getUserInfo();
    }
});