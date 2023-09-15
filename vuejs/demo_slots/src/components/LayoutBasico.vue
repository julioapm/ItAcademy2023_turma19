<template>
    <header>
        <slot name="cabecalho"></slot>
    </header>
    <main>
        <slot></slot>
    </main>
    <footer>
        <slot name="rodape"></slot>
    </footer>
</template>

<style scoped>
    footer {
        border-top: 3px solid #ccc;
        color: grey;
        font-size: 0.8em;
    }
</style>