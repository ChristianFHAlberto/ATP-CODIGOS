using System;
using System.Net.Security;
class Program
{
    static void Main(string[] args)
    {
        double L;
        int n, ContSemBenef = 0, ContDesc = 0, ContDescBrin = 0;

        Console.WriteLine("Quantos motoristas abasteceram? ");
        n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Informe a quantidade de litros abastecidos pelo {i}/{n}:");
            L = double.Parse(Console.ReadLine());

            if (L <= 15)
            {
                Console.WriteLine("Não tem direito ao Benefício.");
                ContSemBenef = ContSemBenef + 1;
            }

            else if (L > 15 && L <= 30)
            {
                Console.WriteLine("Tem direito ao Benefício de 5% de desconto.");
                ContDesc = ContDesc + 1;
            }

            else
            {
                Console.WriteLine("Tem direito ao Benefício de 5% de desconto mais o brinde de escolha.");
                ContDescBrin = ContDescBrin + 1;
            }
        }

        // QUANTIDADE
        Console.WriteLine("Quantidade");
        Console.WriteLine("O número de motoristas SEM BENEFÍCIO são: " + ContSemBenef);
        Console.WriteLine("O número de motoristas COM BENEFÍCIO são: " + ContDesc);
        Console.WriteLine("O número de motoristas COM BENEFÍCIO + BRINDE são: " + ContDescBrin);

        // Percentual
        Console.WriteLine("Percentual");
        Console.WriteLine("O número de motoristas SEM BENEFÍCIO são: " + (ContSemBenef * 100 / n));
        Console.WriteLine("O número de motoristas COM BENEFÍCIO são: " + (ContDesc * 100 / n));
        Console.WriteLine("O número de motoristas COM BENEFÍCIO + BRINDE são: " + (ContDescBrin * 100 / n)) ;

        // Categoria Predominante
            

    }
}