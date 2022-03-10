using System;

namespace Calculadora.ConsoleApp
{
    internal partial class Program
    {
        public class Calculadora
        {
            int indiceHistoricoCalculadora = 0;

            public Historico[] historicoCalculadora;

            public double Somar(double numero1, double numero2)
            {
                Historico historico = new Historico();
                double soma = numero1 + numero2;
                string calculoString = numero1 + " + " + numero2 + " = " + soma;
                historico.calculoRealizado = calculoString;
                historicoCalculadora[indiceHistoricoCalculadora] = historico;
                indiceHistoricoCalculadora++;

                return soma;
            }

            public double Subtrair(double numero1, double numero2)
            {
                Historico historico = new Historico();
                double subtracao = numero1 - numero2;
                string calculoString = numero1 + " - " + numero2 + " = " + subtracao;
                historico.calculoRealizado = calculoString;
                historicoCalculadora[indiceHistoricoCalculadora] = historico;
                indiceHistoricoCalculadora++;

                return subtracao;
            }

            public double Multiplicar(double numero1, double numero2)
            {
                 Historico historico = new Historico();
                 double multiplicacao = numero1 * numero2;
                 string calculoString = numero1 + " * " + numero2 + " = " + multiplicacao;
                 historico.calculoRealizado = calculoString;
                 historicoCalculadora[indiceHistoricoCalculadora] = historico;
                indiceHistoricoCalculadora++;

                 return multiplicacao;
            }

            public double Dividir(double numero1, double numero2)
            {
                if (numero2 == 0)
                {
                    Console.WriteLine("Impossível dividir por 0!");
                    Console.WriteLine();
                    return 0;
                }
                else
                {
                    Historico historico = new Historico();
                    double divisao = numero1 / numero2;
                    string calculoString = numero1 + " / " + numero2 + " = " + divisao;
                    historico.calculoRealizado = calculoString;
                    historicoCalculadora[indiceHistoricoCalculadora] = historico;
                    indiceHistoricoCalculadora++;

                    return divisao;
                }
            }

            public void ExibirHistorico()
            {
                for(int i=0; i < historicoCalculadora.Length; i++)
                {
                    if (historicoCalculadora[i] == null)
                    {
                        continue;
                    } else
                    {
                        Console.WriteLine("Operação: " + historicoCalculadora[i].calculoRealizado);
                    }
                }
            }
        }
    }
}
