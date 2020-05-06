<template>
  <div class="main">
    <h2>Login</h2>
    <div class="container mt-4 login-fields">
      <div class="form-group">
        <label for="username">Email</label>
        <input type="email" v-model="email" name="email" class="form-control" />
      </div>
      <div class="form-group">
        <label for="password">Password</label>
        <input type="password" v-model="password" name="password" class="form-control" />
      </div>
      <div class="form-group">
        <button class="btn btn-block btn-success">Login</button>
      </div>
      <div class="if-notmember mt-5">
        if not member
        <button
          class="btn btn-sm btn-light ml-2"
          @click="$router.push('register')"
        >Register</button>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "Login",
  data() {
    return {
      email: "",
      password: "",
      submitted: false
    };
  }
};
</script>

<style>
.main {
  margin-top: 60px;
}
.login-fields {
  margin-top: 10px;
  height: 250px;
  width: 300px;
  border: 0.6px solid gold;
  border-radius: 8px;
}
.form-group {
  margin-top: 10px;
  color: azure;
}
.if-notmember {
  margin-bottom: 0px;
}
</style>