<script setup lang="ts">
    function tratadorDoClick(evento: Event) {
        alert('Alô, Mundo!');
    }
    function tratadorDoClick2(evento: Event) {
        const botaoClicado = evento.currentTarget as HTMLButtonElement;
        alert(`Oi, ${botaoClicado.name}!`);
    }
</script>

<template>
    <button type="button" @click="tratadorDoClick">Diga Alô</button>
    <button type="button" name="botaoOi" @click="tratadorDoClick2">Diga Oi</button>
</template>
