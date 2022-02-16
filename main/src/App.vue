<template>
  <div>
    <Fio lastName="Широков" firstName="Дмитрий" middleName="Романович"></Fio>
    <Vyatsu :results="results"></Vyatsu>
  </div>
</template>

<script lang="ts">
import Vue from 'vue';
import axios from 'axios';
import Fio from '../../fio/src/components/Fio.vue';
import Vyatsu from '../../vyatsu/src/components/Vyatsu.vue';

const url = 'https://new.vyatsu.ru/';

export default Vue.extend({
  name: 'App',
  components: {
    Fio,
    Vyatsu,
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
});
</script>
