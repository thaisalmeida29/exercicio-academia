// See https://aka.ms/new-console-template for more information
/* 10) Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo 
para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que 
realizou o saque. Um possível critério seria o da “distribuição ótima” no sentido de que as 
notas de menor valor fossem distribuídas em número mínimo possível. 
Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria indicar uma nota de R$ 50,00, 
três notas de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00. 
Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas 
de acordo com o critério da “distribuição ótima”. */
Console.WriteLine("Exercício 10: Um programa para gerenciar os saques de um caixa eletrônico \n" +
    " deve possuir algum mecanismo para decidir o número de notas de cada valor que deve ser \n" +
    " disponibilizado para o cliente que realizou o saque.Um possível critério seria o da \n " +
    "“distribuição ótima” no sentido de que asnotas de menor valor fossem distribuídas em \n " +
    "número mínimo possível.");

int valorSaque, nota, qntd, resto;

Console.Write("Digite o valor do saque R$: ");
valorSaque =  int.Parse(Console.ReadLine());
Console.WriteLine("O saque será de: " + valorSaque);

nota = 200;

qntd = valorSaque / nota;

Console.WriteLine("A quantidade de notas de " + nota + " será de: " + qntd);
resto = valorSaque % nota;

Console.WriteLine("Faltam ainda: " + resto);

nota = 100;

qntd = valorSaque / nota;

Console.WriteLine("A quantidade de notas de " + nota + " será de: " + qntd);
resto = valorSaque % nota;

Console.WriteLine("Faltam ainda: " + resto);

nota = 50;

qntd = valorSaque / nota;

Console.WriteLine("A quantidade de notas de " + nota + " será de: " + qntd);
resto = valorSaque % nota;

Console.WriteLine("Faltam ainda: " + resto);

nota = 20;

qntd = valorSaque / nota;

Console.WriteLine("A quantidade de notas de " + nota + " será de: " + qntd);
resto = valorSaque % nota;

Console.WriteLine("Faltam ainda: " + resto);

nota = 10;

qntd = valorSaque / nota;

Console.WriteLine("A quantidade de notas de " + nota + " será de: " + qntd);
resto = valorSaque % nota;

Console.WriteLine("Faltam ainda: " + resto);

nota = 5;

qntd = valorSaque / nota;

Console.WriteLine("A quantidade de notas de " + nota + " será de: " + qntd);
resto = valorSaque % nota;

Console.WriteLine("Faltam ainda: " + resto);

nota = 2;

qntd = valorSaque / nota;

Console.WriteLine("A quantidade de notas de " + nota + " será de: " + qntd);
resto = valorSaque % nota;

Console.WriteLine("Faltam ainda: " + resto);
