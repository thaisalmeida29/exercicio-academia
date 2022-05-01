// See https://aka.ms/new-console-template for more information
/*
 *Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer. 
 */
Console.WriteLine("Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer.");


Console.Write("Digite um número: ");
double numero1 = double.Parse(Console.ReadLine());
Console.Write("Digite outro número: ");
double numero2 = double.Parse(Console.ReadLine());  

double mediaAritmetica = (numero1 + numero2) / 2;

Console.Write("A média aritmética entre os dois números é: " + mediaAritmetica);