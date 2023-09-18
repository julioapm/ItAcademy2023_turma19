<script setup lang="ts">
import { ref, watch } from 'vue';

const pergunta = ref('');
const resposta = ref('Perguntas devem terminar com símbolo de interrogação');

watch(pergunta, async (novaPergunta) => {
    if (novaPergunta.indexOf('?') > -1) {
        resposta.value = 'Pensando...';
        try {
            const res = await fetch('https://yesno.wtf/api');
            const json = await res.json();
            resposta.value = json.answer;
        } catch (error) {
            resposta.value = 'Erro! Não consegui acessar a API: ' + error;
        }
    }
});
</script>

<template>
    <p>
        Faça uma pergunta:
        <input v-model="pergunta" />
    </p>
    <p>{{ resposta }}</p>
</template>
