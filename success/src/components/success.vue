<template>
  <div class="SuccessBlock">
    <h1>Успешно!</h1>
  </div>
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
.SuccessBlock{
display: none;
}
</style>
