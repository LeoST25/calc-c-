using System;

namespace Calculadora
{
    class Calculadora
    {
        public static void Main(string[] args)
        {
            bool exibirMenu = true;

            while (exibirMenu)
            {
                Console.WriteLine("Escolha uma operação:");
                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Dividir");
                Console.WriteLine("4 - Multiplicar");

                string opcao = Console.ReadLine();

                if (opcao == Convert.ToString(0))
                {
                    Console.WriteLine("Programa encerrado");
                    break;
                }

                Console.WriteLine("Digite o primeiro número: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o segundo número: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int resultado = 0;

                switch (opcao)
                {
                    case "1":
                        resultado = Somar(num1, num2);
                        Console.WriteLine($"{num1} + {num2} = {resultado}");
                        break;

                    case "2":
                        resultado = Subtrair(num1, num2);
                        Console.WriteLine($"{num1} - {num2} = {resultado}");
                        break;

                    case "3":
                        if (num2 != 0)
                        {
                            resultado = Dividir(num1, num2);
                            Console.WriteLine($"{num1} / {num2} = {resultado}");
                        }
                        else
                        {
                            Console.WriteLine("Erro: Divisão por zero não é permitida.");
                        }
                        break;

                    case "4":
                        resultado = Multiplicar(num1, num2);
                        Console.WriteLine($"{num1} * {num2} = {resultado}");
                        break;

                    default:
                        Console.WriteLine("Opção inválida, o programa se encerrou");
                        Environment.Exit(0);
                        break;
                }
            }
        }

        public static int Somar(int a, int b)
        {
            return a + b;
        }

        public static int Subtrair(int a, int b)
        {
            return a - b;
        }

        public static int Dividir(int a, int b)
        {
            return a / b;
        }

        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }
}

