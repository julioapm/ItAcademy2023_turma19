<script setup lang="ts">
const nome = 'Júlio Machado';
</script>

<template>
    <h2>Alô, {{ nome }}!</h2>
    <p>
        São <time :datetime="Date()">{{ new Date().toLocaleTimeString() }}</time> horas.
    </p>
</template>