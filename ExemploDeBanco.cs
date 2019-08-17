/* Em um banco, para se cadastrar uma conta bancária, é necessário informar o número da conta, o nome do
titular da conta, e o valor de depósito inicial que o titular depositou ao abrir a conta. Este valor de depósito
inicial, entretanto, é opcional, ou seja: se o titular não tiver dinheiro a depositar no momento de abrir sua
conta, o depósito inicial não será feito e o saldo inicial da conta será, naturalmente, zero.
Importante: uma vez que uma conta bancária foi aberta, o número da conta nunca poderá ser alterado. Já
o nome do titular pode ser alterado (pois uma pessoa pode mudar de nome por ocasião de casamento, por
exemplo).
Por fim, o saldo da conta não pode ser alterado livremente. É preciso haver um mecanismo para proteger
isso. O saldo só aumenta por meio de depósitos, e só diminui por meio de saques. Para cada saque
realizado, o banco cobra uma taxa de $ 5.00. Nota: a conta pode ficar com saldo negativo se o saldo não for
suficiente para realizar o saque e/ou pagar a taxa.
Você deve fazer um programa que realize o cadastro de uma conta, dando opção para que seja ou não
informado o valor de depósito inicial. Em seguida, realizar um depósito e depois um saque, sempre
mostrando os dados da conta após cada operação. 

*/



using System;

namespace exemploBanco {

        class Cliente {
            public int NumeroDaConta { get; private set; }
            public string Nome;
            public double Saldo { get; private set; }

            public Cliente (){

            }
            
            public Cliente (int n,string nome){
            NumeroDaConta = n;
            Nome = nome;
            }

            public Cliente (int n,string nome,double deposito) : this (n,nome){
            Saldo += deposito;
            }

            public void DadosDaConta(){
            Console.WriteLine(" ");
            Console.WriteLine("Dados da Conta:");
            Console.Write("Conta "+NumeroDaConta+", Titular: "+Nome+", Saldo: R$"+Saldo);
            Console.WriteLine(" ");
            
        } 

            public void Saque(double n) {

            Saldo -= n + 5;
            }

            public void Deposito(double n) {

            Saldo += n;
        }
    }
 
    class Program {
        static void Main(string[] args) {

            Console.Write("Entre o número da Conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o Titular da Conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá deposito inicial? (S/N) ");
            char s = char.Parse(Console.ReadLine());

            if (s == 's' || s == 'S'){
                Console.Write("Digite o valor do Deposito: ");
                double deposito = double.Parse(Console.ReadLine());

                Cliente b = new Cliente(numero,nome,deposito);
                
                b.DadosDaConta();

                Console.WriteLine(" ");
                Console.Write("Entre com um valor para deposito: ");
                double dep = double.Parse(Console.ReadLine());
                b.Deposito(dep);
                b.DadosDaConta();
                Console.WriteLine(" ");

                Console.Write("Entre um valor para saque: ");
                double x = double.Parse(Console.ReadLine());
                b.Saque(x);
                b.DadosDaConta();
            }

            else {

                Cliente b = new Cliente(numero, nome);
                Console.WriteLine(" ");
                Console.Write("Entre com um valor para deposito: ");
                double dep = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                b.Deposito(dep);
                b.DadosDaConta();
                Console.WriteLine(" ");

                Console.Write("Entre um valor para saque: ");
                double x = double.Parse(Console.ReadLine());
                b.Saque(x);
                b.DadosDaConta();

            }
          
            Console.ReadLine();
        }
   }   
}
