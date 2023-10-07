using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

namespace Drop2._0
{
    class Program
    {
        static List<Cliente> clientes = new List<Cliente>();
        static List<Produto> produtos = new List<Produto>();
        static List<Produto> carrinho = new List<Produto>();
        static string caminho = @"C:\\users\\eduardo.rauber\\Drop\\listaProdutos.txt";
        static void Main(string[] args)
        {
            Console.Title = "Dropshipping dos Guris";
            if (File.Exists(caminho))
            {
                StreamReader streamReader = new StreamReader(caminho);
                string json = streamReader.ReadToEnd();
                produtos = JsonSerializer.Deserialize<List<Produto>>(json);
                streamReader.Close();
                MostrarMenu();
            }
            Console.ReadLine();
        }
        public static void MostrarMenu(string mensagem = "")
        {
            Console.Clear();
            Console.WriteLine(mensagem);
            switch (Menu.MenuPrincipal())
            {
                case "0":
                    string json = JsonSerializer.Serialize(produtos);
                    StreamWriter stream = File.CreateText(caminho);
                    stream.WriteLine(json);
                    stream.Close();
                    return;
                case "1":
                    Cliente.CadastrarCliente(clientes);
                    break;
                case "2":
                    MenuProdutos();
                    break;
                case "3":
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
                    Forma_de_pagamento.CalcularValor(carrinho);
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
        public static void MenuVendedor()
        {
            Console.Clear();
            switch (Menu.MenuVendedor())
            {
                case "0":
                    MostrarMenu();
                    break;
                case "1":
                    Produto.CriarProduto(produtos);
                    MenuVendedor();
                    break;
                case "2":
                    Produto.ListarProdutos(produtos);
                    MenuVendedor();
                    break;
                case "3":
                    Produto.AlterarProduto(produtos, "Produto alterado com sucesso!");
                    MenuVendedor();
                    break;
                case "4":
                    
                    Produto.RetirarProduto(produtos, "Produto removido com sucesso!");

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
                    Produto.ListarProdutos(produtos, "real madrid");
                    if (produtos.Count() > 0)
                    {
                        Produto.AdicionarAoCarrinho(carrinho, produtos);
                    }
                    MenuProdutos();
                    break;
                case "5":
                    Console.Clear();
                    Produto.ListarProdutos(produtos, "roma");
                    if (produtos.Count() > 0)
                    {
                        Produto.AdicionarAoCarrinho(carrinho, produtos);
                    }
                    MenuProdutos();
                    break;
                case "6":
                    Console.Clear();
                    Produto.ListarProdutos(produtos, "chelsea");
                    if (produtos.Count() > 0)
                    {
                        Produto.AdicionarAoCarrinho(carrinho, produtos);
                    }
                    MenuProdutos();
                    break;
                case "7":
                    Console.Clear();
                    Produto.ListarProdutos(produtos, "al nassr");
                    if (produtos.Count() > 0)
                    {
                        Produto.AdicionarAoCarrinho(carrinho, produtos);
                    }
                    MenuProdutos();
                    break;
                case "8":
                    Console.Clear();
                    Produto.ListarProdutos(produtos, "al hilal");
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
                    MostrarMenu();
                    break;
                case "1":                   
                    Boleto.PagamentoBoleto();
                    break;
                case "2":
                    Credito.PagamentoCredito();
                    break;
                case "3":
                    Pix.PagamentoPix();
                    break;
            }
        }
    }
}