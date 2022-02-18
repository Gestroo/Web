<template>
  <div class="form-div">
    <img class="logo_big" src="./assets/gunter.png" />
    <form class="form">
      <img class="logo" src="./assets/gunter.png" />
      <h3 class="form_title">Вход</h3>
      <div >
        <div class="mobile-login">
          <input type="text" class="form_input" placeholder="Логин" />
        </div>
        <div class="checkbox mobile-login" >
          <input type="password" class="form_input" placeholder="Пароль" />
        </div>
        <div class="desktop-login">
          <span>Логин:</span>
          <input type="text" class="form_input" />
        </div>
        <div class="checkbox desktop-login" >
          <span>Пароль:</span>
          <input type="password" class="form_input" />
        </div>
        <div class="checkbox">
          <input type="checkbox" id="input" />
          <label class="checkbox-text" for="input">Запомнить данные пользователя</label>
        </div >
        <div >
          <button class="form_btn">Войти</button>
        </div>
      </div>
    </form>
  </div>
</template>

<script lang="ts">
import Vue from 'vue';

export default Vue.extend({
  name: 'Login',
});
</script>

<style>
.form-div {
  display: flex;
}
.logo_big {
  width: 40%;
  background: #444;
}
.logo {
  display: none;
  width: 20%;
  padding-top: 10px;
}
.form {
  display: flex;
  flex-direction: column;
  width: 50%;
  margin-left: 10px;
}
.form_title {
  font-size: 1.5rem;
  font-weight: 500;
  color: #333;
}
.form_input {
  width: 90%;
  padding: 10px;
  border: solid 1px #333;
  font-size: inherit;
}
.checkbox {
  margin: 7px 0;
}
.desktop-login
{
  display: flex;
  margin:10px 0;
  flex-direction: column;
}
.mobile-login{
  display:none;
}
.form_btn {
  border: none;
  cursor: pointer;
  font-size: inherit;
  background-color: #4d565a;
  color: #fff;
  padding: 10px 50px;
}
@media (max-width: 768px) {
  .form {
    width: 100%;
    align-items: center;
  }
  .checkbox-text{
    font-size: 32px;
  }
  .form-div {
    width: 100%;
    height: 300px;
  }
  .form_btn
  {
    width: 100%;
    font-size: 32px;
    padding: 20px 100px;
  }
  .form_title {
    font-size: 48px;
  }
  .logo_big {
    display: none;
  }
  .logo {
    display: flex;
  }
  .mobile-login
  {
   display: flex;
    width: 100%;
  }
  .form_input {
    font-size: 32px;
  }
  .desktop-login
  {display: none;}
}
@media (max-width: 480px) {
  .logo {
    width: 50%;
  }
  .form-div {
     width: 100%;
  }
}
</style>
