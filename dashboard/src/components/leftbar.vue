<template>
  <div class="leftbar-div dark" id="app">
    <div class="left-menu dark">
      <img src="../assets/logo.svg" class="logo" alt="">
      <div class="buttons">
        <button class="dark left-button">
          <img src="../assets/home.svg" class="dark" alt="">
        </button>
        <button class="dark left-button">
          <img src="../assets/news.svg" class="dark" alt="">
        </button>
        <button class="dark left-button">
          <img src="../assets/people.svg" class="dark" alt="">
        </button>
        <button class="dark left-button">
          <img src="../assets/mail.svg" class="dark" alt="">
        </button>
        <button class="dark left-button">
          <img src="../assets/play.svg" class="dark" alt="">
        </button>
        <button class="dark left-button">
          <img src="../assets/stats.svg" class="dark" alt="">
        </button>
        <button class="dark left-button">
          <img src="../assets/settings.svg" class="dark" alt="">
        </button>
      </div>
    </div>
  </div>
</template>

<script lang="ts">
import Vue from 'vue';

export default Vue.extend({
  name: 'Leftbar',
});
</script>

<style scoped>
.leftbar-div {
  position: fixed;
  display:block;
width: 5%;
height: 100%;
border: 1px;
border-right-style: solid;
border-color:grey;
  }
.left-menu{
  margin: auto;
  display:flex;
  flex-direction:column;
align-items: center;
}
.buttons{
 margin: 170px auto;
  display:flex;
  flex-direction:column;
align-items: center;
  columns: 1;

}
.logo{
  width:40px;
  height:40px;
  margin-top: 18px;
  transform: scale(-1, -1);
}
.left-button{
  margin: 20px 0;
  width:40px;
  height:40px;
  border: none;
  cursor: pointer;
}
.dark{
background-color: #282c31 ;
color: #282c31;
}
@media (max-width:768px){
  .leftbar-div{
      position: fixed;
    display:block;
width: 9%;
height:100%;
}
  .logo{
 width:30px;
  height:30px;
}
  }

</style>
