//Importar os módulos
import { area, circunferencia as cir } from './circulo_funcoes';
import Circ from './circulo_objeto';
import * as fs from 'node:fs';

//Usando as funções
console.log(area(3.75));
console.log(cir(4));

//Usando classe importada
const c1 = new Circ(10.5);
console.log(c1.area());
console.log(c1.circunferencia());

//Gravando um arquivo de texto
/*
const json = JSON.stringify(c1);
try {
    fs.writeFileSync('dados.json', json);
} catch (error) {
    console.error('Falha de escrita no arquivo');
    console.error((error as Error).message);
}
*/

//Leitura do arquivo de texto
try {
    const json = fs.readFileSync('dados.json', { encoding:'utf-8' });
    const circulo = JSON.parse(json);
    console.log(circulo);
} catch (error) {
    console.error('Falha de leitura do arquivo');
    console.error((error as Error).message);
}
