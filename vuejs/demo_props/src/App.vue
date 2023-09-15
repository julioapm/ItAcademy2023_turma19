<script setup lang="ts">
import AloMundo from './components/AloMundo.vue';
import AloMundo2 from './components/AloMundo2.vue';
import AloMundo3 from './components/AloMundo3.vue';
</script>

<template>
    <!--
    <AloMundo nome="Júlio"/>
    <AloMundo />
    <AloMundo2 nome="John" />
    -->
    <p>:repeticao="2"</p>
    <AloMundo3 nome="Júlio" :repeticao="2"/>
    <p>sem repetição</p>
    <AloMundo3 nome="Teste" />
</template>

<style scoped>
</style>
