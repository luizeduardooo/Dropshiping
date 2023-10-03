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
                    Produto.ListarProdutos(produtos);
                    MenuVendedor();
                    break;
                case "3":
                    Produto.AlterarProduto(produtos);
                    break;
                case "4":
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
                    Console.Clear();
                    Produto.ListarProdutos(produtos, "vasco");
                    if (produtos.Count() > 0)
                    {
                        Produto.AdicionarAoCarrinho(carrinho, produtos);
                    }
                    MenuProdutos();
                    break;
                case "2":
                    Console.Clear();
                    Produto.ListarProdutos(produtos, "flamengo");
                    if (produtos.Count() > 0)
                    {
                        Produto.AdicionarAoCarrinho(carrinho, produtos);
                    }
                    MenuProdutos();
                    break;
                case "3":
                    Console.Clear();
                    Produto.ListarProdutos(produtos, "brasil");
                    if (produtos.Count() > 0)
                    {
                        Produto.AdicionarAoCarrinho(carrinho, produtos);
                    }
                    MenuProdutos();
                    break;
                case "4":
                    Console.Clear();
                    Produto.ListarProdutos(produtos, "Real Madrid");
                    if (produtos.Count() > 0)
                    {
                        Produto.AdicionarAoCarrinho(carrinho, produtos);
                    }
                    MenuProdutos();
                    break;
                case "5":
                    Console.Clear();
                    Produto.ListarProdutos(produtos, "Roma");
                    if (produtos.Count() > 0)
                    {
                        Produto.AdicionarAoCarrinho(carrinho, produtos);
                    }
                    MenuProdutos();
                    break;
                case "6":
                    Console.Clear();
                    Produto.ListarProdutos(produtos, "Chelsea");
                    if (produtos.Count() > 0)
                    {
                        Produto.AdicionarAoCarrinho(carrinho, produtos);
                    }
                    MenuProdutos();
                    break;
                case "7":
                    Console.Clear();
                    Produto.ListarProdutos(produtos, "Al Nassr");
                    if (produtos.Count() > 0)
                    {
                        Produto.AdicionarAoCarrinho(carrinho, produtos);
                    }
                    MenuProdutos();
                    break;
                case "8":
                    Console.Clear();
                    Produto.ListarProdutos(produtos, "Al Hilal");
                    if (produtos.Count() > 0)
                    {
                        Produto.AdicionarAoCarrinho(carrinho, produtos);
                    }
                    MenuProdutos();
                    break;
                case "9":
                    Console.Clear();
                    Produto.ListarProdutos(produtos, "paris saint-germain");
                    if (produtos.Count() > 0)
                    {
                        Produto.AdicionarAoCarrinho(carrinho, produtos);
                    }
                    MenuProdutos();
                    break;
                case "10":
                    Console.Clear();
                    Produto.ListarProdutos(produtos, "arsenal");
                    if (produtos.Count() > 0)
                    {
                        Produto.AdicionarAoCarrinho(carrinho, produtos);
                    }
                    MenuProdutos();
                    break;
                case "11":
                    Console.Clear();
                    Produto.ListarProdutos(produtos, "barcelona");
                    if (produtos.Count() > 0)
                    {
                        Produto.AdicionarAoCarrinho(carrinho, produtos);
                    }
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
        public static void MenuPagamento()
        {
            switch (Menu.MenuPagamento())
            {
                case "0":
                    break;
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
            }
        }
        static void Main(string[] args)
        {
            Console.Title = "Dropshipping dos Guris";
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
                    return;
                case "1":
                    Cliente.CadastrarCliente(clientes);
                    break;
                case "2":
                    MenuProdutos();
                    break;
                case "3":
                    Produto.ListarProdutos(carrinho);
                    if (carrinho.Count() > 0)
                    {
                        Produto.RetirarProduto(carrinho);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Não há produtos adicionados!");
                        Console.WriteLine("\nTecle ENTER para retornar ao menu principal.");
                        Console.ReadLine();
                        MostrarMenu();
                        break;
                    }
                case "4":
                    MenuPagamento();
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
            Console.Clear();
            Console.Write("Você saiu!");
            Console.WriteLine();
            Console.WriteLine("\nObrigado por visitar a loja Dropshiping dos Guris!");
        }
    }
}

