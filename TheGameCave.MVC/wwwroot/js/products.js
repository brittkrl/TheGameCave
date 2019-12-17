var ApiUri = "https://localhost:5001/api/";

var app = new Vue({
    el: '#app',
    data: {
        title: 'All Games',
        search: '',
        products: null
    },
    created: function () {
        var self = this;
        self.fetchProducts();
    },
    methods: {
        fetchProducts: function () {
            self = this;
            fetch(`${ApiUri}products/basic`)
                .then(res => res.json())
                .then(function (products) {
                    self.products = products;
                })
                .catch(err => console.error('Fout: ' + err));
        },
    },
    computed: {
        filteredProducts: function () {
            if (this.search) {
                return this.products.filter((product) => {
                    return product.name.toLowerCase().match(this.search.toLowerCase())
                });
            }
            else {
                return this.products;
            }
        }
    }
});