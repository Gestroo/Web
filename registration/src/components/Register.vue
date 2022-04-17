<template>
  <div class="form-div">
    <img class="logo_big" src="../assets/gunter.png" />
    <form class="form">
      <img class="logo" src="../assets/gunter.png" />
      <h3 class="form_title">Регистрация</h3>
      <div >
        <div class="mobile-login">
          <input type="text" class="form_input" placeholder="Логин" />
        </div>
        <div class="checkbox mobile-login" >
          <input type="password" class="form_input" placeholder="Пароль" />
        </div>
        <div class="checkbox mobile-login" >
          <input type="password" class="form_input" placeholder="Повторите пароль" />
        </div>
        <div class="desktop-login">
          <span>Логин:</span>
          <input type="text" class="form_input" id="login" />
        </div>
        <div class="checkbox desktop-login" >
          <span>Пароль:</span>
          <input type="password" class="form_input" id="pass1" />
        </div>
        <div class="checkbox desktop-login" >
          <span>Повторите пароль:</span>
          <input type="password" class="form_input" id="pass2" />
        </div>
        <div >
          <button type="button" v-on:click="signOn" class="form_btn">Зарегистрироваться</button>
        </div>
      </div>
    </form>
  </div>
</template>

<script lang="ts">
import axios from 'axios';

export default ({
  methods: {
    signOn() {
      const log :HTMLInputElement = document.getElementById('login') as HTMLInputElement;
      const pass1 :HTMLInputElement = document.getElementById('pass1') as HTMLInputElement;
      const pass2 :HTMLInputElement = document.getElementById('pass2') as HTMLInputElement;
      const config = {
        url: 'api/auth/check',
      };
      const data = {
        login: log.value,
      };
      if (log.value === '') {
        alert('Введите логин!');
        return;
      }
      if (pass1.value === '') {
        alert('Введите пароль!');
        return;
      }
      if (pass1.value !== pass2.value) {
        alert('Пароли не совпадают!');
        return;
      }
      axios.post(config.url, data)
        .then((response) => {
          console.log(response.data.IsValid);
          if (!response.data.IsValid) {
            alert('Логин занят!');
          } else { alert('Успешно!'); }
        })
        .catch((error) => {
          console.log(error);
        });
    },
  },
});
</script>

<style>
.form-div {
  margin-top:100px;
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
