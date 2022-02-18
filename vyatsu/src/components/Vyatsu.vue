<template>
  <iframe :srcdoc="data" class="frame" id="frame"></iframe>
</template>

<script lang="ts">
import { Component, Prop, Vue } from 'vue-property-decorator';
import axios from 'axios';

const url = 'http://127.0.0.1:8080/admission/';

@Component
export default class Vyatsu extends Vue {
  @Prop() private data!: [];

  mounted(): void {
    axios.get(url).then(
      (res) => {
        this.data = res.data;
      },
    );
  }
}
</script>

<style>
.frame {
  width: 100%;
  height: 500px;
  font-size: 32px;
}
</style>
