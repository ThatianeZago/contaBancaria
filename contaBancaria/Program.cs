using System;

namespace contaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("» » » » » » MENU « « « « « «");
            Console.WriteLine("Digite a operação que deseja efetuar: ");
            Console.WriteLine("1 - Criar conta");
            Console.WriteLine("2 - Ver o saldo");
            Console.WriteLine("3 - Fazer débito");
            Console.WriteLine("4 - Fazer crédito");
            Console.WriteLine("0 - SAIR...");
            int op = int.Parse(Console.ReadLine());

            do
            {
                switch (op)
                {
                    case 1:
                        Console.WriteLine(" Criar conta");
                        Console.WriteLine("Informe qual o tipo de conta deseja criar.");
                        Console.WriteLine("1 - Conta Pouçança");
                        Console.WriteLine("2 - Conta Corrente");
                        int val1 = int.Parse(Console.ReadLine());
                        if (val1 == 1)
                        {
                            Console.WriteLine("Selecionou conta corrente");
 
                        }
                        else
                            Console.WriteLine("Selecionou conta poupança");
                        break;
                    case 2:
                        Console.WriteLine("2 - Ver o saldo");
                        break;
                    case 3:
                        Console.WriteLine("3 - Fazer débito");
                        break;
                    case 4:
                        Console.WriteLine("4 - Fazer crédito");
                        break;
                    case 0:
                        Console.WriteLine();
                        break;
                }
            } while (op == 0);

        }
    }
}
