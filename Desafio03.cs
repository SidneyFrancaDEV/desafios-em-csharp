using System;

class Program
{
   static void Main()
    {

        Console.WriteLine("Este programa vai te mostrar os numeros da sequencia de Fibonnaci. Digite a quantidade de numeros para a sequência:");

        int fstN = 0;
        
        int sndN = 1;

        int UserRequest = int.Parse(Console.ReadLine());

        for (int i = 0; i < UserRequest; i++)
        {
            Console.Write($" {fstN}");
            sndN = fstN + sndN;
            fstN = sndN - fstN;
        }

    }
}