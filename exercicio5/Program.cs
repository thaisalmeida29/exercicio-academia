// See https://aka.ms/new-console-template for more information
/*
 * Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel 
(medido em Km/l), sendo que são conhecidos a distância total percorrida e o volume de combustível 
consumido para percorrê-la (medido em l).
 */

Console.WriteLine("Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel \n" + 
    "(medido em Km / l), sendo que são conhecidos a distância total percorrida e o volume \n " + 
    "de combustível consumido para percorrê - la(medido em l).");


float distancia, consumo, combustivel;

Console.WriteLine("Escreva a distância percorrida pelo automovél em Km: ");
distancia = float.Parse(Console.ReadLine());


Console.WriteLine("Escreva a quantidade de combustivel: ");
combustivel = float.Parse(Console.ReadLine());

consumo = distancia / combustivel;

Console.WriteLine("O consumo medio de um automovel é " + consumo);
