<template>
  <section>
    <nav class="nav">
      <h2 class="nav__header">
        Products
      </h2>
      <div class="nav__cart">
        <button @click="showCart = !showCart">
          <i class="fas fa-shopping-cart">
            Open Cart
          </i>
        </button>
        <span class="total-quantity">{{ totalQuantity }}</span>
        <div
          v-if="showCart"
          class="cart-dropdown"
        >
          <ul class="cart-dropdown__list">
            <li
              v-for="product in cart"
              :key="product.id"
            >
              {{ product.name }} ({{ product.quantity }})
            </li>
          </ul>
        </div>
      </div>
    </nav>
    <Products
      :products="products"
      @add-product="addToCart"
      @subtract-product="subtractFromCart"
    />
  </section>
</template>

<script>
import Products from '@/components/Products.vue'
// const axios = require('axios').default;

export default {
  name: 'Home',
  components: {
    Products
  },

  data () {
    return {
      products:[],
      showCart: false
    };
  },

  computed: {
    cart () {
      return this.products.filter(product => product.quantity > 0)
    },
    totalQuantity () {
      return this.products.reduce(
        (total, product) => total + product.quantity,
        0
      )
    }
  },
       async created()
       {
        const listdata = await this.fetchProducts();
         listdata.forEach(e => {
          const data = {
            id:e.id,
            name:e.title,
            category:e.category,
            description:e.description,
            image:e.image,
            price:e.price,
            stock:Math.floor(Math.random() * 10),
            quantity:0

          };
          this.products.push(data)
        });
      },
  methods: {
    async addToCart (id) {
      for (let i = 0; i < this.products.length; i++) {
        if (this.products[i].id === id) {
          this.products[i].quantity++
          break
        }
      }
    },
    async subtractFromCart (id) {
        console.log(id)
        for (let i = 0; i < this.products.length; i++) {
          if (this.products[i].id === id) {
             this.products[i].quantity--;
             break;
          }

          }
        },
        async fetchProducts()
        {
         // const res= await fetch('https://random-data-api.com/api/coffee/random_coffee?size=6');
         const res = await fetch('https://fakestoreapi.com/products/')
          const data = await res.json();
          return data;
        },
        async fetchimage()
        {
          const res= await fetch('https://coffee.alexflipnote.dev/random.json');
          const data = await res.json();
          return data;
        }

      },
};
</script>
<style scoped>
</style>
