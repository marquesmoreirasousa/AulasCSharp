using System;
using System.Globalization;

namespace PrimeiroPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            //Possibilidades de impressão e problemas com regionalidade. 23,35 -> 23.35
            //string teste = Console.ReadLine().Replace(',', '.');

            //decimal x = Convert.ToDecimal(teste, CultureInfo.InvariantCulture);
            //Console.WriteLine(x.ToString("N1"));
            //Console.WriteLine("x = {0:f4} \tTeste: {1}", x, teste);
            //Criar um programa que dado um número inserido pelo usuário, dizer se é primo ou não.

            int n, num;
            do
            {
                Console.WriteLine("Digite 0 para sair.");
                Console.WriteLine("Digite 1 para Quadrado.");
                Console.WriteLine("Digite 2 para meia Árvore para baixo.");
                Console.WriteLine("Digite 3 para Divisão.");
                Console.WriteLine("Digite 4 para meia Árvore em pé.");
                Console.WriteLine("Digite 5 para verificar se é Primo.");
                num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 0:
                        Console.Clear();
                        break;
                    case 1:
                        Console.WriteLine("Entre com um número: ");
                        n = int.Parse(Console.ReadLine());

                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 2:
                        Console.WriteLine("Entre com um número: ");
                        n = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < n - i; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        Console.WriteLine();
                        num = 0;
                        int cont = 1;
                        Console.WriteLine("Entre com o número máximo a ser testado:");
                        num = int.Parse(Console.ReadLine());
                        while (cont <= num)
                        {
                            if (cont % 3 == 0 && cont % 5 == 0)
                            {
                                Console.WriteLine("{0} é divisível por 3 e por 5.", cont);
                            }
                            cont++;
                        }
                        break;
                    case 4:
                        Console.WriteLine("Entre com um número: ");
                        n = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        for (int i = 1; i <= n; i++)
                        {
                            for (int j = 0; j < n - (n - i); j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 5:
                        int numCorrente, div;
                        Console.Write("Entre com o número a ser testado: \n");
                        numCorrente = int.Parse(Console.ReadLine());

                        div = 0;
                        for (int a = 2; a < numCorrente; a++)
                        {
                            if (numCorrente % a == 0)
                            {
                                div++;
                                break;
                            }
                        }
                        if (div == 0)
                            Console.Write(numCorrente + " é primo!\n");
                        else
                            Console.Write(numCorrente + " não é primo!\n");

                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (num != 0);
        }
    }
}
