<template>
 <div class="EmailBlock">
    <input type="email" class="EmailInput" placeholder="Email">
    <div>
      <button v-on:click="ToReg" class="toRegButton" >Далее</button>
    </div>
  </div>
</template>

<script lang="ts">
export default {
  methods: {
    ToReg() {
      const emailBlock :HTMLDivElement = document.querySelector('.EmailBlock');
      const registrationBlock :HTMLDivElement = document.querySelector('.RegistrationBlock');
      emailBlock.style.display = 'none';
      registrationBlock.style.display = 'block';
      const enterEmail = (document.querySelector('.EmailInput') as HTMLInputElement).value;
      const regEmail :HTMLInputElement = document.querySelector('.regEmail');
      regEmail.value = enterEmail;
    },
  },
};
</script>

<style scoped>
 .EmailBlock{
    margin: 0 auto;
    margin-top: 5%;
    text-align: center;
  }
  .toRegButton{
    margin-top : 1%;
    background-color : rgb(37, 162, 187);
    border-radius : 5px;
    color : white;
  }
</style>
