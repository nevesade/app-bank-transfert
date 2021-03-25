using System;
using System.Collections.Generic;

namespace AppBankTransfert
{
    class Program
    {
        static List<Conta> listaContas = new List<Conta>();
        static void Main(string[] args)
        {


            string opcaoUsuario = ObterOpcaoUsusario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        //Listar Contas
                        ListarContas();
                        break;
                    case "2":
                        //Inserir Contas
                        InserirConta();
                        break;
                    case "3":
                        //Transferir
                        break;
                    case "4":
                        //Sacar
                        break;
                    case "5":
                        //Depositar 
                        break;
                    case "C":
                        //Limpar Tela
                        break;

                    default:

                        throw new ArgumentOutOfRangeException();


                }

                opcaoUsuario = ObterOpcaoUsusario();
            }

            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }


        private static void InserirConta()
        {
            Console.WriteLine("Inserir nova conta");

            Console.Write("Digite 1 para conta Fisica ou 2 para Juridica: ");
            int entradaTipoConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o Nome do Cliente: ");
            string entradaNome = Console.ReadLine();

            Console.Write("Digite o Saldo Inicial: ");
            double entradaSaldo = double.Parse(Console.ReadLine());

            Console.Write("Digite o Crédito: ");
            double entradaCredito = double.Parse(Console.ReadLine());


            Conta novaconta = new Conta(tipoConta: (TipoConta)entradaTipoConta,
                                        saldo: entradaSaldo,
                                        credito: entradaCredito,
                                        nome: entradaNome);

            listaContas.Add(novaconta);                
        }


        private static void ListarContas(){

                Console.WriteLine("Listar contas");

                if(listaContas.Count == 0){
                    Console.WriteLine("Nenhuma conta registada.");
                    return;
                }


                for (int i = 0; i < listaContas.Count; i++){

                    Conta conta = listaContas[i];
                    Console.WriteLine("#0 - ", i);
                    Console.WriteLine(conta);
                }
            
        }

      


        private static string ObterOpcaoUsusario()
        {

            Console.WriteLine();
            Console.WriteLine("DIO Bank a seu dispo!!!");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1- Listar contas");
            Console.WriteLine("2- Inserir nova conta");
            Console.WriteLine("3- Transferir");
            Console.WriteLine("4- Sacar");
            Console.WriteLine("5- Depositar");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;

        }
    }
}
