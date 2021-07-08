<template>
  <!-- // <div class="container"></div>   -->
<section class="products">
    <div class="container" v-if="showproducts" >
    <div v-for="product in products" :key="product.id" class="product">
        <Product :productdata="product" 
        @add-product="$emit('add-product', $event)"
        @subtract-product ="$emit('subtract-product', $event)"
        @display-product-details="switchComponents" /> 
    </div>
    </div>
    <div v-if="!showproducts">
    <ProductDetail :productdata="selectedproduct" @close-product-detail="showproducts=$event"  />
    </div>
 
  </section>  
</template>

<script>
import Product from "@/components/Product.vue";
import ProductDetail from "@/components/ProductDetail.vue";

export default {
name:'Products',
methods:
{
switchComponents(id)
{

   this.showproducts=!this.showproducts;
   this.selectedproduct = this.products.filter(x=>x.id===id)[0];
  // console.log(this.selectedproduct);
   

}, 
},
props: {
    products : Array
},
components:{
    Product,
    ProductDetail,
    },
data() {
    return {
      showproducts: true,
      selectedproduct:{}     
    }
  },
emits:['add-product','subtract-product']
}
</script>

<style scoped>
.container {
  display: grid; 
  grid-template-columns: 1fr 1fr 1fr; 
  grid-template-rows: 1fr 1fr 1fr; 
  gap: 0px 0px; 
  grid-template-areas: 
    ". . ."
    ". . ."
    ". . ."; 
}
</style>