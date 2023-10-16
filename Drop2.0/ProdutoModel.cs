using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySql.Data;

namespace Drop2._0
{
    public class ProdutoModel
    {
        public static void ListarProdutos(List<Produto> lista, string time = "")
        {
            List<Produto> produtosFiltrados = new List<Produto>();
            produtosFiltrados = lista;
            if (!string.IsNullOrEmpty(time))
            {
                produtosFiltrados = lista.FindAll(e => e.time == time);
            }
            if (produtosFiltrados.Count == 0)
            {
                Console.WriteLine("Não há produtos adicionados!");
                Console.Write("Tecle ENTER para retornar ao menu de produtos. ");
                Console.ReadLine();
            }
            else
            {
                for (int i = 0; i < produtosFiltrados.Count; i++)
                {
                    Console.Write($"{produtosFiltrados[i].id} - ");
                    Console.WriteLine($"{produtosFiltrados[i].nome} - {produtosFiltrados[i].descricao}\nTamanho: {produtosFiltrados[i].tamanho}\nValor: R${produtosFiltrados[i].valor}");
                    Console.WriteLine();
                }
                Console.Write("Pressione ENTER para continuar! ");
                Console.ReadLine();
            }
        }
        public static void AlterarProduto(List<Produto> lista)
        {
            ListarProdutos(lista);
            Console.Write("Digite o código do produto que deseja alterar: ");
            string id = Console.ReadLine();
            Produto produtoSelecionado = lista.FirstOrDefault(item => item.id == id);
            Produto.AlterarAtributos(produtoSelecionado);
        }
        public static void RetirarProduto(List<Produto> lista)
        {

            ListarProdutos(lista);
            Console.Write("Deseja retirar algum produto? (S/N): ");
            string resposta = Console.ReadLine().ToLower();
            if (resposta == "s")
            {
                Console.Write("Digite o código do produto que deseja retirar: ");
                string id = Console.ReadLine();
                Produto produtoSelecionado = lista.FirstOrDefault(item => item.id == id);
                lista.Remove(produtoSelecionado);
            }

        }
        public static void AdicionarAoCarrinho(List<Produto> lista1, List<Produto> lista2)
        {
            Console.Write("Deseja adicionar algum produto ao carrinho? (S/N): ");
            string resposta = Console.ReadLine().ToLower();
            if (resposta == "s")
            {
                Console.Write("Digite o código do produto que deseja adicionar: ");
                string id = Console.ReadLine();
                Produto produtoSelecionado = lista2.FirstOrDefault(item => item.id == id);
                lista1.Add(produtoSelecionado);
                Console.Clear();
                Program.MenuProdutos();
            }
            else
            {
                Program.MenuProdutos();
            }
        }
    }
}
