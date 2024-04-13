using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafios_csharp.Desafios
{
    class Desafio04 {
        public static void Main() {

        }

        public static void Desafio04() {
            int[] x = new int[10] { 0, -5, 63, 0 , 10, -2, 5, -1, 1, 0 };

            for (int i = 0; i < 10; i++) {
                if (x[i] <= 0) {
                    x[i] = 1;
                    Console.WriteLine(x[i]);
                } 
            }
        }
    }
}

