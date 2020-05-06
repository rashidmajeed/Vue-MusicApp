<template>
  <div>
    <div class="container">
      <h1 class="text-primary">{{title}}</h1>
      <div class="container mt-3 img-container">
        <img src="https://thumbs.gfycat.com/NearIllegalAmericanbobtail-size_restricted.gif" />
        <p class="text-secondary mt-4">
          {{tagline}}
          <button
            class="btn btn-md btn-outline-light ml-2"
            @click="$router.push('login')"
          >SignIn</button>
        </p>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "LandingPage",
  data() {
    return {
      title:"Engoo Music App",
      tagline:"Modern Rock Music for youth!"
    }
  }
};
</script>

<style scoped lang="scss">
.container {
  margin-top: 60px;
}
.img-container {
  margin-top: 50px;
}
img {
  height: 300px;
  width: 400px;
  border: 1px gold solid;
  border-radius: 8px;
}
</style>
