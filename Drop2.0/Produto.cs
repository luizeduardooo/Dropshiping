﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drop2._0
{
    internal class Produto
    {
        public string nome { get; set; }
        public string descricao { get; set; }
        public string tamanho { get; set; }
        public double valor { get; set; }
        public string time { get; set; }

        public Produto()
        {
            CriarProduto();
        }

        public void CriarProduto()
        {
            Console.Write("Digite o nome do produto: ");
            nome = Console.ReadLine();
            Console.Write("Digite uma descrição do produto: ");
            descricao = Console.ReadLine();
            Console.Write("Digite o tamanho do produto: ");
            tamanho = Console.ReadLine();
            Console.Write("Digite o valor do produto: ");
            valor = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o nome do Time: ");
            time = Console.ReadLine();
            time.ToLower();
        }
        public static void AdicionarAoCarrinho(List<Produto> lista1, List<Produto> lista2)
        {

            Console.WriteLine("Deseja adicionar algum produto carrinho? (S/N)");
            string resposta = Console.ReadLine();
            resposta.ToLower();
            if (resposta == "s")
            {
                Console.WriteLine("Digite o código do produto que deseja adicionar: ");
                int indice = Convert.ToInt32(Console.ReadLine());
                lista1.Add(lista2[indice]);
                Console.Clear();
                Program.MenuProdutos();
            }
            else
            {
                Program.MenuProdutos();
            }
        }
        public static void ListarProdutos(List<Produto> lista, string time = "")
        {
            List<Produto> produtosFiltrados = new List<Produto>(); 
            produtosFiltrados = lista.FindAll(e => e.time == time);
            if (produtosFiltrados.Count() == 0)
            {
                Console.WriteLine("Não há produtos adicionados!");
                Console.WriteLine("\nTecle ENTER para retornar ao menu de produtos.");
                Console.ReadLine();
            }
            else
            {
                produtosFiltrados = lista;
                for (int i = 0; i < produtosFiltrados.Count(); i++)
                {
                    Console.Write($"{i + 1} -");
                    Console.WriteLine($"{lista[i].nome} - {lista[i].descricao}\nTamanho: {lista[i].tamanho}\nValor: R${lista[i].valor}");
                    Console.WriteLine();
                }
            }
        }
        public static void AlterarProduto(List<Produto> lista, string mensagem = "")
        {
            Produto.ListarProdutos(lista);
            Console.Write("Digite o código do produto que deseja alterar: ");
            int indice = Convert.ToInt32(Console.ReadLine());
            lista[indice - 1].CriarProduto();
        }
        public static void RetirarProduto(List<Produto> lista)
        {
            Console.Clear();
            Produto.ListarProdutos(lista);
            Console.WriteLine("Deseja retirar algum produto? (S/N)");
            string resposta = Console.ReadLine();
            resposta.ToLower();
            if (resposta == "s")
            {
                Console.Write("Digite o código do produto que deseja retirar: ");
                int indice = Convert.ToInt32(Console.ReadLine());
                lista.RemoveAt(indice - 1);
            }
            else
            {
                Program.MostrarMenu();
            }
        }
        public static void CriarProdutoVendedor(List<Produto> lista)
        {
            Produto novoProduto = new Produto();
            lista.Add(novoProduto);
            Program.MenuVendedor();
        }
    }
}
