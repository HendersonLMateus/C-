using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaMoto {
    class Moto {

        public string Marca;
        public string Modelo;
        public string Cor;
        public int MarchaAtual;
        public bool Ligado;
        public int menorMarcha;
        public int maiorMarcha;

        public Moto() {

        }

        public Moto(string marca, string modelo, string cor, int menormarcha,int maiormarcha ) {
            Marca = marca;
            Modelo = modelo;
            Cor = cor;          
            menorMarcha = menormarcha;
            MarchaAtual = menormarcha;
            maiorMarcha = maiormarcha;
            
        }

        public void Imprimir() {
            Console.WriteLine(Marca);
            Console.WriteLine(Modelo);
            Console.WriteLine(Cor);
            Console.WriteLine(MarchaAtual);
            Console.WriteLine(menorMarcha);
            Console.WriteLine(maiorMarcha);
            Console.WriteLine(Ligado);
        }
        public void marchaAcima() { 

            MarchaAtual = MarchaAtual + 1;

        }
        public void marchaAbaixo() {
            MarchaAtual -= 1;

        }
        public void Ligar() {
            Ligado = true;
        }
        public void Desligada() {
            Ligado = false;
        }

    }

}
