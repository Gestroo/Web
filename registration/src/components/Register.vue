<template>
  <div class="RegistrationBlock">
    <div class="inputBlock">
      <div>
        <input type="email" placeholder="Email" readonly class="regEmail input">
      </div>
       <div>
        <input type="text" placeholder="Login" class="input">
      </div>
      <div>
        <input type="password" placeholder="Password" class="input">
      </div>
      <div>
        <input type="password" placeholder="Password" class="input">
      </div>
    </div>
    <div>
      <button v-on:click="EndReg" class="toSuccess">Далее</button>
    </div>
  </div>
</template>

<script lang="ts">
export default {
  methods: {
    EndReg() {
      const emailBlock :HTMLDivElement = document.querySelector('.EmailBlock');
      const successBlock :HTMLDivElement = document.querySelector('.SuccessBlock');
      const registrationBlock :HTMLDivElement = document.querySelector('.RegistrationBlock');
      emailBlock.style.display = 'none';
      registrationBlock.style.display = 'none';
      successBlock.style.display = 'block';
    },
  },
};
</script>

<style scoped>
  .RegistrationBlock{
    margin: 0 auto;
    margin-top: 5%;
    text-align: center;
    display: none;
  }
  .input{
    margin:0.5% auto;
  }
 .toSuccess{
    margin-top : 1%;
    background-color : rgb(37, 162, 187);
    border-radius : 5px;
    color : white;
 }
</style>
