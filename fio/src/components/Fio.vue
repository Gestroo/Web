<template>
  <div>{{ lastName }} {{ firstName }} {{ middleName }}</div>
</template>

<script lang="ts">
import Vue from 'vue';

export default Vue.extend({
  name: 'Fio',
  props: {
    lastName: String,
    firstName: String,
    middleName: String,
  },
});
</script>

<style scoped>
div {
  text-align: center;
}
</style>
