const shoppingCartStore = new Vuex.Store({
    state: {
        cart: []
    },
    mutations: {
        addToCart(state, item) {
            var found = state.cart.find(product => product.id == item.id);

            if (found) {
                if (found.quantity == null) {
                    found.quantity = 0;
                }

                found.quantity = parseInt(found.quantity) + parseInt(item.quantity);
            } else {
                state.cart.push(item);

                Vue.set(item, 'quantity', item.quantity);
            }

            shoppingCartBadgeApp.quantity = state.cart.length;

            $.notify({
                // options
                message: '<strong>' + item.name + '</strong> has been added to the shopping cart!'
            },
                {
                    // settings
                    type: 'success',
                    allow_dismiss: true,
                    timer: 500,
                });
        },
        saveCart(state) {
            localStorage.setItem("cart", JSON.stringify(state.cart));
        },
        removeFromCart(state, item) {
            var index = state.cart.indexOf(item);

            state.cart.splice(index, 1);
        }
    },
    getters: {
        getCart: state => {
            state.cart = JSON.parse(localStorage.getItem("cart"));
            if (state.cart == null) {
                state.cart = [];
            }

            return state.cart;
        }
    },
});

var btn = $('#goUp');

$(window).scroll(function () {
    if ($(window).scrollTop() > 300) {
        btn.addClass('show');
    } else {
        btn.removeClass('show');
    }
});

btn.on('click', function (e) {
    e.preventDefault();
    $('html, body').animate({ scrollTop: 0 }, '300');
});