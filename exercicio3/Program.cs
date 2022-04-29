// See https://aka.ms/new-console-template for more information
/*Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio, 
 * para trocar entre 
* si os valores de duas variáveis A e B.

 */

Console.WriteLine("Exercicio 3: Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio, \n " + 
    "para trocar entre si os valores de duas variáveis A e B.");


Console.Write("Digite uma frase qualquer: ");
string variavel1 = Console.ReadLine();


Console.Write("Digite uma frase qualquer: ");
string variavel2 = Console.ReadLine();

Console.WriteLine("O conteudo da variavel1 é: " + variavel1);

Console.WriteLine("O conteudo da variavel2 é: " + variavel2);

Console.WriteLine("Processo de troca de valores entre duas variavéis");

string tmp = variavel1;
variavel1 = variavel2;
variavel2 = tmp;


Console.WriteLine("O conteudo da variavel1 é: " + variavel1);

Console.WriteLine("O conteudo da variavel2 é: " + variavel2);