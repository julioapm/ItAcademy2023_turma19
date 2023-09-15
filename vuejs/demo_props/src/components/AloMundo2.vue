<script setup lang="ts">
defineProps<{nome:string}>();
</script>

<template>
    <h2>Alô, {{ nome }}!</h2>
</template>