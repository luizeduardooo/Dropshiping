using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySql.Data;

namespace Drop2._0
{
    public class Boleto : Forma_de_pagamento
    {
        public static string CodigoAleatorio { get; set; }
        public static void PagamentoBoleto()
        {
            Console.Clear();
            Console.WriteLine($"\nO valor do seu pedido ficou: R${ValorTotal:N2}");
            Console.WriteLine("\nAqui está o código para o pagamento do boleto: '34191790000000123456000001111111111539012345' ");
            long numeroPadrao = 3419179000000012345;
            string barcode = GerarCodigoBarra(numeroPadrao);
            Console.WriteLine("\nOu se preferir, leia o código de barras:\n ");
            Console.WriteLine(barcode);
            Console.WriteLine("\nO Drop dos guri agradece a preferência, volte sempre!! =) ");
            Console.Write("\nPressione ENTER para sair do sistema! ");

            Console.ReadLine();
        }  
        static string GerarCodigoBarra(long number)
        {
            string numberStr = number.ToString();
            string barcode = "";

            foreach (char digit in numberStr)
            {
                if (digit == '0')
                {
                    barcode += "|||__";
                }
                else if (digit == '1')
                {
                    barcode += "__|||";
                }
                else if (digit == '2')
                {
                    barcode += "_|_||";
                }
                else if (digit == '3')
                {
                    barcode += "__|_|";
                }
                else if (digit == '4')
                {
                    barcode += "|__||";
                }
                else if (digit == '5')
                {
                    barcode += "|_|__";
                }
                else if (digit == '6')
                {
                    barcode += "|___|";
                }
                else if (digit == '7')
                {
                    barcode += "||_||";
                }
                else if (digit == '8')
                {
                    barcode += "|_|_|";
                }
                else if (digit == '9')
                {
                    barcode += "|__|_";
                }
            }

            return barcode;
        }
    }
}
