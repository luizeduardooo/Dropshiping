using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Drop2._0
{
    class Program
    {
        static void MenuVendedor()
        {
            Console.Clear();
            switch (Menu.MenuVendedor())
            {
                case "0":
                    MostrarMenu();
                    break;
                case "1":
                    CriarProduto();
                    break;
                case "2":
                    AlterarProduto(produtos);
                    break;
                case "3":
                    RetirarProduto(produtos);
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
        public static void CadastrarCliente()
        {
            Cliente novoCliente = new Cliente();
            clientes.Add(novoCliente);
            MostrarMenu($"{novoCliente.nome} bem-vindo(a)! ");
            
        }
        public static void ListarCliente()
        {
            for (int id = 0; id < clientes.Count; id++)
            {
                Console.WriteLine($"{id+1} - {clientes[id].nome}, CPF {clientes[id].cpf}");
            }
            Console.WriteLine("Tecle Enter para continuar");
            Console.ReadLine();
            MostrarMenu();
        }
        public static void ListarProdutos(List<Produto> lista)
        {
            for (int i = 0; i < lista.Count(); i++)
            {
                Console.Clear();
                Console.Write($"{i+1} -");
                Produto.MostrarProduto(produtos, i);
                Console.WriteLine();
            }
        }
        public static void AlterarProduto(List<Produto> lista, string mensagem = "")
        {
            ListarProdutos(lista);
            Console.Write("Digite o código do produto que deseja alterar: ");
            int indice = Convert.ToInt32(Console.ReadLine());
            lista[indice-1].CriarProduto();
        }
        public static void RetirarProduto(List<Produto> lista)
        {
            Console.Clear();
            ListarProdutos(lista);
            Console.WriteLine("Deseja retirar algum produto? (S/N)");
            string resposta = Console.ReadLine();
            resposta.ToLower();
            if (resposta == "s") {
                Console.Write("Digite o código do produto que deseja retirar: ");
                int indice = Convert.ToInt32(Console.ReadLine());
                lista.RemoveAt(indice - 1);
            }
            else 
            { 
                MostrarMenu(); 
            }
        } 
        public static void CriarProduto()
        {
            Produto novoProduto = new Produto();
            produtos.Add(novoProduto);
            MenuVendedor();
        }
        static List<Cliente> clientes = new List<Cliente>();
        static List<Produto> produtos = new List<Produto>();
        static List<Produto> carrinho = new List<Produto>();

        static void Main(string[] args)
        {
            StreamWriter listaProdutos;
            // string caminho = "C:\\users\\eduardo.rauber\\"
            MostrarMenu();
            Console.ReadLine();

        }
        static void MostrarMenu(string mensagem = "")
        {
            Console.Clear();
            Console.WriteLine(mensagem);
            switch (Menu.MenuPrincipal())
            {
                case "0":
                    break;
                case "1":
                    CadastrarCliente();
                    break;
                case "2":
                    MenuProdutos();
                    break;
                case "3":
                    ListarProdutos(carrinho);
                    RetirarProduto(carrinho);
                    break;
                case "4":
                    break;
                case "9":
                    MenuVendedor();
                    break;
                case "a":
                    ListarCliente();
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

