using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drop2._0
{
   
    public class Menu
    {
       public static string MenuPrincipal()
        {
            Console.WriteLine("------ MENU PRINCIPAL ------");
            Console.WriteLine();
            Console.WriteLine("1- Cadastre-se aqui");
            Console.WriteLine("2- Lista de Produtos");
            Console.WriteLine("3- Carrinho");
            Console.WriteLine("4- Finalizar Pedido");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("9- Área do vendedor");
            Console.WriteLine("0- Sair");
            Console.WriteLine();
            Console.Write("Digite a opção desejada: ");

            return Console.ReadLine();
        }

        public static string MenuProdutos()
        {
            Console.WriteLine("------ SELEÇÃO DOS TIMES ------");
            Console.WriteLine();
            Console.WriteLine("1- Vasco da Gama");
            Console.WriteLine("2- Flamengo");
            Console.WriteLine("3- Brasil");
            Console.WriteLine("4- Real Madrid");
            Console.WriteLine("5- Roma");
            Console.WriteLine("6- Chelsea");
            Console.WriteLine("7- Al Nassr");
            Console.WriteLine("8- Al Hilal");
            Console.WriteLine("9- Paris Saint-Germain");
            Console.WriteLine("10- Arsenal");
            Console.WriteLine("11- Barcelona ");
            Console.WriteLine();
            Console.WriteLine("0- Retornar ao menu anterior");
            Console.WriteLine();
            Console.Write("Digite a opção desejada: ");

            return Console.ReadLine();
        }

        public static string MenuVendedor()
        {
            Console.WriteLine("------ FERRAMENTAS DO VENDEDOR ------");
            Console.WriteLine();
            Console.WriteLine("1- Cadastrar novo produto");
            Console.WriteLine("2- Lista de Produtos");
            Console.WriteLine("3- Alterar produto");
            Console.WriteLine("4- Remover produto");
            Console.WriteLine();
            Console.WriteLine("0- Retornar ao menu anterior");
            Console.WriteLine();
            Console.Write("Digite a opção desejada: ");

            return Console.ReadLine();
        }
        public static string MenuPagamento()
        {
            Console.WriteLine("------- FORMAS DE PAGAMENTO -------");
            Console.WriteLine();
            Console.WriteLine("1- Boleto");
            Console.WriteLine("2- Crédito");
            Console.WriteLine("3- PIX");
            Console.WriteLine();
            Console.WriteLine("0- Retornar ao menu anterior");
            Console.WriteLine();

            Console.Write("Digite a opção desejada: ");

            return Console.ReadLine();
            
        }
    }
}
