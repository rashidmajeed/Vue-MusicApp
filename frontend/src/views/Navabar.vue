<template>
  <div class="navbar">
    <Navbar />
  </div>
</template>

<script>
// @ is an alias to /src
import Register from "@/components/Navbar";
export default {
  name: "navbar",
  components: {
    Navbar
  }
};
</script>

<style lang="scss">
#nav {
  padding: 30px;
  a {
    font-weight: bold;
    color: #8c96a0;
    &.router-link-exact-active {
      color: #f0fcf7;
    }
  }
}
</style>
