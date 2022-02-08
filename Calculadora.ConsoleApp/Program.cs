using System;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string continuar = null;
            int contador = 0;
            string stringAux = null;
            int contadorAux = 0;
            string[] historico = new string[10];

            do {

                double resultado = 0;

                Console.WriteLine("Seja bem-vindo a minha calculadora! Primeiro, digite a operação que" +
                    "você deseja efetuar:\n0- Fechar a calculadora\n1- Soma (+)\n2- Subtração (-)\n3- Multiplicação (*)\n4- Divisão (/)\n5- Visualizar histórico de operações");

                string operacao = Console.ReadLine();

                while (operacao != "0" && operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4" && operacao != "5")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Operação inválida!");
                    Console.ResetColor();

                    Console.WriteLine("Por favor, digite a operação que você deseja efetuar:\n0- Fechar a calculadora\n1- Soma (+)" +
                        "\n2- Subtração (-)\n3- Multiplicação (*)\n4- Divisão (/)\n5- Visualizar histórico de operações");

                    operacao = Console.ReadLine();
                }

                if (operacao == "0")
                {
                    Environment.Exit(0);
                }

                if (operacao == "5")
                {
                    if (contador == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Histórico vazio!");
                        Console.ResetColor();
                        break;
                    } else
                    {
                        for (int i = 0; i < historico.Length; i++)
                        {
                            if (historico[i] != null)
                            {
                                if (historico[i].Contains("+"))
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                } else if (historico[i].Contains("-"))
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                } else if (historico[i].Contains("*"))
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                } else if (historico[i].Contains("/"))
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                }

                                Console.WriteLine(historico[i]);
                            }
                        }
                    }

                    Console.ResetColor();
                    break;
                }

                Console.WriteLine("Ok! Digite o primeiro número: ");
                double n1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Agora, digite o segundo número: ");
                double n2 = double.Parse(Console.ReadLine());

                switch (operacao)
                {
                    case "1":
                        contador = contador + 1;
                        resultado = n1 + n2;
                        Console.WriteLine("O resultado da operação é: " + resultado);
                        stringAux = n1 + " + " + n2 + " = " + resultado;
                        historico[contadorAux] = stringAux;
                        contadorAux = contadorAux + 1;
                        break;

                    case "2":
                        contador = contador + 1;
                        resultado = n1 - n2;
                        Console.WriteLine("O resultado da operação é: " + resultado);
                        stringAux = n1 + " - " + n2 + " = " + resultado;
                        historico[contadorAux] = stringAux;
                        contadorAux = contadorAux + 1;
                        break;

                    case "3":
                        contador = contador + 1;
                        resultado = n1 * n2;
                        Console.WriteLine("O resultado da operação é: " + resultado);
                        stringAux = n1 + " * " + n2 + " = " + resultado;
                        historico[contadorAux] = stringAux;
                        contadorAux = contadorAux + 1;
                        break;

                    case "4":
                        if (n2 == 0)
                        {
                            Console.WriteLine("0 não pode ser divisor!");
                        }
                        else
                        {
                            contador = contador + 1;
                            resultado = n1 / n2;
                            Console.WriteLine("O resultado da operação é: " + Math.Round(resultado, 2));
                            stringAux = n1 + " / " + n2 + " = "+resultado;
                            historico[contadorAux] = stringAux;
                            contadorAux = contadorAux + 1;
                        }

                        break;

                }

                Console.WriteLine("Deseja realizar outra operação? Digite:\n0- Não\n1- Sim");
                continuar = Console.ReadLine();

                while (continuar != "0" && continuar != "1" && continuar != "3")
                {
                    Console.WriteLine("Opção inválida! Deseja realizar outra operação? Digite:\n0- Não\n1- Sim");
                    continuar = Console.ReadLine();
                }

            } while (continuar == "1");
        }
    }
}
