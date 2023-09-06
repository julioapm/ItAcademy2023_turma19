//Inicializador de objetos
const pessoa = {
    nome: 'John Doe',
    idade: 22
};
console.log(pessoa.nome);
console.log(pessoa.idade);
pessoa.idade = 23;
console.log(pessoa.idade);
console.log(typeof pessoa);

const outraPessoa = {
    nome: 'Mary Doe',
    idade: 25,
    saudar: function () {
        return `Olá! Meu nome é ${this.nome}`;
    }
};
console.log(outraPessoa.idade);
console.log(outraPessoa.saudar());

const maisUmaPessoa = {
    nome: 'Júlio Machado',
    idade: 25,
    saudar() {
        return `Olá! Meu nome é ${this.nome}`;
    }
};
console.log(maisUmaPessoa.saudar());

type Pessoa = {nome:string; idade:number; vivo?:boolean};
function alo(umaPessoa:Pessoa) {
    console.log(`Alô, ${umaPessoa.nome}! Você tem ${umaPessoa.idade} anos!`);
}
alo(pessoa);
alo(outraPessoa);
alo(maisUmaPessoa);

const temperatura = {
    celsius: 23,
    get fahrenheit() {
        return this.celsius * 1.8 + 32;
    }
};
console.log(temperatura.celsius);
console.log(temperatura.fahrenheit);

const outraTemperatura = Object.create(temperatura);
outraTemperatura.celsius = 13;
console.log(outraTemperatura.celsius);
console.log(outraTemperatura.fahrenheit);

//Função construtora de objetos
/*
type Carro = {modelo:string, fabricante:string, ano:number};
function Carro(this:Carro, modelo:string, fabricante:string, ano:number) {
    this.modelo = modelo;
    this.fabricante = fabricante;
    this.ano = ano;
}
const carro = new (Carro as any)('Fusca','VW',1970);
console.log(carro);
*/