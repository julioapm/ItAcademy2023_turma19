//Classe com propriedades públicas
class Pessoa {
    nome: string;
    idade: number;
    constructor(nome:string, idade:number) {
        this.nome = nome;
        this.idade = idade;
    }
}
const p1 = new Pessoa('John Doe', 22);
const p2 = new Pessoa('Mary Doe', 25);
console.log(typeof p1);
console.log(p1);
console.log(p1.nome);

//Classe com propriedades públicas
class PessoaV2 {
    constructor(public nome:string, public idade:number){}
}
const p3 = new PessoaV2('Teste', 15);
console.log(p3);

//Classe com propriedades privadas
class PessoaV3 {
    #nome: string;
    #idade: number;
    #peso = 0;

    constructor(nome: string, idade: number) {
        this.#nome = nome;
        this.#idade = idade;
    }

    get nome() {
        return this.#nome;
    }

    get idade() {
        return this.#idade;
    }

    get peso() {
        return this.#peso;
    }

    set peso(novoPeso: number) {
        this.#peso = novoPeso;
    }

    fazAniversario() {
        this.#idade = this.#idade + 1;
    }
}
const p4 = new PessoaV3('Nova Pessoa', 26);
console.log(p4.nome);
console.log(p4.idade);
p4.peso = 45.68;
console.log(p4.peso);
p4.fazAniversario();
console.log(p4.idade);
