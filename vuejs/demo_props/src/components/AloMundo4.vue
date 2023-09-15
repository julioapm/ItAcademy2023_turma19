<script setup lang="ts">
import { Pessoa } from '../Pessoa';
defineProps<{ pessoas: Pessoa[] }>();
</script>

<template>
    <ul>
        <li v-for="p in pessoas" :key="p.id">Alô, {{ p.nome }}!</li>
    </ul>
</template>