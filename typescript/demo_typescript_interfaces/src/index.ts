interface Colorido {
    cor: string;
}

interface Circular {
    raio: number;
}

interface CircularColorido extends Colorido, Circular {}

class CirculoColorido implements CircularColorido {
    constructor(public raio: number, public cor: string) {}
    area() {
        return Math.PI * this.raio**2;
    }
}

const obj = {
    nome: 'Caneta',
    cor: 'Azul'
};

function imprimir(coisa: Colorido) {
    console.log(coisa.cor);
}

imprimir(obj);
const c = new CirculoColorido(10, 'Vermelha');
imprimir(c);
