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
        addToCart(product) {
            product.quantity = 1;
            shoppingCartStore.commit('addToCart', product);
            shoppingCartStore.commit('saveCart');
        },
        formatPrice(value) {
            var val = (value / 1).toFixed(2).replace('.', ',')
            return val.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ".")
        }
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