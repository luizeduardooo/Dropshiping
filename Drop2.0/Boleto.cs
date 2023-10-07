using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drop2._0
{
    public class Boleto : Forma_de_pagamento
    {
        public static string CodigoAleatorio { get; set; }
        public static void PagamentoBoleto()
        {
            Console.WriteLine($"O valor do seu pedido ficou: R${ValorTotal:N2}");
            Console.WriteLine("Aqui está o código para o pagamento do boleto: '34191790000000123456000001111111111539012345' ");

            Console.WriteLine("O Drop dos guri agradece a preferência, volte sempre!! =) ");

            Console.ReadLine();
            Program.MostrarMenu();
        }
    }
}
