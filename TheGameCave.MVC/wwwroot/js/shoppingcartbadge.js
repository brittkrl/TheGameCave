var shoppingCartBadgeApp = new Vue({
    el: "#shoppingCartBadge",
    data: {
        quantity: 0
    }
});

shoppingCartBadgeApp.quantity = shoppingCartStore.getters.getCart.length;