<template>
  <div>
    <Leftbar></Leftbar>
    <Topbar></Topbar>
    <Main></Main>
  </div>
</template>

<script lang="ts">

import Vue from 'vue';
import Leftbar from './leftbar.vue';
import Main from './main.vue';
import Topbar from './topbar.vue';

export default Vue.extend({
  name: 'Dashboard',
  components: {
    Leftbar,
    Topbar,
    Main,
  },
});
</script>
