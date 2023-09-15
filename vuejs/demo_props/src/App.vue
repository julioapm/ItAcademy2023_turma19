<script setup lang="ts">
import AloMundo from './components/AloMundo.vue';
import AloMundo2 from './components/AloMundo2.vue';
import AloMundo3 from './components/AloMundo3.vue';
import AloMundo4 from './components/AloMundo4.vue';
import { Pessoa } from './Pessoa';
import { ref } from 'vue';

const vips = ref([
    new Pessoa(1, 'John Doe', 23),
    new Pessoa(2, 'João Ninguém', 19),
    new Pessoa(3, 'Mary Doe', 20)
]);

</script>

<template>
    <!--
    <AloMundo nome="Júlio"/>
    <AloMundo />
    <AloMundo2 nome="John" />
    <p>:repeticao="2"</p>
    <AloMundo3 nome="Júlio" :repeticao="2"/>
    <p>sem repetição</p>
    <AloMundo3 nome="Teste" />
    -->
    <AloMundo4 :pessoas="vips"/>
</template>

<style scoped>
</style>
