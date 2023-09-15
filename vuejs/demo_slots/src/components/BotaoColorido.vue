<template>
    <button type="button" class="botao-colorido">
        <slot></slot>
    </button>
</template>

<style scoped>
.botao-colorido {
    color: white;
    background: linear-gradient(315deg, #42d392 25%, #647eff);
    border: none;
    padding: 5px 10px;
    margin: 5px;
    border-radius: 8px;
    cursor: pointer;
}
</style>