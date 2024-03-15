using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Vamos calcular quantos Litros de combustivel são nescessarios abastecer um automovel que faz 12 km/L para chegar até seu destino \n");

        Console.WriteLine("Digite o tempo necessário para viagem em horas: ");
        float timeSpent = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite a velocidade média em km/h durante a viagem: ");
        float averageSpeed = float.Parse(Console.ReadLine());

        double fuelRequired = (timeSpent * averageSpeed) / 12;
        fuelRequired = Math.Round(fuelRequired, 3);


        Console.WriteLine($"Você precisa de {fuelRequired} litros de combustivel para sua viagem de {timeSpent} horas a uma velocidade média de {averageSpeed} km/h");

    }
}