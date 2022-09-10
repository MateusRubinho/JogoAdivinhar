using System;

class Eden
{
    public static void Main()
    {

        Console.Write("Digite o numero que deseja, de 1 a 5, para o adversario advinhar: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.Clear();

        Console.Write("Adivinhe o numero do oponente: ");
        int n2 = int.Parse(Console.ReadLine());


        while (n2 != n1)
        {

            Console.WriteLine("Digite outro numero!");
            n2 = int.Parse(Console.ReadLine());

            switch (n2)
            {
                case ( > 5):
                    Console.WriteLine("ATENÇÃO: Somente numeros a baixo de 5!!!!");
                    break;

            }

        }

        Console.Write("Acertou Gigante!!");


    }
}