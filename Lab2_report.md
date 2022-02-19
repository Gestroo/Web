<p align = center>МИНИСТЕРСТВО НАУКИ И ВЫСШЕГО ОБРАЗОВАНИЯ

<p align = center>РОССИЙСКОЙ ФЕДЕРАЦИИ

<p align = center>ФЕДЕРАЛЬНОЕ ГОСУДАРСТВЕННОЕ БЮДЖЕТНОЕ ОБРАЗОВАТЕЛЬНОЕ УЧРЕЖДЕНИЕ ВЫСШЕГО ОБРАЗОВАНИЯ

<p align = center>«ВЯТСКИЙ ГОСУДАРСТВЕННЫЙ УНИВЕРСИТЕТ»

<p align = center>Институт математики и информационных систем

<p align = center>Факультет автоматики и вычислительной техники

<p align = center>Кафедра систем автоматизации управления

<p align = right>Дата сдачи на проверку:

<p align = right>«___» __________ 2022 г.

<p align = right>Проверено:

<p align = right>«___» __________ 2022 г.

<p align = center>Отчет по лабораторной работе № 2

<p align = center>по дисциплине

<p align = center>«Web-программирование»

<p align = center>Вариант 1




<p align = center>Разработал студент гр. ИТб-2301-01-00 ________________ /Широков Д.Р./

<p align = center>Проверил ст. преподаватель _________________ /Земцов М.А./

<p align = center>Работа защищена с оценкой «___________» «___» __________ 2022 г.



<p align = center>Киров 2022

__________
Цель:  отобразить на странице адаптивный блок авторизации

Задачи:

1. Организовать процесс работы над лабораторной работой
1. Отобразить блок авторизации на странице

Ход выполнения:

1. Организовать процесс работы над лабораторной работой

Для работы в репозитории *[ссылка на репозиторий](https://github.com/Gestroo/Web)* на сайте github.com от ветки lab1 создана новая ветвь с названием lab2. Cоздан Vue проект c названием Authorisation. В этом проекте был добавлен компонент Login.vue.

2. Отобразить блок авторизации на странице

В ходе выполнения работы был реализован блок регистрации для компьютерной версии сайта, который содержит в себе: большой логотип, который распологается слева, название, два поля ввода для логина и пароля, checkBox для сохранения введенных данных и кнопку авторизации. Отображаемый на странице блок авторизации представлен на рисунке 1.

<p align=center><img src="./Image/lab2_desktop.png" alt="img-desk"></p>

<p align = center>Рисунок 1 – Блок регистрации для компьютерной версии сайта

Для мобильной версии сайта на странице присутствуют все те же компоненты, что и для компьютерной, но с некоторыми отличиями: маленький логотип, расположенный сверху, подсказки для полей ввода выполнены с помощью атрибута placeholder. Блок авторизации для мобильных устройств отображен на рисунке 2.


<p align=center><img src="./Image/lab2_mobile.png" alt="img-mobil"></p>

<p align = center>Рисунок 2 – Блок регистрации для мобильной версии сайта

Листинг компонента Login.vue представлен в приложении А.

Вывод: в ходе лабораторной работы организовано рабочее пространство, закреплены навыки работы с веб-фреймворком VUE. Также были освежены знания языков разметки html и css. На практике реализован адаптивный блок авторизации.

<p align = center>2

__________

<p align = center>Приложение А

<p align = center>(обязательное) 

<p align = center>Листинг компонента Login.vue

```html
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
```
<p align = center>3

<hr>

```html
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
```