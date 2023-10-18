using Drop2._0.Model;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Drop2._0.Entity;

namespace Drop2._0
{ 
    public class Menu
    {
        private readonly Boleto _boleto = new Boleto();
        private Pix _pix = new Pix();
        private Credito _credito = new Credito();
        private Cliente _cliente = new Cliente();
        private ProdutoModel _produtoModel = new ProdutoModel();
        private Produto _produto = new Produto();
        private List<Cliente> clientes = new List<Cliente>();
        private List<Produto> produtos = new List<Produto>();
        private List<Produto> carrinho = new List<Produto>();
        public string caminho = @"C:\\Users\\eduardo.rauber\\Drop\\listaProdutos.txt";
        public string SwitchMenuPrincipal()
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

        public string SwitchMenuProdutos()
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
        public string SwitchMenuVendedor()
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
        public string SwitchMenuPagamento()
        {
            Console.Clear();
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
        public void MostrarMenu(string mensagem = "")
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(mensagem);
            Console.WriteLine();
            switch (SwitchMenuPrincipal())
            {
                case "0":
                    string json = JsonSerializer.Serialize(produtos);
                    StreamWriter stream = File.CreateText(caminho);
                    stream.WriteLine(json);
                    stream.Close();
                    break;
                case "1":
                    _cliente.CadastrarCliente(clientes);
                    break;
                case "2":
                    MenuProdutos();
                    break;
                case "3":
                    if (carrinho.Count() > 0)
                    {
                        _produtoModel.RetirarProduto(carrinho);
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
                    _cliente.ListarCliente(clientes);
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
        public void MenuVendedor(string mensagem = "")
        {

            Console.Clear();
            Console.WriteLine(mensagem);
            Console.WriteLine();
            switch (SwitchMenuVendedor())
            {
                case "0":
                    MostrarMenu();
                    break;
                case "1":
                    _produto.CriarProduto(produtos);
                    break;
                case "2":
                    _produtoModel.ListarProdutos(produtos);
                    MenuVendedor();
                    break;
                case "3":
                    _produtoModel.AlterarProduto(produtos);

                    break;
                case "4":
                    _produtoModel.RetirarProduto(produtos);
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
        public void MenuProdutos()
        {
            Console.Clear();
            switch (SwitchMenuProdutos())
            {
                case "0":
                    MostrarMenu();
                    break;
                case "1":
                    Console.Clear();
                    _produtoModel.ListarProdutos(produtos, "vasco");
                    if (produtos.Count() > 0)
                    {
                        _produtoModel.AdicionarAoCarrinho(carrinho, produtos);
                    }
                    break;
                case "2":
                    Console.Clear();
                    _produtoModel.ListarProdutos(produtos, "flamengo");
                    if (produtos.Count() > 0)
                    {
                        _produtoModel.AdicionarAoCarrinho(carrinho, produtos);
                    }
                    break;
                case "3":
                    Console.Clear();
                    _produtoModel.ListarProdutos(produtos, "brasil");
                    if (produtos.Count() > 0)
                    {
                        _produtoModel.AdicionarAoCarrinho(carrinho, produtos);
                    }
                    break;
                case "4":
                    Console.Clear();
                    _produtoModel.ListarProdutos(produtos, "real madrid");
                    if (produtos.Count() > 0)
                    {
                        _produtoModel.AdicionarAoCarrinho(carrinho, produtos);
                    }
                    break;
                case "5":
                    Console.Clear();
                    _produtoModel.ListarProdutos(produtos, "roma");
                    if (produtos.Count() > 0)
                    {
                        _produtoModel.AdicionarAoCarrinho(carrinho, produtos);
                    }
                    break;
                case "6":
                    Console.Clear();
                    _produtoModel.ListarProdutos(produtos, "chelsea");
                    if (produtos.Count() > 0)
                    {
                        _produtoModel.AdicionarAoCarrinho(carrinho, produtos);
                    }
                    break;
                case "7":
                    Console.Clear();
                    _produtoModel.ListarProdutos(produtos, "al nassr");
                    if (produtos.Count() > 0)
                    {
                        _produtoModel.AdicionarAoCarrinho(carrinho, produtos);
                    }
                    break;
                case "8":
                    Console.Clear();
                    _produtoModel.ListarProdutos(produtos, "al hilal");
                    if (produtos.Count() > 0)
                    {
                        _produtoModel.AdicionarAoCarrinho(carrinho, produtos);
                    }
                    break;
                case "9":
                    Console.Clear();
                    _produtoModel.ListarProdutos(produtos, "paris saint-germain");
                    if (produtos.Count() > 0)
                    {
                        _produtoModel.AdicionarAoCarrinho(carrinho, produtos);
                    }
                    break;
                case "10":
                    Console.Clear();
                    _produtoModel.ListarProdutos(produtos, "arsenal");
                    if (produtos.Count() > 0)
                    {
                        _produtoModel.AdicionarAoCarrinho(carrinho, produtos);
                    }
                    break;
                case "11":
                    Console.Clear();
                    _produtoModel.ListarProdutos(produtos, "barcelona");
                    if (produtos.Count() > 0)
                    {
                        _produtoModel.AdicionarAoCarrinho(carrinho, produtos);
                    }   
                    break;
                case "teste":
                    _produtoModel.Read();
                    break;
                default:
                    Console.WriteLine("Opção Inválida!");
                    Console.WriteLine("Tecle ENTER para retornar ao menu");
                    Console.ReadLine();
                    break;
            }
        }
        public void MenuPagamento()
        {
            switch (SwitchMenuPagamento())
            {
                case "0":
                    MostrarMenu();
                    break;
                case "1":
                    _boleto.PagamentoBoleto();
                    break;
                case "2":
                    _credito.PagamentoCredito();
                    break;
                case "3":
                    _pix.PagamentoPix();
                    break;
            }
        }
    }
}
