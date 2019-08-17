
using System.Collections.Generic;
using System;

namespace listaDeFuncionarios {
    class Program {
        class Funcionario {
            public int Id;
            public string Nome;
            private double Salario;

            public Funcionario (){
            }

            public Funcionario (int a,string b, double c){           
                Id = a; 
                Nome = b;
                Salario = c;
             }

            public override string ToString() {
                return Id+", "+Nome+", "+Salario;
            }

            public void AumentaSalario( double percent) {
                Salario += Salario * percent / 100;
            } 

        }

        static void Main(string[] args) {

            Console.Write("Quantos funcionários deseja adicionar: ");
            int n = int.Parse(Console.ReadLine());
            List<Funcionario> listaDeFuncionario = new List<Funcionario>();

            for (int i = 0;i<n;i++) {
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());

                foreach (Funcionario obj in listaDeFuncionario) {
                    if (obj.Id == id) {
                        Console.WriteLine(" Esse Id já existe! Tente Outro: ");
                        id =int.Parse(Console.ReadLine());
                    }
                }

                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine());
               
                 listaDeFuncionario.Add( new Funcionario(id,nome,salario));
            }

            Console.WriteLine(" ");

            Console.Write("Qual ID receberá aumento: ");
            int a = int.Parse(Console.ReadLine());

            Funcionario j = listaDeFuncionario.Find(x => x.Id == a);
            if (j != null) {
                Console.Write("Digite a Porcentagem de Aumento: ");
                double p = double.Parse(Console.ReadLine());
                j.AumentaSalario(p);
            }                     
            else {
                Console.WriteLine("Esse ID não existe");
            }
            Console.WriteLine(" ");
            foreach (Funcionario obj in listaDeFuncionario){
                
                Console.WriteLine(obj);

                }

            Console.ReadLine();

        }
    }
}
