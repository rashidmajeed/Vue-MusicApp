<template>
  <div class="navbar">
    <div id="nav">
      <router-link to="/">Home</router-link> |
      <router-link to="/about">About</router-link>
    </div>
  </div>
</template>

<script>
export default {
  name: "Navbar"
};
</script>

<style>
#nav {
  margin-left: 570px;
  margin-top: 20px;
}
</style>
