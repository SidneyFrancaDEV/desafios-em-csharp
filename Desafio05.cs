using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafios_csharp.Desafios
{
    class Desafio05 {
        public static string Desafio05() {
            int[,] matriz = new int[11, 11];
            int value = 0;
        
            for (int i = 0; i < matriz.GetLength(0); i++) {
                for (int j = 0; j < matriz.GetLength(1); j++) {
                matriz[i, j] = value;
                value++;
                }
            }
        
            Console.WriteLine("Digite a linha que você deseja somar ou fazer a média: ");
            int line = int.Parse(Console.ReadLine());
        
            Console.WriteLine("Digite 's' para somar ou 'm' para fazer a média: ");
            char option = char.Parse(Console.ReadLine());
        
            int sum = 0;
        
            for (int i = 0; i < matriz.GetLength(1); i++) {
                sum += matriz[line, i];
            }
        
            if (option == 's') {
                string message = $"A sum da linha {line} é: {sum}";
                return message;
            } else {
                string message = $"A média da linha {line} é: {sum / matriz.GetLength(1)}";
                return message;
            }
        }
    }
}

