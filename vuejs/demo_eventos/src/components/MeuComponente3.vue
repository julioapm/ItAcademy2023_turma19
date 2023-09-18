<script setup lang="ts">
const emit = defineEmits<{evento:[valor:string]}>();
</script>

<template>
    <h2>MeuComponente3</h2>
    <button type="button" @click="emit('evento', 'MeuComponente diz alô!')">Dispare Evento</button>
</template>