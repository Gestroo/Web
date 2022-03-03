<template>
  <div>
    <Fio lastName="Широков" firstName="Дмитрий" middleName="Романович"></Fio>
    <Vyatsu :results="results"></Vyatsu>
    <Login> </Login>
    <Register></Register>
  </div>
</template>

<script lang="ts">
import Vue from 'vue';
import axios from 'axios';
import Fio from '../../fio/src/components/Fio.vue';
import Vyatsu from '../../vyatsu/src/components/Vyatsu.vue';
import Login from '../../authorisation/src/Login.vue';
import Register from '../../registration/src/components/Register.vue'

const url = 'https://new.vyatsu.ru/';

export default Vue.extend({
  name: 'App',
  components: {
    Fio,
    Vyatsu,
    Login,
    Register,
  },
  data() {
    return { results: [] };
  },
});
</script>
