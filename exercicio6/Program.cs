// See https://aka.ms/new-console-template for more information

/*
 * Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B, 
isto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem 
de IPI (única) a ser acrescentada. 
 */
Console.WriteLine("Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B, \n" + 
"isto é, o código, a quantidade de peças e o valor unitário \n " +
"de cada parafuso e a porcentagem IPI(única) a ser acrescentada.");


//Parafuso A

Console.WriteLine("Parafuso A");
Console.Write("Codigo do parafuso A: ");
int codigoA = int.Parse(Console.ReadLine());

Console.Write("Quantidade de peças que serão compradas: ");
int quantA = int.Parse(Console.ReadLine());

Console.Write("Valor unitario do parafuso A: ");
float valorUniA = float.Parse(Console.ReadLine());

Console.Write("Qual será a porcentagem a ser acrescentada? ");
float porcentA = float.Parse(Console.ReadLine());

float ipiA = (valorUniA * quantA) * (porcentA / 100);

float totA = (valorUniA * quantA) + ipiA;

Console.WriteLine("Parafuso A: \n " + "Codigo: " + codigoA + " \n Quantidade: " + quantA + "\n Valor Unitario: " + valorUniA + "\n IPI: " + ipiA + "\n Total: " + totA);


// Parafuso B


Console.WriteLine("Parafuso B");
Console.Write("Codigo do parafuso B: ");
int codigoB = int.Parse(Console.ReadLine());

Console.Write("Quantidade de peças que serão compradas: ");
int quantB = int.Parse(Console.ReadLine());

Console.Write("Valor unitario do parafuso B: ");
float valorUniB = float.Parse(Console.ReadLine());

Console.Write("Qual será a porcentagem a ser acrescentada? ");
float porcentB = float.Parse(Console.ReadLine());

float ipiB = (valorUniB * quantB) * (porcentB / 100);

float totB = (valorUniB * quantB) + ipiB;

Console.WriteLine("Parafuso A: \n " + "Codigo: " + codigoB + " \n Quantidade: " + quantB + "\n Valor Unitario: " + valorUniB + "\n IPI: " + ipiB + "\n Total: " + totB);


