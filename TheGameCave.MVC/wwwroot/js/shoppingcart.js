$(function () {
    var cart = shoppingCartStore.getters.getCart;

    var shoppingCartApp = new Vue({
        el: "#shoppingCartApp",
        data: {
            cart: cart,
        },
        methods: {
            totalPrice: function () {
                var totalPrice = 0;
                for (var index = 0; index < cart.length; index++) {
                    if (cart[index].onSale) {
                        totalPrice += (cart[index].price - 10) * cart[index].quantity;
                    }
                    else {
                        totalPrice += cart[index].price * cart[index].quantity;
                    }
                }

                return totalPrice;
            },
            formatPrice(value) {
                var val = (value / 1).toFixed(2).replace('.', ',')
                return val.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ".")
            },
            removeFromCart(item) {
                shoppingCartStore.commit('removeFromCart', item);
                shoppingCartStore.commit('saveCart');
            },
            refreshCart() {
                shoppingCartStore.commit('saveCart');
            }
        }
    });
    shoppingCartApp.totalPrice = totalPrice;
});