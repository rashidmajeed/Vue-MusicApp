<template>
  <div class="home">
    <Navbar />
    <LandingPage />
  </div>
</template>

<script>
// @ is an alias to /src
import LandingPage from '@/components/LandingPage';
import Navbar from '@/components/Navbar';

export default {
  name: "home",
  components: {
    LandingPage,
    Navbar
  }
};
</script>
