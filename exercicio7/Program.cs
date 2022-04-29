// See https://aka.ms/new-console-template for more information
/*
 *  Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário fixo, 
o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas. 
Calcule o salário total do vendedor. Escreva o número do vendedor e o salário total do vendedor.
*/
Console.WriteLine(" Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário fixo, \n" +
"o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas \n " +
"Calcule o salário total do vendedor.Escreva o número do vendedor e o salário total do vendedor.");

Console.Write("Digite o numero do vendedor: ");
int numVend = int.Parse(Console.ReadLine());

Console.Write("Salario Fixo do Vendedor: ");
float salFix = float.Parse(Console.ReadLine());

Console.Write("Total de vendas do vendedor: ");
float totVendas = float.Parse(Console.ReadLine());

Console.Write("Qual o percentual de ganho sobre o total das vendas? ");
float percent = float.Parse(Console.ReadLine());

float total = (totVendas * percent) / 100;

float totalSal = salFix + total;

Console.WriteLine(" Numero do Vendedor: " + numVend + "\n Salario Total: " + totalSal);
