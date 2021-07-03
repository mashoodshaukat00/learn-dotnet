<template>
  <section>
    <div id="menu">
      <router-link to="/">
        Home
      </router-link> |
      <router-link to="/cart">
        Cart
      </router-link> |
      <router-link to="/about">
        About
      </router-link>
    </div>
    <router-view />
  </section>
</template>

<style lang="scss">

#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}
#menu {
  padding: 10px;
  font-size: 12px;

  a {
    font-weight: bold;
    color: #2c3e50;
    font-size: 17px;
    margin-left: 30px;
    text-decoration: none;

    &.router-link-exact-active {
      color: rgb(31, 199, 212);
    }
    
  }
  :hover{
    text-decoration: underline;
    transition: all 0.4s ease;
    font-size: 25px;

  }
}
* {
  box-sizing: border-box;
  font-weight: normal;
  margin: 0;
  padding: 0;
}
body{
  background-color: white;
}

html {
  font-size: 10px;
}

// https://sass-lang.com/documentation/style-rules/parent-selector
.nav {
  align-items: center;
  background-color: rgb(31, 199, 212);
  color: white;
  display: flex;
  justify-content: space-between;
  padding: 1.5rem;

    &__header {
      font-size: 2.5rem;
     margin-left: 11.3%;
     cursor: pointer;
     //text-shadow: -10px 10px rgb(120, 128, 131);
  }

  &__cart {
    position: relative;
    margin-right: 11.3%;
   
    

    button {
      background: none;
      border: 0;
      color: white;
      cursor: pointer;
    }

    i {
      font-size: 2rem;
      color: rgb(23, 112, 119);
    }

    .total-quantity {
      align-items: center;
      background: red;
      border-radius: 50%;
      display: flex;
      font-weight: bold;
      height: 2rem;
      justify-content: center;
      padding: 0.5rem;
      position: absolute;
      right: -10px;
      top: -10px;
      width: 2rem;
    }

    .cart-dropdown {
      background: white;
      border: 1px solid lightgray;
      border-radius: 10px;
      box-shadow: 0 0 2px rgba(0, 0, 0, 0.2);
      color: #333;
      font-size: 1.3rem;
      overflow: auto;
      padding: 0 1rem;
      position: absolute;
      right: 0;
      width: 12rem;

      .cart-dropdown__list {
        list-style: none;

        li {
          margin: 1rem 0;
        }
      }
    }
  }
}

// https://sass-lang.com/documentation/style-rules/parent-selector
.products {
  display: flex;
  flex-wrap: wrap;
  justify-content: center;

  .product {
    border: 1px solid lightgray;
    border-radius: 10px;
    margin: 3rem;
    padding: 1rem;

    &__header {
      font-size: 1.5rem;
      text-align: center;
      
    }

    &__image {
      display: block;
      margin: 1rem auto;
      widows: 150px;
      height: 150px;
    }

    &__description {
      font-size: 1.3rem;
      margin-top: 1rem;
    }
  }
}

// https://sass-lang.com/documentation/style-rules/parent-selector
.cart {
  margin-top: 2rem;
  text-align: center;

  &__button {
    background-color: rgb(31, 199, 212);
    border: 0;
    color: white;
    cursor: pointer;
    font-size: 1.5rem;
    font-weight: bold;
    height: 2.5rem;
    width: 2.5rem;
    border-radius: 5px;
  }

  &__quantity {
    font-size: 1.5rem;
    margin: 0 1rem;
  }
}
</style>
