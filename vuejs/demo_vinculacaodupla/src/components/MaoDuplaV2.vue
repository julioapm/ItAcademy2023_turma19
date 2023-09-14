<script setup lang="ts">
import { ref } from 'vue';

const valorTexto = ref('');

</script>

<template>
    <div>
        <input type="text" placeholder="Digite seu nome" v-model="valorTexto" />
        <span>{{ valorTexto }}</span>
    </div>
</template>