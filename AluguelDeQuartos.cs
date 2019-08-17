 using System;

namespace ConsoleApp1 {
    class Program {

        class Aluguel {
            public string Nome;
            public string Email;          

            public Aluguel(string nome, string email) {
                Nome = nome;
                Email = email;
            }

            public override string ToString() {
                return Nome+", "+Email;
            }
        }

        static void Main(string[] args) {

            Aluguel[] vetor = new Aluguel[10];


            Console.WriteLine("Digite a quantidade de Quartos: ");
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i<n;i++) {

                Console.WriteLine("Quarto #"+i+1);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vetor[quarto] = new Aluguel(nome,email); 

            }
            for (int i = 0;i<10;i++) {

                if (vetor != null) {
                    Console.WriteLine(i+" "+vetor[i]);
                }
            }
            Console.ReadLine();
        }
    }
}


