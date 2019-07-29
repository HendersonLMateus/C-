using System;

namespace Estoque {
    class Produto {
        public string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto() {
        }

        public Produto(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) { //Value será o valor que foi dado na atribuição 
                    _nome = value;
                }
            }
        }

        public int AdicionaProdutos(int x) {
            return Quantidade += x;
        }

        public int ValorTotalEmEstoque(int x) {

            return Quantidade -= x;
        }
        public void DadosAtualizados() {

            Console.WriteLine("Dados Atualizados: " + Nome + " , R$" + Preco + " , " + Quantidade + " unidades ," + " Total: R$" + (Quantidade * Preco));
        }
        public int RemoverProdutos(int x) {
            return Quantidade -= x;
        }



        class Program {
            static void Main(string[] args) {

                Produto p = new Produto();

                Console.WriteLine("Entre com os dados do Produto:");
                Console.Write("Nome: ");
                p.Nome = Console.ReadLine();

                Console.Write("Preço: ");
                p.Preco = double.Parse(Console.ReadLine());

                Console.Write("Quantidade de Entrada no Estoque: ");
                p.Quantidade = int.Parse(Console.ReadLine());

                Console.WriteLine(" ");

                Console.WriteLine("Dados do Produto: " + p.Nome + " , R$" + p.Preco + " , " +
                    p.Quantidade + " unidades ," + " Total: R$" + (p.Quantidade * p.Preco));

                Console.WriteLine(" ");
                Console.Write("Digite o número de produtos que serão adicionados: ");
                int numeroProdutos = int.Parse(Console.ReadLine());
                p.AdicionaProdutos(numeroProdutos);

                Console.WriteLine(" ");
                p.DadosAtualizados();

                Console.WriteLine(" ");
                Console.Write("Digite o número de produtos a serem removidos: ");
                p.RemoverProdutos(int.Parse(Console.ReadLine()));
                Console.WriteLine(" ");
                p.DadosAtualizados();
                Console.ReadLine();



            }




        }
    }
}
