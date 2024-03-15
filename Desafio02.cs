using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o código do produto:");
        int selectProduct = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quantidade desejada:");
        int quantity = int.Parse(Console.ReadLine());

        float productValue = 0f;

        if (selectProduct == 1)
        {
            productValue = 4.00f;
        }
        else if (selectProduct == 2)
        {
            productValue = 4.50f;
        }
        else if (selectProduct == 3)
        {
            productValue = 5.00f;
        }
        else if (selectProduct == 4)
        {
            productValue = 2.00f;
        }
        else if (selectProduct == 5)
        {
            productValue = 1.50f;
        }

        double total = productValue * quantity;

        Console.WriteLine($"Total: R$ {total:F2}");

    }
}



