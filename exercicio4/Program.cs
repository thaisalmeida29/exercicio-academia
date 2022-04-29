// See https://aka.ms/new-console-template for more information

/*
 *  Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA e imprima na 
forma AAAAMMDD e AAMMDD. Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.
 */

Console.WriteLine(" Exercicio 4: Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA \n " + 
    "e imprima na forma AAAAMMDD e AAMMDD.Note que o dia, \n " + "o mês e o ano devem ser lidos em variáveis diferentes.");
// solução classica e basica -> int
//int dia;
//int mes;
//int ano;

//Console.Write("Informe o dia: ");
//dia = int.Parse( Console.ReadLine() );


//Console.Write("Informe o mes: ");
//mes = int.Parse(Console.ReadLine());

//Console.Write("Informe o ano: ");
//ano = int.Parse(Console.ReadLine());

//Console.WriteLine("DD/MM/AAAA "  + dia + "/" + mes + "/" + ano);

//Console.WriteLine("AAAA/MM/DD " + ano + "/" + mes + "/" + dia);

//Console.WriteLine("AA/MM/DD " + (ano % 100) + "/" + mes + "/" + dia);

//solução usando string

string dia;
string mes;
string ano;

Console.Write("Informe o dia: ");
dia = (Console.ReadLine());


Console.Write("Informe o mes: ");
mes = (Console.ReadLine());

Console.Write("Informe o ano: ");
ano = (Console.ReadLine());

Console.WriteLine("DD/MM/AAAA " + dia + "/" + mes + "/" + ano);

Console.WriteLine("AAAA/MM/DD " + ano + "/" + mes + "/" + dia);

Console.WriteLine("AA/MM/DD " + ano[2]+ ano[3] + "/" + mes + "/" + dia);
