// See https://aka.ms/new-console-template for more information
/*
 *  Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. 
A fórmula da conversão é F=(9*C+160)/5.
 */
Console.WriteLine(" Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. \n" + 
"A fórmula da conversão é F = (9 * C + 160) / 5.");

Console.Write("Escreva a temperatura em Celsius: ");
float c = float.Parse(Console.ReadLine());

float f = (9 * c + 160) / 5;

Console.WriteLine("A temperatura em Celsius convertida para Fahrenheit" + f);


