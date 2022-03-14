using System;

namespace Calculadora.ConsoleApp
{
    internal partial class Program
    {

        public static string Menu()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Digite a operação que você deseja efetuar:\n0- Fechar a calculadora\n1- Soma (+)\n2- Subtração (-)" +
                "\n3- Multiplicação (*)\n4- Divisão (/)\n5- Visualizar histórico de operações");
            Console.ResetColor();
            Console.WriteLine();
            Console.Write("Opção: ");
            string opcaoMenu = Console.ReadLine();
            Console.WriteLine();

            return opcaoMenu;
        }

        public static string Continuar()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Deseja realizar outra operação? Digite:\n0- Não\n1- Sim");
            Console.ResetColor();
            Console.WriteLine();
            Console.Write("Opção: ");
            string opcaoContinuar = Console.ReadLine();
            Console.WriteLine();

            return opcaoContinuar;
        }

        public static void Mensagem(string mensagem, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(mensagem);
            Console.ResetColor();
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            string continuar = null;
            Calculadora calculadora = new Calculadora();
            calculadora.historicoCalculadora = new Historico[100];

            do {

                string operacao = Menu();

                while (operacao != "0" && operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4" && operacao != "5")
                {
                    Mensagem("Operação inválida!", ConsoleColor.Red);

                    operacao = Menu();
                }

                switch (operacao)
                {
                    case "1":
                        Console.WriteLine("SOMA");
                        Console.Write("Digite o primeiro número: ");
                        double numero1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo número: ");
                        double numero2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Resultado da soma: " + calculadora.Somar(numero1, numero2));

                        break;

                    case "2":
                        Console.WriteLine("SUBTRAÇÃO");
                        Console.Write("Digite o primeiro número: ");
                        numero1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo número: ");
                        numero2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Resultado da subtração: " + calculadora.Subtrair(numero1, numero2));

                        break;

                    case "3":
                        Console.WriteLine("MULTIPLICAÇÃO");
                        Console.Write("Digite o primeiro número: ");
                        numero1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo número: ");
                        numero2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Resultado da multiplicação: " + calculadora.Multiplicar(numero1, numero2));

                        break;

                    case "4":
                        Console.WriteLine("DIVISÃO");
                        Console.Write("Digite o primeiro número: ");
                        numero1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo número: ");
                        numero2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Resultado da divisão: " + calculadora.Dividir(numero1, numero2));

                        break;

                    case "5":
                        Console.WriteLine("HISTÓRICO DE OPERAÇÕES");
                        calculadora.ExibirHistorico();

                        break;

                    default:
                        System.Environment.Exit(0);
                        break;
                }

                continuar = Continuar();   

                while (continuar != "0" && continuar != "1")
                {
                    Mensagem("Operação inválida!", ConsoleColor.Red);
                }

            } while (continuar == "1");
        }
    }
}
