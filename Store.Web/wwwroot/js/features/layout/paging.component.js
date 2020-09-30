Vue.component('paging', {
    template:
        `
            <nav>
                <ul class="pagination">
                    <li class="page-item" :class="[currentPage == 1 ? 'disabled' : '']">
                        <a class="page-link" :href="url + 'page=' + (currentPage - 1)" tabindex="-1" aria-disabled="true"><i class="mdi mdi-chevron-left"></i></a>
                    </li>
                    <li class="page-item more" v-if="start > 1">
                        <a class="page-link" href="#">...</a>
                    </li>
                    <li class="page-item" :class="[item == currentPage ? 'active' : '']" v-for="(item, index) in items">
                        <a class="page-link" :href="url + 'page=' + item">{{item}}</a>
                    </li>
                    <li class="page-item more" v-if="end < totalPage">
                        <a class="page-link" href="#">...</a>
                    </li>
                    <li class="page-item" :class="[currentPage == totalPage ? 'disabled' : '']">
                        <a class="page-link" :href="url + 'page=' + (currentPage + 1)"><i class="mdi mdi-chevron-right"></i></a>
                    </li>
                </ul>
            </nav>
        `
    ,
    props: {
        totalPage: Number,
        currentPage: Number,
        baseUrl: String
    },
    data: function () {
        return {
            items: [],
            start: 1,
            end: 99999,
        }
    },
    methods: {
        init() {
            let mid = this.currentPage;

            let pad = 4;

            let start = mid - pad;
            if (mid + pad > this.totalPage) {
                start -= mid + pad - this.totalPage;
            }

            if (start < 1) {
                start = 1
            }

            let end = mid + pad - start;
            if (end > pad) {
                end = 0
            }

            end += mid + pad;
            if (end > this.totalPage) {
                end = this.totalPage;
            }

            let items = [];
            for (let i = start; i <= end; i++) {
                items.push(i);
            }

            this.items = { ...items };

            this.start = start;
            this.end = end;
        }
    },
    computed: {
        url() {
            let url = new URL(this.baseUrl);
            let params = new URLSearchParams(url.search.slice(1));
            if (params.has('page')) {
                params.delete('page');
            }

            let result = `${location.pathname}?${params}`;
            if ([...params].length) {
                result += '&';
            }
            
            return result;
        }
    },
    watch: {
        totalPage() {
            this.init();
        }
    },
    created: function () {
        this.init();
    },
    mounted() {
    }
})