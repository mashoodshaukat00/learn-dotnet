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

    &.router-link-exact-active {
      color: #42b983;
    }
  }
}
* {
  box-sizing: border-box;
  font-weight: normal;
  margin: 0;
  padding: 0;
}

html {
  font-size: 10px;
}

// https://sass-lang.com/documentation/style-rules/parent-selector
.nav {
  align-items: center;
  background: rgb(161, 115, 236);
  color: white;
  display: flex;
  justify-content: space-between;
  padding: 2rem;

    &__header {
      font-size: 2.5rem;
  }

  &__cart {
    position: relative;

    button {
      background: none;
      border: 0;
      color: white;
      cursor: pointer;
    }

    i {
      font-size: 2rem;
    }

    .total-quantity {
      align-items: center;
      background: lightblue;
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
    margin: 2rem;
    padding: 1rem;

    &__header {
      font-size: 2rem;
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
    background: lightblue;
    border: 0;
    color: white;
    cursor: pointer;
    font-size: 1.5rem;
    font-weight: bold;
    height: 2.5rem;
    width: 2.5rem;
  }

  &__quantity {
    font-size: 1.5rem;
    margin: 0 1rem;
  }
}
</style>
