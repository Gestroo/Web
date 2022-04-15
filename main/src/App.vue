<template>
  <div class="conteiner">
    <Email class="Email"/>
    <Registration class="Registration"/>
    <Success class="Success"/>
  </div>
</template>

<script lang="ts">
import Vue from 'vue';
import axios from 'axios';
import Email from '../../email/src/components/email-verif.vue';
import Registration from '../../registration/src/components/Register.vue';
import Success from '../../success/src/components/success.vue';

const url = 'http://localhost:8080/admission/';

export default {
  name: 'App',
  props: {
    results: [],
  },
  components: {
    Email,
    Registration,
    Success,
  },
  mounted() {
    axios
      .get(url)
      .then((response) => {
        console.log(response);
        this.results = response.data;
      })
      .catch((error: any) => console.log(error));
  },
};
</script>

<style scoped>

</style>
