using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Drop2._0
{
    class Program
    {
        static List<Cliente> clientes = new List<Cliente>();
        static List<Produto> produtos = new List<Produto>();
        static List<Produto> carrinho = new List<Produto>();
        public static void MenuVendedor()
        {
            Console.Clear();
            switch (Menu.MenuVendedor())
            {
                case "0":
                    MostrarMenu();
                    break;
                case "1":
                    Produto.CriarProdutoVendedor(produtos);
                    break;
                case "2":
                    Produto.AlterarProduto(produtos);
                    break;
                case "3":
                    Produto.RetirarProduto(produtos);
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    Console.WriteLine("Tecle ENTER para retornar ao menu");
                    Console.ReadLine();
                    MenuVendedor();
                    break;
            }
        }
        public static void MenuProdutos()
        {
            Console.Clear();
            switch (Menu.MenuProdutos())
            {
                case "0":
                    MostrarMenu();
                    break;
                case "1":
                    Produto.MostrarProduto(produtos, 0);
                    Produto.AdicionarAoCarrinho(carrinho, produtos, 0);
                    MenuProdutos();
                    break;

                case "2":
                    Produto.MostrarProduto(produtos, 1);
                    Produto.AdicionarAoCarrinho(carrinho, produtos, 1);
                    MenuProdutos();
                    break;
                case "3":
                    Produto.MostrarProduto(produtos, 2);
                    Produto.AdicionarAoCarrinho(carrinho, produtos, 2);
                    MenuProdutos();
                    break;
                case "4":
                    Produto.MostrarProduto(produtos, 3);
                    Produto.AdicionarAoCarrinho(carrinho, produtos, 3);
                    MenuProdutos();
                    break;
                case "5":
                    Produto.MostrarProduto(produtos, 4);
                    Produto.AdicionarAoCarrinho(carrinho, produtos, 4);
                    MenuProdutos();
                    break;
                case "6":
                    Produto.MostrarProduto(produtos, 5);
                    Produto.AdicionarAoCarrinho(carrinho, produtos, 5);
                    MenuProdutos();
                    break;
                case "7":
                    Produto.MostrarProduto(produtos, 6);
                    Produto.AdicionarAoCarrinho(carrinho, produtos, 6);
                    MenuProdutos();
                    break;
                case "8":
                    Produto.MostrarProduto(produtos, 7);
                    Produto.AdicionarAoCarrinho(carrinho, produtos, 7);
                    MenuProdutos();
                    break;
                case "9":
                    Produto.MostrarProduto(produtos, 8);
                    Produto.AdicionarAoCarrinho(carrinho, produtos, 8);
                    MenuProdutos();
                    break;
                case "10":
                    Produto.MostrarProduto(produtos, 9);
                    Produto.AdicionarAoCarrinho(carrinho, produtos, 9);
                    MenuProdutos();
                    break;
                case "11":
                    Produto.MostrarProduto(produtos, 10);
                    Produto.AdicionarAoCarrinho(carrinho, produtos, 10);
                    MenuProdutos();
                    break;
                default:
                    Console.WriteLine("Opção Inválida!");
                    Console.WriteLine("Tecle ENTER para retornar ao menu");
                    Console.ReadLine();
                    MenuProdutos();
                    break;
            }
        }
        static void Main(string[] args)
        {
            StreamWriter listaProdutos;
            // string caminho = "C:\\users\\eduardo.rauber\\"
            MostrarMenu();
            Console.ReadLine();

        }
        public static void MostrarMenu(string mensagem = "")
        {
            Console.Clear();
            Console.WriteLine(mensagem);
            switch (Menu.MenuPrincipal())
            {
                case "0":
                    break;
                case "1":
                    Cliente.CadastrarCliente(clientes);
                    break;
                case "2":
                    MenuProdutos();
                    break;
                case "3":
                    Produto.ListarProdutos(carrinho);
                    Produto.RetirarProduto(carrinho);
                    break;
                case "4":
                    break;
                case "9":
                    MenuVendedor();
                    break;
                case "a":
                    Cliente.ListarCliente(clientes);
                    break;
                default:
                    Console.WriteLine("Escolha inválida!");
                    Console.WriteLine("Tecle ENTER para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    MostrarMenu();
                    break;
            }
        }
    }
}