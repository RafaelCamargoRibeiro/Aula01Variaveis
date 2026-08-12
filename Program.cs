//comentário teste commit Aula03

using System;

namespace Aula01Variavel
{
    public class Program
    {
        static void Main(string[] args)
        {
            // ConcatenatPalavras();//mostrar o meu programa para roda-lo
            //CalcularMédia();
            //CalcularTabuada();
            //VerificaraulaEtec();
            Console.WriteLine("Observe o menui abaixo e digite o numero referente a opçaodesejada");
            Console.WriteLine("1 - Concatenar Palavras");
            Console.WriteLine("2 - Verificar dia da semana");
            Console.WriteLine("3 - Calcular Média");
            Console.WriteLine("4 - Calcular Tabuada");

            int opcaoEscolhida = int.Parse(Console.ReadLine());

            switch (opcaoEscolhida)
            {
                case 1:
                ConcatenatPalavras();
                break;

                 case 2:
                VerificaraulaEtec();
                break;

                 case 3:
                CalcularMédia();
                break;

                 case 4:
                CalcularTabuada();
                break;
                default:
                Console.WriteLine("Opção inválida");
                break;

                 



            }
            
        }

        public static void CalcularTabuada()
        {
            Console.WriteLine("Digite a tabuada que deseja");
            int tabuada= int.Parse(Console.ReadLine());
            int contador = 0;

            while (contador<=10)
            {
               string mensagem = string.Format("{0} x {1} = {2}",tabuada,contador,tabuada*contador);
               Console.WriteLine(mensagem);
               contador++;

            }



        }

        public static void CalcularMédia()
        {
            Console.WriteLine("Digite a primeira nota");
            decimal nota1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota");
            decimal nota2 = decimal.Parse(Console.ReadLine());

            decimal media = (nota1 + nota2) / 2;
            Console.WriteLine($"Á média é {media}");

            if (media >= 7)
                Console.WriteLine("Aprovado");
            else if (media < 7 && media >= 4)
                Console.WriteLine("Recuperação");
            else
                Console.WriteLine("Reprovado");
        }





        public static void ConcatenatPalavras()
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();//variavel de texto"nome"

            string frase1 = $"Olá {nome}, hoje é {DateTime.Now}";//olá variavel escrita acima
            Console.WriteLine(frase1);

            Console.WriteLine("===========================");

            Console.WriteLine("Quanto custa um dólar em reais?");
            decimal ValorDolarReais = decimal.Parse(Console.ReadLine());
            string frase2 = string.Format("Hoje é {0:dd/MM/yyyy}, o dólar está custando {1:c2}", DateTime.Now, ValorDolarReais);
            Console.WriteLine(frase2);

            Console.WriteLine("===========================");

            string cabecalho = string.Format("{0:dddd}, {0:dd} de {0:MMMM} de {0:yy} - {0:HH:mm:ss}", DateTime.Now);//usamos a mesma variavel pois éa mesma coisa 
            Console.WriteLine(cabecalho);
        }


        public static void VerificaraulaEtec()
        {
            Console.WriteLine("Digite a Data");
            DateTime data = DateTime.Parse(Console.ReadLine());
            if(data.DayOfWeek == DayOfWeek.Saturday || data.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("Final de semana! Hoje não tem aula! Revisarei exercícios");
            }
            else
            {
                Console.WriteLine("Dia da semana! Bora pra Etec");

            }

            }



    }
}
