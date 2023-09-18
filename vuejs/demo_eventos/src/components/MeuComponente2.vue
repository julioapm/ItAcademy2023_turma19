<script setup lang="ts">
const emit = defineEmits(['evento']);
</script>

<template>
    <h2>MeuComponente2</h2>
    <button type="button" @click="emit('evento', 'MeuComponente diz alô!')">Dispare Evento</button>
</template>