<template>
  <section>
    <h3 class="product__header">
      {{ productdata.name }}
    </h3>
    <!-- https://via.placeholder.com/150 -->
    <img
      :src="productdata.image"
      :alt="productdata.name"
      class="product__image"
      @dblclick="$emit('display-product-details', productdata.id)"
    >
    <p
      class="product__description"
      style="text-transform: capitalize;"
    >
      {{ productdata.category }}
    </p>
    <div class="cart">
      <button
        class="cart__button"
        @click="$emit('subtract-product', productdata.id)"
      >
        -
      </button>
      <span class="cart__quantity">{{ productdata.quantity }}</span>
      <button
        class="cart__button"
        @click="$emit('add-product', productdata.id)"
      >
        +
      </button>
    </div>
  </section>
</template>

<script>
export default {
  name: 'Product',
  props: {
    productdata: Object
  },
  emits: ['add-product', 'subtract-product', 'display-product-details']
}
</script>

<style scoped>
.product {
    font: lighter;
}
</style>
