<template>
  <div class="overview">
    <div class="container">
      <div class="row">
        <div class="col-md-5">
          <div class="overview-content">
            <h1 class="overview-title mt-3">Engoo Music App</h1>
            <p class="desc mt-2">Engoo is a music app, worlds best audio track app where listeners can get their favourite songs of various brands. It is high quality audio streaming app.</p>
            <div class="overview-btn mt-5">
              <button 
              class="btn custom-btn btn-info mr-4"
              @click="$router.push('login')"
              >
              Explore Music
              </button>
            </div>
          </div>
        </div>
        <div class="col-md-7">
          <div class="graphic">
            <img src="@/assets/img/music.svg" alt />
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "Overview"
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped lang="scss">
.overview {
  padding-top: 7rem;
  text-align: left;
}
.container{
  padding:40px;
  width: 800px;
  height: auto;
  border: 2px rgb(185, 185, 184) solid;
  border-radius: 8px;
  background-color:rgb(155, 85, 85);
}
img {
  height:350px;
  width: 350px;
}
</style>