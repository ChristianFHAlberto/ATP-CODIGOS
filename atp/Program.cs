/*using System;
class Program
{
    static void Main(string[] args)
    {
        int x, y;
        string a, b;

        Console.WriteLine("Digite o nome do time Mandante:  ");
        a = (Console.ReadLine());

        Console.WriteLine("Digite o nome do time Visitante:  ");
        b = (Console.ReadLine());

        Console.WriteLine($"Digite a quantidade de gols do {a}");
        x = int.Parse(Console.ReadLine());

        Console.WriteLine($"Digite a quantidade de gols do {b}");
        y = int.Parse(Console.ReadLine());


        if (x > y)

        Console.WriteLine($"O {a} venceu o {b}, pelo placar de {x} x {y}.");

        else if (x < y)
        
         Console.WriteLine($"O {b} venceu o {a}, pelo placar de {x} x {y}.");

         else
         Console.WriteLine($"O jogo entre {b} x {a} terminou empatado pelo plcar de {x} x {y}.");
    }
}
*/

/*using System;
class Program
{
    static void Main(string[] args)
    {
        int n;

        Console.WriteLine("Informe um número: ");
        n = int.Parse(Console.ReadLine());

        if (n > 0)
        
            Console.WriteLine($"O {n} é POSITIVO.   ");
       

        else if (n < 0) 
        
            Console.WriteLine($"O {n} é NEGATIVO.   ");
        

        else
        
            Console.WriteLine($"O {n} é NULO.   ");
        
    }
}
*/

/*using System;
class Program
{
    static void Main(string[] args)
    {
        int n;

        Console.WriteLine("Digite um número e descubra se ele é par ou ímpar.  ");
        n = int.Parse(Console.ReadLine());

        if (n % 2 == 0)

            Console.WriteLine($"O {n} é PAR. ");

        else
            Console.WriteLine($"O {n} é ÍMPAR.  ");


    }
}
*/

/*using System;
class Program
{
    static void Main(string[] args)
    {
        double compra, valor, troco;


        Console.WriteLine("Qual o valor do produto comprado? ");
        compra = double.Parse(Console.ReadLine());

        Console.WriteLine("Qual o valor que o cliente passou? ");
        valor = double.Parse(Console.ReadLine());

        troco = valor - compra;


        if (compra < valor)
        
            Console.WriteLine($"O valor do troco deve ser {troco:f2}. ");
        

        else
        
            Console.WriteLine($"O valor pago está errado, ainda falta R${(troco * -1):f2}.");
        
    }
}

using System;
class Program
{
    static void Main(string[] args)
    {
        int compri, lado, area;

        Console.WriteLine("Qual o comprimento do arame em cm? ");
        compri = int.Parse(Console.ReadLine());

        lado = compri / 4;
        area = lado * lado;

        Console.WriteLine();
        Console.WriteLine($"Dado o comprimento de {compri}cm: ");
        Console.WriteLine($"Cada lado do quadrado terá {lado}cm.");
        Console.WriteLine($"A área desse quadrado terá {area}cm.");
        Console.WriteLine();

    }
}*/

