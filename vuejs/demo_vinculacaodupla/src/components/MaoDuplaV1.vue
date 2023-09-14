<script setup lang="ts">
import { ref } from 'vue';

const valorTexto = ref('');

function tratadorDoInput(evento: Event) {
    const caixaDeTexto = evento.currentTarget as HTMLInputElement;
    valorTexto.value = caixaDeTexto.value;
}
</script>

<template>
    <div>
        <input type="text" placeholder="Digite seu nome"
            @input="tratadorDoInput" :value="valorTexto"
        />
        <span>{{ valorTexto }}</span>
    </div>
</template>