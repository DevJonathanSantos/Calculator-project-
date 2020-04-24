using ConsoleApp1;
using System;
//Danilo nub
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int continuar = 1;

            Calculadora calculadora = new Calculadora();

            do
            {
                calculadora.Operacao = Operador();
                calculadora.Valor1 = Valor("primeiro");
                calculadora.Valor2 = Valor("segundo");
                calculadora.Executar();

                Console.WriteLine(" O resultado é " + calculadora.Resultado.ToString());

                do
                {
                    Console.WriteLine("Deseja efetuar outra operação: ");
                    Console.WriteLine("1 - sim");
                    Console.WriteLine("0 - nao");

                    try
                    {
                        continuar = Convert.ToInt16(Console.ReadLine());


                        if (continuar != 0 && continuar != 1)
                        {
                            Console.WriteLine("Opção invalida");
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Opção invalida");
                    }

                } while (continuar == 1);

            } while (continuar == 1);

        }
        public static Operacao Operador()
        {
            int operacao = 0;

            do
            {
                try
                {
                    operacao = Convert.ToInt32(Console.ReadLine());

                    if (operacao != 1 && operacao != 2 && operacao != 3 && operacao != 4)
                    {
                        Console.WriteLine("Opção invalida!");
                    }
                    else
                    {
                        return (Operacao)operacao;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Opção inválida!");
                }


            } while (operacao != 1 && operacao != 2 && operacao != 3);

            return (Operacao)operacao;
        }


        public static int Valor(string palavra)
        {
            int valor = 0;

            do
            {
                try
                {
                    Console.WriteLine($"Entre o {palavra} valor");

                    return Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Valor invalido!");
                }


            } while (valor == 0);

            return valor;

        }
    }
}
