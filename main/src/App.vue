<template>
  <div>
    <Fio lastName="Широков" firstName="Дмитрий" middleName="Романович"></Fio>
    <div class="buttons">
      <button v-on:click="toggleStyleLogin" class="login-btn">Войти</button>
      <button v-on:click="toggleStyleRegister" class="register-btn">Зарегестрироваться</button>
    </div>
<Login class="login"> </Login>
<Register class="register"></Register>
<Table></Table>
  </div>
</template>

<script lang="ts">
import Vue from 'vue';
import axios from 'axios';
import Fio from '../../fio/src/components/Fio.vue';
import Login from '../../authorisation/src/Login.vue';
import Register from '../../registration/src/components/Register.vue';
import Table from '../../table/src/components/table.vue';

const url = 'http://localhost:8080/admission/';

export default Vue.extend({
  name: 'App',
  components: {
    Fio,
    Table,
    Login,
    Register,
  },
  data() {
    return { results: [] };
  },
  mounted() {
    axios
      .get(url)
      .then((response: any) => {
        console.log(response);
        this.results = response.data;
      })
      .catch((error: any) => console.log(error));
  },
  methods: {
    toggleStyleLogin() {
      const login :HTMLDivElement = document.querySelector('.login');
      const register :HTMLDivElement = document.querySelector('.register');
      login.style.display = 'flex';
      register.style.display = 'none';
    },
    toggleStyleRegister() {
      const login :HTMLDivElement = document.querySelector('.login');
      const register :HTMLDivElement = document.querySelector('.register');
      login.style.display = 'none';
      register.style.display = 'flex';
    },
  },
});
</script>

<style scoped>
.buttons {
display: flex;
justify-content: center;
width: 100%;
margin: 10px 0;
}
.login-btn {
background-color: gray;
margin-right: 10px;
padding: 10px 100px;
color: white;
}
.register-btn {
background-color: gray;
margin-left: 10px;
padding: 10px 55px;
color: white;
}
.register {
display: none;
}
@media (max-width:600px){
  .buttons {
  display: block;
  justify-content: center;
  width: 100%;
  margin: 10px 0;
  }
  .login-btn {
    background-color: gray;
    padding: 10px 100px;
    color: white;
  }
.register-btn {
background-color: gray;
padding: 10px 55px;
color: white;
}
}
</style>
