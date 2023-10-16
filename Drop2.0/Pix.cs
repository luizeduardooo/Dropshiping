using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySql.Data;

namespace Drop2._0
{
    public class Pix : Forma_de_pagamento
    {
        public static string ChaveAleatoria { get; set; }
        public static string ChaveEmail { get; set; }
        public static int Cnpj { get; set; }

        public static void PagamentoPix()
        {
            Console.WriteLine();
            Console.WriteLine("Escolha a chave pix que deseja pagar: 1: Chave aleatória, 2: E-Mail, 3: CNPJ");
            Console.Write("Digite a opção desejada: ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {

                case 1:
                    Console.WriteLine();
                    Console.WriteLine($"A sua compra ficou no valor de: R${ValorTotal:N2}");
                    Console.WriteLine("Nossa chave aleatória é: 'q32b8y1s6w0z4v9t' ");

                    break;

                case 2:
                    Console.WriteLine();
                    Console.WriteLine($"A sua compra ficou no valor de: R${ValorTotal:N2}");
                    Console.WriteLine("Nossa Chave do email é: 'Dropdosguri@Gmail.com' ");
                    break;

                case 3:
                    Console.WriteLine();
                    Console.WriteLine($"A sua compra ficou no valor de: R${ValorTotal:N2}");
                    Console.WriteLine("Nosso CNJP é: '12.345.678/0001-90' ");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("O Drop dos guri agradece a preferência, volte sempre!! =) ");
            Console.Write("\nPressione ENTER para sair do sistema! ");
            Console.ReadLine();
        }
    }

}
