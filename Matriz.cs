//Cria uma Matriz e Depois diz quais os numeros estão acima,a esquerda, a direita e abaixo de um determiando numero dentro da matriz, onde o mesmo pode se repetir.

using System;

namespace Exercicio_Matriz {
    class Program {
        static void Main(string[] args) {

            Console.Write("Linhas: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Colunas: ");
            int n2 = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n1, n2];

            for (int a = 0; a < n1; a++) {
                string[] vetor1 = Console.ReadLine().Split(' ');

                for (int j = 0; j < n2; j++) {
                    matriz[a, j] = int.Parse(vetor1[j]);
                }
            }

            Console.WriteLine(" ");
            Console.Write("Digite um numero: ");
            int b = int.Parse(Console.ReadLine());
            for (int j = 0; j<n1;j++) {
                for (int k = 0;k<n2;k++) {
                   if (matriz[j,k] == b) {
                        Console.WriteLine("Posição "+j+","+k);

                        if (j - 1 >= 0) {
                            Console.WriteLine("Acima: "+matriz[j - 1, k]);
                        }

                        if (k - 1 >= 0) {
                            Console.WriteLine("Esquerda: "+ matriz[j, k - 1]);
                        }

                        if (k + 1 < n2) {
                            Console.WriteLine("Direita: "+matriz[j, k + 1]);
                        }

                        if (j + 1 < n1) {
                            Console.WriteLine("Abaixo: "+matriz[j + 1, k]);
                        }

                    }

                }
                    
            }

            Console.ReadLine();


        }

    }
}


