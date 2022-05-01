// See https://aka.ms/new-console-template for more information
/*
 * Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo. Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15% sobre o 
preço de custo de cada bicicleta vendida. Desenvolva um algoritmo que leia o valor do salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas 
vendidas pelo vendedor, calcule e mostre: o salário do empregado
 */
Console.WriteLine("Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo.\n " +
"Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15% sobre o \n" +
"preço de custo de cada bicicleta vendida.Desenvolva um algoritmo que leia o valor do salário \n" +
"mínimo, o preço de custo de cada bicicleta e o número de bicicletas \n" +
"vendidas pelo vendedor, calcule e mostre: o salário do empregado");


Console.Write("Qual o valor do salário minimo? ");
double salarioMinimo = double.Parse(Console.ReadLine());
Console.Write("Qual o preço de custo de cada bicicleta? ");
double precoCustoBicicleta = double.Parse(Console.ReadLine());
Console.Write("Quantas bicicletas foram vendidas por esse vendedor? ");
double quantidadeVendasBike = double.Parse(Console.ReadLine());



