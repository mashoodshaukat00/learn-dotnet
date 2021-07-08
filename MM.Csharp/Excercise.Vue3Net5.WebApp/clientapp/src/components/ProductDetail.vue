<template>
  <!-- <section
    class="product"
  > -->
  <main class="containera">
    <div class="left-column">
      <img
        :src="productdata.image"
        :alt="productdata.name"
        class="active"
      >
    </div>
    <!-- Right Column -->
    <div class="right-column">
      <div class="product-configuration">
        <!-- Product Description -->
        <div class="product-description">
          <h1>{{ productdata.name }}</h1>
          <p style="text-transform: capitalize;">
            {{ productdata.category }}
          </p>
        </div>
        <!-- Product Color -->
        <!-- Product Color -->
        <div class="product-color">
          <span>Color</span>

          <div class="color-choose">
            <div>
              <input
                id="red"
                data-image="red"
                type="radio"
                name="color"
                value="red"
                checked
              >
              <label for="red"><span /></label>
            </div>
            <div>
              <input
                id="blue"
                data-image="blue"
                type="radio"
                name="color"
                value="blue"
              >
              <label for="blue"><span /></label>
            </div>
            <div>
              <input
                id="black"
                data-image="black"
                type="radio"
                name="color"
                value="black"
              >
              <label for="black"><span /></label>
            </div>
          </div>
        </div>
        <!-- product Configuration -->
        <div
          class="product-config"
        >
          <span>Stock: {{ productdata.stock }}</span>

          <div class="product-choose">
            <h3>
              {{ productdata.description }}
            </h3>
          </div>

          <!-- <a href="#">links?</a> -->
        </div>
      </div>

      <!-- Product Pricing -->
      <div
        class="product-price"
        style="display:inline;"
      >
        <span>${{ productdata.price }}</span>
        <a
          href="#"
          class="cart-btn"
          @click="$emit('close-product-detail', true)"
        >Back</a>
      </div>
    </div>
  </main>
  <!-- </section> -->
</template>

<script>
export default {
  name: "ProductDetail",
  props: {
    productdata: Object,
  },
  emits: ["close-product-detail"],
  created() {
    console.log(this.productdata);
  },
};

</script>
<style scoped>
/* Basic Styling */
html, body {
  height: 100%;
  width: 100%;
  margin: 0;
  font-family: 'Roboto', sans-serif;
}

.containera {
  max-width: 1200px;
  margin: 0 auto;
  padding: 15px;
  display: flex;
}

/* Columns */
.left-column {
  width: 65%;
  position: relative;
  margin-top: -40px;
}

.right-column {
  width: 35%;
  margin-top: 100px;
}


/* Left Column */
.left-column img {
  width: 65%;
  height: 80%;
  margin-left: 160px;
  /* position: absolute;
  left: 0;
  top: 136px; */
  transform: translate(-231px, 95px);
  opacity: 0;
  transition: all 0.3s ease;
}

.left-column img.active {
  opacity: 1;
}
.left-column img:hover{
  width: 75%;
  height: 90%;
  transition: all 0.3s ease;
}


/* Right Column */

/* Product Description */
.product-description {
  border-bottom: 1px solid #E1E8EE;
  margin-bottom: 20px;
}
.product-description span {
  font-size: 12px;
  color: #358ED7;
  letter-spacing: 1px;
  text-transform: uppercase;
  text-decoration: none;
}
.product-description h1 {
  font-weight: 300;
  font-size: 35px;
  color: #43484D;
  letter-spacing: -2px;
}
.product-description p {
  font-size: 16px;
  font-weight: 300;
  color: #86939E;
  line-height: 24px;
}

/* Product Configuration */
.product-color span,
.product-config span {
  font-size: 14px;
  font-weight: 400;
  color: #86939E;
  margin-bottom: 20px;
  display: inline-block;
}

/* Product Color */
.product-color {
  margin-bottom: 30px;
}

.color-choose div {
  display: inline-block;
}

.color-choose input[type="radio"] {
  display: none;
}

.color-choose input[type="radio"] + label span {
  display: inline-block;
  width: 40px;
  height: 40px;
  margin: -1px 4px 0 0;
  vertical-align: middle;
  cursor: pointer;
  border-radius: 50%;
}

.color-choose input[type="radio"] + label span {
  border: 2px solid #FFFFFF;
  box-shadow: 0 1px 3px 0 rgba(0,0,0,0.33);
}

.color-choose input[type="radio"]#red + label span {
  background-color: #C91524;
}
.color-choose input[type="radio"]#blue + label span {
  background-color: #314780;
}
.color-choose input[type="radio"]#black + label span {
  background-color: #323232;
}

.color-choose input[type="radio"]:checked + label span {
  background-image: url('/assests/check-icn.svg');
  background-repeat: no-repeat;
  background-position: center;
}

/* product Configuration */
.product-choose {
  margin-bottom: 20px;
}

.product-choose button {
  border: 2px solid #E1E8EE;
  border-radius: 6px;
  padding: 13px 20px;
  font-size: 14px;
  color: #5E6977;
  background-color: #fff;
  cursor: pointer;
  transition: all .5s;
}

.product-choose button:hover,
.product-choose button:active,
.product-choose button:focus {
  border: 2px solid #86939E;
  outline: none;
}

.product-config {
  border-bottom: 1px solid #E1E8EE;
  margin-bottom: 20px;
}

.product-config a {
  color: #358ED7;
  text-decoration: none;
  font-size: 12px;
  position: relative;
  margin: 10px 0;
  display: inline-block;
}
.product-config a:before {
  content: "?";
  height: 15px;
  width: 15px;
  border-radius: 50%;
  border: 2px solid rgba(53, 142, 215, 0.5);
  display: inline-block;
  text-align: center;
  line-height: 16px;
  opacity: 0.5;
  margin-right: 5px;
}

/* Product Price */
.product-price {
  display: flex;
  align-items: center;
}

.product-price span {
  font-size: 26px;
  font-weight: 300;
  color: #43474D;
  margin-right: 20px;
}

.cart-btn {
  display: inline-block;
   background-color: rgb(31, 199, 212);
  border-radius: 6px;
  font-size: 16px;
  color: #FFFFFF;
  text-decoration: none;
  padding: 12px 30px;
  transition: all .5s;
}
.cart-btn:hover {
  opacity: 0.6;
}

/* Responsive */
@media (max-width: 940px) {
  .container {
    flex-direction: column;
    margin-top: 60px;
  }

  .left-column,
  .right-column {
    width: 100%;
  }

  .left-column img {
    width: 300px;
    right: 0;
    top: -65px;
    left: initial;
  }
}

@media (max-width: 535px) {
  .left-column img {
    width: 220px;
    top: -85px;
  }
}
</style>
