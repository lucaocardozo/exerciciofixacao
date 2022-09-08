using System;

namespace Vetores_Exercicio_Pensionato {
    class Program {
        static void Main(string[] args) {

            Quarto[] estudante = new Quarto[10];

            Console.Write("Quantos quartos serão alugados: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Aluguel #" + i + ":");
                Console.Write("Insira qual quarto  deseja reservar (0 - 9): ");
                int quarto = int.Parse(Console.ReadLine());
                Console.Write("Insina o nome: ");
                string nome = Console.ReadLine();
                Console.Write("Insina o email: ");
                string email = Console.ReadLine();
                estudante[quarto] = new Quarto(nome, email);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Quartos Alugados: ");
            for (int i = 0; i < 10; i++) {
                if (estudante[i] != null) {
                    Console.WriteLine(i + ": " + estudante[i]);


                }
            }

        }
    }
}
