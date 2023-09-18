<script setup lang="ts">
import MeuComponente from './components/MeuComponente.vue';
import MeuComponente2 from './components/MeuComponente2.vue';
import MeuComponente3 from './components/MeuComponente3.vue';
import { ref } from 'vue';
const mensagem = ref('Nada ocorreu');
function tratadorDoEvento() {
  mensagem.value = "Evento de MeuComponente ocorreu!"
}
function tratadorDoEvento2(valor: string) {
  mensagem.value = valor;
}
</script>

<template>
  <p>{{ mensagem }}</p>
  <MeuComponente @evento="tratadorDoEvento"/>
  <MeuComponente2 @evento="tratadorDoEvento2"/>
  <MeuComponente3 @evento="tratadorDoEvento2" />
</template>

<style scoped>
</style>
