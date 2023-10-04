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
        public string BandeiraCartao { get; set; }
        private string NumeroCartao;
        private string Senha;
        private string Validacao;
        public double Parcelas { get; set; }
        public double ValorParcelas { get; set; }


        public string numeroCartao
        {
            get { return numeroCartao; }

            set
            {

                if (value.Length == 16)
                    numeroCartao = value;
                else
                    throw new ArgumentException("O número do cartão deve ter 16 dígitos.");
            }


        }

        public string senha
        {
            get { return senha; }

            set
            {

                if (value.Length == 4)
                    senha = value;
                else
                    throw new ArgumentException("O número da senha deve conter 4 dígitos.");
            }


        }

        public string validacao
        {
            get { return validacao; }

            set
            {

                if (value.Length == 3)
                    validacao = value;
                else
                    throw new ArgumentException("O número da validação deve conter 3 dígitos.");
            }


        }

        public void PagamentoCredito()
        {
            Console.WriteLine("Qual a bandeira do cartão?");
            BandeiraCartao = Console.ReadLine();

            Console.WriteLine("Digite o número do seu cartão: ");
            NumeroCartao = Console.ReadLine();

            Console.WriteLine("Digite a validação de três digitos do cartão: ");
            Validacao = Console.ReadLine();
         
                Console.WriteLine("Escolha a forma de parcelamento:");
                Console.WriteLine("1 - À vista");
                Console.WriteLine("2 - 2 parcelas");
                Console.WriteLine("3 - 3 parcelas");
                Console.WriteLine("4 - 4 parcelas ou mais");
                Parcelas = Convert.ToDouble(Console.ReadLine());

                switch (Parcelas)
                {
                    case 1:
                        Console.WriteLine($"Total a pagar: R$ {ValorTotal:N2}");
                        break;

                    case 2:
                        ValorParcelas = ValorTotal / Parcelas;
                        Console.WriteLine($"Valor de cada parcela: R$ {Parcelas:N2}");
                        break;

                    case 3:
                        ValorParcelas = ValorTotal / 3;
                        Console.WriteLine($"Valor de cada parcela: R$ {Parcelas:N2}");
                        break;

                    case 4:
                        Console.WriteLine("Informe a quantidade de parcelas desejada:");
                        Parcelas = Convert.ToInt32(Console.ReadLine());

                        Parcelas = ValorTotal / Parcelas;
                        Console.WriteLine($"Valor de cada parcela: R$ {Parcelas:N2}");
                        break;

                    

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
                    Console.WriteLine($"Compra finalizada no cartão {BandeiraCartao}, no valor de:R${ValorTotal}, números de parcelas:{Parcelas}, valor das parcelas:R${Parcelas}");
                   
            }
        }

}


