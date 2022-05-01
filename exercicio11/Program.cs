// See https://aka.ms/new-console-template for more information
/*Escreva um algoritmo para ler o número de eleitores de um município, o número de votos brancos, nulos e válidos. Calcule e escreva o percentual que cada um 
representa em relação ao total de eleitores.
*/
Console.WriteLine("Escreva um algoritmo para ler o número de eleitores de um município, o número de votos brancos, \n" +
    " nulos e válidos. Calcule e escreva o percentual que cada um representa em relação ao total de eleitores.");

Console.Write("Digite o numero de eleitores: ");
int numeroEleitores = int.Parse(Console.ReadLine());
Console.Write("Digite os votos brancos: ");
int votosBrancos = int.Parse(Console.ReadLine());
Console.Write("Digite os votos nulos: ");
int votosNulos = int.Parse(Console.ReadLine());
Console.Write("Digite os votos validos: ");
int votosValidos = int.Parse(Console.ReadLine());

int totalBrancos = votosBrancos * 100 / numeroEleitores;
int totalNulos = votosNulos * 100 / numeroEleitores;
int totalValidos = votosValidos * 100 / numeroEleitores;

Console.WriteLine($"O percentual de votos brancos é: {totalBrancos}%");
Console.WriteLine($"O percentual de votos nulos é: {totalNulos}%");
Console.WriteLine($"O percentual de votos válidos é: {totalValidos}%");
        
    

