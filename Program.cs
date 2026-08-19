//comentário teste commit Aula03

using System;

namespace Aula01Variavel
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Observe o menu abaixo e digite o numero referente a opcao desejada");
            Console.WriteLine("1 - Concatenar Palavras");
            Console.WriteLine("2 - Verificar dia da semana");
            Console.WriteLine("3 - Calcular Média");
            Console.WriteLine("4 - Calcular Tabuada");
            Console.WriteLine("5 - Detalhar Data");
            Console.WriteLine("6 - Calcular Desconto INSS");

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

                case 5:
                    DetalharData();
                    break;

                case 6:
                    CalcularDescontoINSS();
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }

        public static void CalcularTabuada()
        {
            Console.WriteLine("Digite a tabuada que deseja");
            int tabuada = int.Parse(Console.ReadLine());
            int contador = 0;

            while (contador <= 10)
            {
                string mensagem = string.Format(
                    "{0} x {1} = {2}",
                    tabuada,
                    contador,
                    tabuada * contador
                );

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

            Console.WriteLine($"A média é {media}");

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
            string nome = Console.ReadLine();

            string frase1 = $"Olá {nome}, hoje é {DateTime.Now}";
            Console.WriteLine(frase1);

            Console.WriteLine("===========================");

            Console.WriteLine("Quanto custa um dólar em reais?");
            decimal ValorDolarReais = decimal.Parse(Console.ReadLine());

            string frase2 = string.Format(
                "Hoje é {0:dd/MM/yyyy}, o dólar está custando {1:c2}",
                DateTime.Now,
                ValorDolarReais
            );

            Console.WriteLine(frase2);

            Console.WriteLine("===========================");

            string cabecalho = string.Format(
                "{0:dddd}, {0:dd} de {0:MMMM} de {0:yy} - {0:HH:mm:ss}",
                DateTime.Now
            );

            Console.WriteLine(cabecalho);
        }

        public static void VerificaraulaEtec()
        {
            Console.WriteLine("Digite a Data");
            DateTime data = DateTime.Parse(Console.ReadLine());

            if (data.DayOfWeek == DayOfWeek.Saturday ||
                data.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("Final de semana! Hoje não tem aula! Revisarei exercícios");
            }
            else
            {
                Console.WriteLine("Dia da semana! Bora pra Etec");
            }
        }

        public static void DetalharData()
        {
            Console.WriteLine("Digite uma data");
            DateTime data = DateTime.Parse(Console.ReadLine());

            string mensagem = string.Format(
                "Hoje é {0:dddd}, mês de {0:MMMM}",
                data
            );

            Console.WriteLine(mensagem);

            if (data.DayOfWeek == DayOfWeek.Sunday)
            {
                string hora = string.Format(
                    "A hora atual é {0:HH:mm}",
                    DateTime.Now
                );

                Console.WriteLine(hora);
            }
        }

        public static void CalcularDescontoINSS()
        {
            Console.WriteLine("Digite o valor do salário");
            decimal salario = decimal.Parse(Console.ReadLine());

            decimal inss;

            if (salario <= 1621)
            {
                inss = salario * 0.075m;
            }
            else if (salario <= 2902.84m)
            {
                inss = (1621 * 0.075m) +
                       ((salario - 1621) * 0.09m);
            }
            else if (salario <= 4354.27m)
            {
                inss = (1621 * 0.075m) +
                       ((2902.84m - 1621) * 0.09m) +
                       ((salario - 2902.84m) * 0.12m);
            }
            else if (salario <= 8475.55m)
            {
                inss = (1621 * 0.075m) +
                       ((2902.84m - 1621) * 0.09m) +
                       ((4354.27m - 2902.84m) * 0.12m) +
                       ((salario - 4354.27m) * 0.14m);
            }
            else
            {
                inss = 988.09m;
            }

            decimal salarioDescontado = salario - inss;

            Console.WriteLine($"Valor do INSS: {inss:c2}");
            Console.WriteLine($"Salário após desconto: {salarioDescontado:c2}");
        }
    }
}