// See https://aka.ms/new-console-template for more information
/*
 * Um motorista de taxi deseja calcular o rendimento de seu carro na praça. Sabendo-se que o preço do combustível é de R$6,90, escreva um algoritmo para ler a 
marcação do odômetro (marcador de quilometragem) no início do dia, a marcação no final do dia, o número de litros de combustível gasto e o valor total (R$) recebido 
dos passageiros. Calcule e escreva a média do consumo em Km/l e o lucro líquido do dia.
Fórmulas: Total quilometragem =  marcação odômetro final do dia - marcação odômetro inicio do dia 
Média do consumo = Total quilometragem/ quantidade de combustível gasto
Lucro do dia = Valor total recebido - (quantidade de combustível gasto * 6,90)
 */
Console.WriteLine("Um motorista de taxi deseja calcular o rendimento de seu carro na praça. \n" + 
    "Sabendo-se que o preço do combustível é de R$6,90, \n" + 
    "escreva um algoritmo para ler a marcação do odômetro(marcador de quilometragem) no início do dia, \n" +
    " marcação no final do dia, o número de litros de combustível gasto e o valor total (R$) recebido \n" +
    "dos passageiros. Calcule e escreva a média do consumo em Km/l e o lucro líquido do dia.");

double precoGasolina = 6.90;
Console.Write("Qual a marcação do odômetro no inicio do dia? ");
double inicioDia = double.Parse(Console.ReadLine());
Console.Write("Qual a marcação do odômetro no final do dia? ");
double fimDia = double.Parse(Console.ReadLine());
Console.Write("Digite o número de combustivel gasto em litros: ");
double litrosGastos = double.Parse(Console.ReadLine());
Console.Write("Qual o valor total das corridas? R$: ");
double totalRecebido = double.Parse(Console.ReadLine());

double totalQuilometragem = fimDia - inicioDia;

double mediaConsumo = totalQuilometragem / litrosGastos;

double lucroDia = totalRecebido - (litrosGastos * precoGasolina);

Console.WriteLine("A media de combustivel gastos é: " + mediaConsumo + " e o lucro liquido do dia é: " + lucroDia);


