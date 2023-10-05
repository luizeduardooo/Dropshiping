using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drop2._0
{
    internal class Pix:Forma_de_pagamento
    {
        public string ChaveAleatoria { get; set; }
        public string ChaveEmail { get; set; }
        public int Cnpj { get; set; }





        public void PagamentoPix()
        {
            Console.WriteLine("Escolha a chave pix que deseja pagar: 1: Chave aleatória, 2: E-Mail, 3: CNPJ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch(opcao) {

                case 1: 
                        Console.WriteLine($"A sua compra ficou no valor de: R${ValorTotal:N2}");
                        Console.WriteLine("Nossa chave aleatória é: 'q32b8y1s6w0z4v9t' ");

                    break;

                case 2: 
                        Console.WriteLine($"A sua compra ficou no valor de: R${ValorTotal:N2}");
                        Console.WriteLine("Nossa Chave do email é: 'Dropdosguri@Gmail.com' ");
                    break;

                case 3:
                    Console.WriteLine($"A sua compra ficou no valor de: R${ValorTotal:N2}");
                    Console.WriteLine("Nosso CNJP é: '12.345.678/0001-90' ");
                    break;
            }

                 Console.WriteLine("O Drop dos guri agradece a preferência, volte sempre!! =) ");
                Console.ReadLine();
        }
    }

}
