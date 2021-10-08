using System;

namespace OO_Exercicio1
{
    class Program
    {  
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Digite o nome: ");
            p1.nome = Console.ReadLine();

            System.Console.WriteLine("Digite a idade");
            p1.idade = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o nome: ");
            p2.nome = Console.ReadLine();

            System.Console.WriteLine("Digite a idade");
            p2.idade = int.Parse(Console.ReadLine());

            if (p1.idade > p2.idade)
            {
                System.Console.WriteLine("A pessoa mais velha é "+ p1.nome);
            }
            else
            {
                System.Console.WriteLine("A pessoa mais velha é "+p2.nome);
            }

        }
    }
}
