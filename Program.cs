using System;

namespace exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            AREA DO RETANGULO

            float Base, altura, area, valor;

            Console.WriteLine("Digite o valor da Base");
            Base = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da Altura");
            altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor do Metro Quadrado? ");
            valor = float.Parse(Console.ReadLine());

            area = Base * altura;

            Console.WriteLine("A area do terreno é de "+area+ " e o valor do Metro Quadrado é de "
                + valor + ". Ou seja, o valor total do terreno é de " + (area*valor));
            
            AREA DO CIRCULO

            float r,area;
            float n = 3,14159f;

            Console.WriteLine("Digite o valor do Raio");
            r = float.Parse(Console.ReadLine());

            area = n * (r * r);
            Console.WriteLine("O valor da Area do circulo é de " + area + "com um raio de " + r );
           
            ----------------------------------------------------------

            string nome1,nome2;
            int idade1, idade2;
            string[] vetor;
            double media;

        

            Console.WriteLine("Digite seu Primeiro Nome e sua Idade");
            vetor = Console.ReadLine().Split(' ');
            nome1 = vetor[0];
            idade1 = int.Parse(vetor[1]);
            Console.WriteLine("Digite seu Primeiro Nome e sua Idade");
            vetor = Console.ReadLine().Split(' ');
            nome2 = vetor[0];
            idade2 = int.Parse(vetor[1]);

            media = (double)(idade1 + idade2) / 2;

            Console.WriteLine("A idade media de "+ nome1+" e "+ nome2 + " é de " + media + " anos");
             

            int x,horas,minutos,segundos;

            Console.WriteLine("Digite os segundos: ");

            x = int.Parse(Console.ReadLine());

            horas = x / 3600;
            minutos = (x % 3600)/60;
            segundos = x % 60;
            
            Console.WriteLine(x +" tem "+ horas +" horas "+ minutos +" minutos " + segundos + " segundos");


            -----------------------------------------------------

            int x, y;

            string[] vetor;

            Console.WriteLine("Digite os Números ");

            vetor = Console.ReadLine().Split(' ');

            x = int.Parse(vetor[0]);
            y = int.Parse(vetor[1]);

            while (x != y)
            {

                if (x > y)
                {
                    Console.WriteLine("Ordem Decrescente ");
                }
                else
                {

                    Console.WriteLine("Ordem Crescente ");

                }
                Console.WriteLine("Digite os Números ");
                vetor = Console.ReadLine().Split(' ');

                x = int.Parse(vetor[0]);
                y = int.Parse(vetor[1]);

            }

            -----------------------------------------

            float x, soma,idade, media;
            
             
            x = 0;
            media = 0;
            soma = 0;

            idade = float.Parse(Console.ReadLine());

            while (idade >= 0)
            {

               
                soma += idade;
                x = x + 1;
                idade = float.Parse(Console.ReadLine());

            }

            if (x == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                media = soma / x;
                Console.WriteLine(media);


            }
            ------------------------------------------

            

            int x;

            x = int.Parse(Console.ReadLine());

            if (x > 2 && x < 1000)
            {
                for (int i = 1; i <=10; i++)
                {
                    Console.WriteLine(x+" x "+i+" = "+ (x*i));
                }
            }

            ------------------------------

            int x,y,soma,min,max;
            soma = 0;


            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                max = x;
                min = y;
            }
            else
            {
                max = y;
                min = x;
            }

            for(int i = min + 1; i < max; i++)
            {
                if (i%2 != 0)
                {
                    soma += i;
                }
            }
            Console.WriteLine(soma);

           

            float celsius, fahrenheit;
            fahrenheit = 0.0f;
            string escolha;

            do
            {

                Console.WriteLine("Digite a temperatura em Celsius: ");
                celsius = float.Parse(Console.ReadLine());

                fahrenheit = ((9 * celsius) / 5) + 32;
                Console.WriteLine("Equivalente em Fahrenheit: " + fahrenheit);

                Console.WriteLine("Deseja repetir? (s/n) ");
                escolha = Console.ReadLine();
            } while (escolha != "n");

             

            int n;

            float[] a;

            Console.WriteLine("Digite o tamanho do vetor: ");

            n = int.Parse(Console.ReadLine());
            a = new float[n];


            for (int i = 0; i<n;i++)
            {
                Console.WriteLine("Digite o valor a ser inserido no vetor: ");
                a[i] = float.Parse(Console.ReadLine());
               
            }

            Console.WriteLine("Os numeros no vetor são: ");
            for (int i = 0; i < n; i++)
            {
               
                Console.WriteLine(a[i]);
            }

            

            int n;

            int[] a;
            int[] b;

            Console.WriteLine("Tamanho do vetor: ");
            n = int.Parse(Console.ReadLine());

            a = new int[n];
            b = new int[n];

            Console.WriteLine("Digite os numeros: ");
            for (int i=0;i<n;i++)
            {

                a[i] = int.Parse(Console.ReadLine());

            }

            for (int i=0;i<n;i++)
            {
                if (a[i] < 0)
                {
                    b[i] = a[i];
                }


            }


            Console.WriteLine("Vetor Normal");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);
            }

            Console.WriteLine("Vetor Negativo");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(b[i]);
            }
            */

            int n,contador;
            double soma,media;
            double[] b;
            string[] a;

            soma = 0.0;
            media = 0.0;
            contador = 0;



            Console.WriteLine("Digite o Tamanho do Vetor: ");
            n = int.Parse(Console.ReadLine());

            a = new string[n];
            b = new double[n];

            Console.WriteLine("Digite os valores do vetor: ");

            a = Console.ReadLine().Split();

            Console.WriteLine("Os valores do vetor são: ");
            for (int i =0;i<n;i++)
            {
                b[i] = double.Parse(a[i]); ///Converte String para Double
                Console.Write(b[i]+ " ");
            }



            for (int i = 0;i<n;i++)
            {

                soma += b[i];
                contador += 1;

            }

            media = soma / contador;
            Console.WriteLine(" ");
            Console.Write("A media é "+ media+" a soma é "+soma);


            Console.ReadLine();

        }
    }
}
