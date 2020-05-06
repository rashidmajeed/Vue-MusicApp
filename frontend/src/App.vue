<template>
  <div id="app">
    <router-view />
  </div>
</template>

<style lang="scss">
@import url('https://fonts.googleapis.com/css2?family=Fjalla+One&family=Open+Sans:wght@300&display=swap');
#app {
  font-family: "Avenir", Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
}
// colors
$primary: #4acf55;
$secondary:#e7681f;
$body-bg: #2a2d33;
$text-body: rgb(255, 255, 255);
$body-color: $text-body;
$border-radius: 8px;

//overrides
$font-family-headlines: "Fjalla One", -apple-system, BlinkMacSystemFont,
  "Segoe UI", "Roboto", "Helvetica Neue", Arial, sans-serif, "Apple Color Emoji",
  "Segoe UI Emoji", "Segoe UI Symbol";
$font-family-base: "Open Sans", -apple-system, BlinkMacSystemFont, "Segoe UI",
  "Roboto", "Helvetica Neue", Arial, sans-serif, "Apple Color Emoji",
  "Segoe UI Emoji", "Segoe UI Symbol";
$headings-font-family: $font-family-headlines;
$headings-font-weight: 400;
$line-height-base: 1.4;

@import "node_modules/bootstrap/scss/bootstrap";

</style>
