using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Drop2._0
{
    public class Credito : Forma_de_pagamento
    {
        public static string BandeiraCartao { get; set; }
        private static string _numeroCartao;
        private static string _senha;
        private static string _validacao;
        public static double Parcelas { get; set; }
        public static double ValorParcelas { get; set; }


        public static string NumeroCartao
        {
            get { return _numeroCartao; }

            set
            {

                if (value.Length == 16)
                {
                    _numeroCartao = value;
                }
                else
                {
                    Console.WriteLine("O número do cartão deve ter 16 dígitos.");
                    Console.WriteLine("Pressione ENTER para retornar ao menu de pagamento");
                    Console.ReadLine();
                    Program.MenuPagamento();
                }
            }


        }

        public static string Senha
        {
            get { return _senha; }

            set
            {

                if (value.Length == 4)
                    _senha = value;
                else
                    throw new ArgumentException("O número da senha deve conter 4 dígitos.");
            }


        }

        public static string Validacao
        {
            get { return _validacao; }

            set
            {

                if (value.Length == 3)
                {
                    _validacao = value;
                }
                else
                {
                    Console.WriteLine("O CVV deve ter 3 dígitos!");
                    Console.WriteLine("Pressione ENTER para retornar ao menu de pagamento");
                    Console.ReadLine();
                    Program.MenuPagamento();
                }
            }
        }

        public static void PagamentoCredito()
        {
            Console.Clear();
            Console.Write("Digite a bandeira do seu cartão: ");
            BandeiraCartao = Console.ReadLine();

            Console.Write("Digite o número do seu cartão: ");
            NumeroCartao = Console.ReadLine();

            Console.Write("Digite a validação de três digitos do cartão: ");
            Validacao = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Escolha a forma de parcelamento:");
            Console.WriteLine();
            Console.WriteLine("1 - À vista");
            Console.WriteLine("2 - 2 parcelas");
            Console.WriteLine("3 - 3 parcelas");
            Console.WriteLine("4 - 4 parcelas ou mais");
            Console.WriteLine();
            Console.Write("Digite a forma desejada: ");
            Parcelas = Convert.ToDouble(Console.ReadLine());

            switch (Parcelas)
            {
                case 1:
                    Console.WriteLine();
                    Console.WriteLine($"Total a pagar: R$ {ValorTotal:N2}");
                    break;

                case 2:
                    ValorParcelas = ValorTotal / Parcelas;
                    Console.WriteLine();
                    Console.WriteLine($"Valor de cada parcela: R$ {ValorParcelas:N2}");
                    break;

                case 3:
                    ValorParcelas = ValorTotal / 3;
                    Console.WriteLine();
                    Console.WriteLine($"Valor de cada parcela: R$ {ValorParcelas:N2}");
                    break;

                case 4:
                    Console.Write("Informe a quantidade de parcelas desejada: ");
                    Parcelas = Convert.ToInt32(Console.ReadLine());

                    ValorParcelas = ValorTotal / Parcelas;
                    Console.WriteLine();
                    Console.WriteLine($"Valor de cada parcela: R${ValorParcelas:N2}");
                    break;



                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
            Console.WriteLine();
            Console.WriteLine($"Compra finalizada no cartão {BandeiraCartao}, no valor de: R$ {ValorTotal:N2}, números de parcelas: {Parcelas}, valor das parcelas: R${ValorParcelas:N2}");
            Console.WriteLine();
            Console.WriteLine("O Drop dos guri agradece a preferência, volte sempre!! =) ");
            Console.Write("\nPressione ENTER para sair do sistema! ");

            Console.ReadLine();
        }
    }
}


