using System;

namespace exercicios {

    /*
    class Triangulo {
        public double A;
        public double B;
        public double C;

        double CalculaArea() {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }


        class Retangulo{

        public double Largura;
        public double Altura;

        public double Area(double x,double y){
        
            return x*y;
        }

        public double Perimetro(double x, double y){

            return 2*x + 2*y;
        }

        public double Diagonal(double x,double y){

            return Math.Sqrt(Math.Pow(x,2) + Math.Pow(y,2));
        }

        }
        

         class Funcionario {
            public string Nome;
            public double SalarioBruto;
            public double Imposto;

         public void AtualizaDados(){

            Console.WriteLine("Funcionário: "+Nome+", R$"+(SalarioBruto-Imposto));
         }

         public double AumentaSalario(double x){
            double a = SalarioBruto * (x/100); 
            double b = SalarioBruto - Imposto;

            return a + b;
         }

        }

        class Aluno {

           public string Nome;
           public double[] Notas = new double[3];
        

            public void NotaFinal(double x, double y,double z) {

             double a = x + y + z;
             
            if (a < 90) {
                Console.WriteLine("NOTA FINAL = "+a);
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTAM "+ (60-a)+" PONTOS");
                }
            else {
                Console.WriteLine("NOTA FINAL ="+ a);
                Console.WriteLine("APROVADO");
            }
                
             }
         }

        */

        class ConversorDeMoeda {

        public static double IOF(double x,double y) {

            double a = x * y;

            return a + (0.06 * a);

        }

    }




        class Program {
            static void Main(string[] args) {
            /*
            int n;


            Console.WriteLine(" Numero de entradas ");
            n = int.Parse(Console.ReadLine());

            string[] nome = new string[n];


            for (int i=0;i<n;i++)
            {

                nome[i] = Console.ReadLine();
            }
            Console.WriteLine("Nomes lidos: ");
            foreach (string x in nome)
            {

                Console.WriteLine(x);
            }

             ----------------------------------------------------------------------------


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

           --------------------------------------------------

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

            --------------------------------------------------


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

            ------------------------------------------

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
            ------------------------------------------------------

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


    ----------------------------------------------------------------------

            int n;
            string[] entrada;
            string[] nome;
            int[] idade;
            float[] altura;

            float media;
            media = 0.0f;
            int contIdade;
            contIdade = 0;

            Console.WriteLine("Quantidade de Entradas: ");
            n = int.Parse(Console.ReadLine());

            nome = new string[n];
            idade = new int[n];
            altura = new float[n];
            entrada = new string[n];


            for (int i=0;i<n;i++) {

                entrada = Console.ReadLine().Split(' ');
                nome[i] = entrada[0];
                idade[i] = int.Parse(entrada[1]);
                altura[i] = float.Parse(entrada[2]);

                if (idade[i] < 16)
                {
                    contIdade += 1;
                }
            }

            for (int i = 0;i<n;i++)
            {
               media += altura[i];           
            }


            Console.WriteLine("A media de altura é: "+(media/n));
            double porcentagem;
            porcentagem = (double) contIdade/n *100.0;
            Console.WriteLine("Pessoas com menos de 16 anos: "+ porcentagem+"%");


---------------------------------------------------------

            int n;
            int negativo = 0;

            Console.WriteLine("Tamanho da Matriz Quadrada? ");
            n = int.Parse(Console.ReadLine());

            int [,] a = new int [n,n];

            for (int i = 0; i < n; i++)
            {

                string[] vetor = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {

                    a[i, j] = int.Parse(vetor[j]);
                }
            }

            Console.Write("A diagonal principal é: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {


                    if (i == j){
                        Console.Write(a[i, j]+" ");

                    }
                    if (a[i, j]<0)
                    {


                        negativo += 1;
                    }
                }


            }
            Console.WriteLine();
            Console.Write("A quantidade de Negativos é: " + negativo);

    -----------------------------------------------------------


            int linha, coluna;
            int soma = 0;

            Console.WriteLine("Linha Coluna ");
            string[] vetor = Console.ReadLine().Split(' ');

            linha = int.Parse(vetor[0]);
            coluna = int.Parse(vetor[1]);

            int[,] a = new int[linha, coluna];
            int[] vet = new int[linha];

            for (int i = 0; i < linha; i++) {

                string[] s = Console.ReadLine().Split(' ');


                for (int j=0;j<coluna;j++)
                {

                    a[i, j] = int.Parse(s[j]);
                    soma += int.Parse(s[j]);

                }


                vet[i] = soma;
                soma = 0;

            }
           for (int i=0;i<linha;i++)
            {
                Console.WriteLine("A soma da linha é "+vet[i]);
            }



           --------------------------------------------

          string [] vetor;

            vetor = Console.ReadLine().Split(' ');
            string nome = vetor[0];
            char sexo = char.Parse(vetor[1]);
            int idade = int.Parse(vetor[2]);
            double altura = double.Parse(vetor[3]);

            Console.WriteLine(nome+""+sexo);


            ----------------------------

            Console.WriteLine("Digite os numeros: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            maior(n1,n2,n3);

           void maior(int a,int b, int c){

               if (n1>n2 && n1>n3){

                    Console.WriteLine("O maior é "+n1);
               }
               else if(n2>n1 && n2>n3){

                    Console.WriteLine("O maior é "+ n2);
                }
               else{

                Console.WriteLine("O maior é "+ n3);
                }


            }
            ---------------------------------


          Console.WriteLine("Digite um numero: ");
          int x = int.Parse(Console.ReadLine());

            while (x>0){

                Console.WriteLine(Math.Sqrt(x).ToString("F3"));
                Console.WriteLine("Digite um numero: ");
                x = int.Parse(Console.ReadLine());

                }
            Console.WriteLine("Numero Negativo");

            ------------------------------

            Console.WriteLine("Quantos numeros inteiros você vai digitar?");
            int x = int.Parse(Console.ReadLine());

            int[]vetor = new int[x];
            int soma = 0;

            for (int i =0;i<x;i++){
                Console.Write("Valor #"+(i+1)+":");
                vetor[i]= int.Parse(Console.ReadLine());
                soma += vetor[i];
            }

            Console.WriteLine("Soma = "+soma);

            ---------------------------------------------------

            Pessoa x;
            Pessoa y;

            x = new Pessoa();
            y = new Pessoa();



            Console.WriteLine("Dados da primeira pessoa: ");

            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            x.Idade = int.Parse(Console.ReadLine());            

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: " );
            y.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            y.Idade = int.Parse(Console.ReadLine());

            ------------------------------------------

            Pessoa f1,f2;

            f1 = new Pessoa();
            f2 = new Pessoa();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f2.Salario = double.Parse(Console.ReadLine());

            double media = (f1.Salario + f2.Salario) / 2;
            Console.WriteLine("Salario Medio: "+media);

            --------------------------------------

            Triangulo a, b;

            a = new Triangulo();
            b = new Triangulo();


            Console.WriteLine("Medidas do Triangulo A");
            a.A = double.Parse(Console.ReadLine());
            a.B = double.Parse(Console.ReadLine());
            a.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Medidas do Triangulo B");
            b.A = double.Parse(Console.ReadLine());
            b.B = double.Parse(Console.ReadLine());
            b.C = double.Parse(Console.ReadLine());

            double areaX = a.CalculaArea();

            double areaY = b.CalculaArea();

            Console.WriteLine("Area de X: " + areaX);
            Console.WriteLine("Area de B: " + areaY.ToString("F4"));

            if (areaX > areaY) {
                Console.Write("Maior Area: X");
            }
            else {
                Console.Write("Maior Area: Y ");
            }

            ---------------------------------------

            Pessoa f1, f2;

            f1 = new Pessoa();
            f2 = new Pessoa();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f2.Salario = double.Parse(Console.ReadLine());

            double media = (f1.Salario + f2.Salario) / 2;
            Console.WriteLine("Salario Medio: " + media);


           ---------------------------------------

            Console.WriteLine("Digite a Largura e Altura do Retangulo: ");

            Retangulo R = new Retangulo();

            R.Largura = double.Parse(Console.ReadLine());
            R.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Area = "+ R.Area(R.Altura,R.Largura));
            Console.WriteLine("Perimetro = "+ R.Perimetro(R.Largura,R.Altura));
            Console.WriteLine("Diagonal = "+ R.Diagonal(R.Altura,R.Largura));
             -------------------------------------------------

            Funcionario F = new Funcionario();
            double x; 

            Console.Write("Nome: ");
            F.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            F.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            F.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("");
            F.AtualizaDados();
            Console.WriteLine(" ");

            Console.Write("Digite a Porcentagem de Aumento do Salário: ");
            x = double.Parse(Console.ReadLine());
            double a = F.AumentaSalario(x);


            Console.WriteLine("");
            Console.WriteLine("Dados Atualizados: "+F.Nome+", R$"+a);       
          
            -----------------------------------

            Aluno A = new Aluno();

             Console.Write("Nome do Aluno: ");
             A.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três Notas do Aluno: ");
            for (int i=0; i<3;i++) {
                A.Notas[i] = double.Parse(Console.ReadLine());
            }

            A.NotaFinal(A.Notas[0],A.Notas[1],A.Notas[2]);
            
              */

            Console.Write("Qual é a cotação do dólar? ");
            double dolar = double.Parse(Console.ReadLine());
            Console.Write("Quantos dólares você vai comprar? ");
            double real = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor a ser pago em reais = "+ConversorDeMoeda.IOF(real,dolar));

            Console.ReadLine();
        }
    }
}


