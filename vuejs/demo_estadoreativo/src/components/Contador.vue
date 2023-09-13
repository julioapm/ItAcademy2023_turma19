<script setup lang="ts">
import { ref } from 'vue';

const contagem = ref(0);

function incrementarContagem() {
    contagem.value++;
}

function tratadorDoClick() {
    incrementarContagem();
}
</script>

<template>
    <div>
        <button type="button" @click="tratadorDoClick">Clique Aqui</button>
        <span>foi clicado {{ contagem }} vezes</span>
    </div>
</template>
