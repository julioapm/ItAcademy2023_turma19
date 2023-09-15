<script setup lang="ts">
interface Props {
    nome: string,
    repeticao?: number
}
withDefaults(defineProps<Props>(), { repeticao: 1 });
</script>

<template>
    <h2 v-for="n in repeticao">Alô, {{ nome }}!</h2>
</template>
