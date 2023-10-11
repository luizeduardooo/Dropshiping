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
        static string caminho = @"C:\\Users\\eduardo.rauber\\Drop\\listaProdutos.txt";
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
            Console.WriteLine();
            Console.WriteLine(mensagem);
            Console.WriteLine();
            switch (Menu.MenuPrincipal())
            {
                case "0":
                    string json = JsonSerializer.Serialize(produtos);
                    StreamWriter stream = File.CreateText(caminho);
                    stream.WriteLine(json);
                    stream.Close();
                    break;
                case "1":
                    Cliente.CadastrarCliente(clientes);
                    break;
                case "2":
                    MenuProdutos();
                    break;
                case "3":
                    if (carrinho.Count() > 0)
                    {
                        ProdutoModel.RetirarProduto(carrinho);
                        MostrarMenu();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nNão há produtos adicionados!");
                        Console.Write("Tecle ENTER para retornar ao menu principal.");
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
        public static void MenuVendedor(string mensagem = "")
        {
            
            Console.Clear();
            Console.WriteLine(mensagem);
            Console.WriteLine();
            switch (Menu.MenuVendedor())
            {
                case "0":
                    MostrarMenu();
                    break;
                case "1":
                    Produto.CriarProduto(produtos);
                    break;
                case "2":
                    ProdutoModel.ListarProdutos(produtos);
                    MenuVendedor();
                    break;
                case "3":
                    ProdutoModel.AlterarProduto(produtos);
                    
                    break;
                case "4":
                    ProdutoModel.RetirarProduto(produtos);
                    MenuVendedor("Produto removido com sucesso!");
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
                    ProdutoModel.ListarProdutos(produtos, "vasco");
                    if (produtos.Count() > 0)
                    {
                        ProdutoModel.AdicionarAoCarrinho(carrinho, produtos);
                    }
                    break;
                case "2":
                    Console.Clear();
                    ProdutoModel.ListarProdutos(produtos, "flamengo");
                    if (produtos.Count() > 0)
                    {
                        ProdutoModel.AdicionarAoCarrinho(carrinho, produtos);
                    }
                    break;
                case "3":
                    Console.Clear();
                    ProdutoModel.ListarProdutos(produtos, "brasil");
                    if (produtos.Count() > 0)
                    {
                        ProdutoModel.AdicionarAoCarrinho(carrinho, produtos);
                    }
                    break;
                case "4":
                    Console.Clear();
                    ProdutoModel.ListarProdutos(produtos, "real madrid");
                    if (produtos.Count() > 0)
                    {
                        ProdutoModel.AdicionarAoCarrinho(carrinho, produtos);
                    }
                    break;
                case "5":
                    Console.Clear();
                    ProdutoModel.ListarProdutos(produtos, "roma");
                    if (produtos.Count() > 0)
                    {
                        ProdutoModel.AdicionarAoCarrinho(carrinho, produtos);
                    }
                    break;
                case "6":
                    Console.Clear();
                    ProdutoModel.ListarProdutos(produtos, "chelsea");
                    if (produtos.Count() > 0)
                    {
                        ProdutoModel.AdicionarAoCarrinho(carrinho, produtos);
                    }
                    break;
                case "7":
                    Console.Clear();
                    ProdutoModel.ListarProdutos(produtos, "al nassr");
                    if (produtos.Count() > 0)
                    {
                        ProdutoModel.AdicionarAoCarrinho(carrinho, produtos);
                    }
                    break;
                case "8":
                    Console.Clear();
                    ProdutoModel.ListarProdutos(produtos, "al hilal");
                    if (produtos.Count() > 0)
                    {
                        ProdutoModel.AdicionarAoCarrinho(carrinho, produtos);
                    }
                    break;
                case "9":
                    Console.Clear();
                    ProdutoModel.ListarProdutos(produtos, "paris saint-germain");
                    if (produtos.Count() > 0)
                    {
                        ProdutoModel.AdicionarAoCarrinho(carrinho, produtos);
                    }
                    break;
                case "10":
                    Console.Clear();
                    ProdutoModel.ListarProdutos(produtos, "arsenal");
                    if (produtos.Count() > 0)
                    {
                        ProdutoModel.AdicionarAoCarrinho(carrinho, produtos);
                    }
                    break;
                case "11":
                    Console.Clear();
                    ProdutoModel.ListarProdutos(produtos, "barcelona");
                    if (produtos.Count() > 0)
                    {
                        ProdutoModel.AdicionarAoCarrinho(carrinho, produtos);
                    }
                    break;
                default:
                    Console.WriteLine("Opção Inválida!");
                    Console.WriteLine("Tecle ENTER para retornar ao menu");
                    Console.ReadLine();
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