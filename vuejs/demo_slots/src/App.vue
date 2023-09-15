<script setup lang="ts">
import BotaoColorido from './components/BotaoColorido.vue';
</script>

<template>
    <button type="button">Clique</button>
    <BotaoColorido>Clique Aqui</BotaoColorido>
    <BotaoColorido>
        <span style="color: black;">Curtir</span>💕
    </BotaoColorido>
</template>

<style scoped>
</style>
