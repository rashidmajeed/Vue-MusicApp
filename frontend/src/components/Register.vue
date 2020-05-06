<template>
  <div class="main">
    <h2>Register</h2>
    <div class="container mt-3 login-fields">
      <div class="form-group">
        <label for="username">Name</label>
        <input type="text" v-model="email" name="name" class="form-control" />
      </div>
      <div class="form-group">
        <label for="username">Email</label>
        <input type="email" v-model="email" name="email" class="form-control" />
      </div>
      <div class="form-group">
        <label for="password">Password</label>
        <input type="password" v-model="password" name="password" class="form-control" />
      </div>
      <div class="form-group">
        <button class="btn btn-block btn-outline-primary">Register</button>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "Register",
  data() {
    return {
      name: "",
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
  height: 350px;
  width: 300px;
  border: 0.6px solid gold;
  border-radius: 8px;
}

.form-group {
  margin-top: 10px;
  color: azure;
}
</style>