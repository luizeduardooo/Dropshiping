using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drop2._0
{
    public class Produto
    {
        public string id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public string tamanho { get; set; }
        public double valor { get; set; }
        public string time { get; set; }


        public void Popular()
        {
            Console.Write("Digite o código do produto: ");
            id = Console.ReadLine();
            Console.Write("Digite o nome do produto: ");
            nome = Console.ReadLine();
            Console.Write("Digite uma descrição do produto: ");
            descricao = Console.ReadLine();
            Console.Write("Digite o tamanho do produto: ");
            tamanho = Console.ReadLine();
            Console.Write("Digite o valor do produto: ");
            valor = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o nome do Time: ");
            time = Console.ReadLine().ToLower();
        }
        public static void CriarProduto(List<Produto> lista)
        {
            Produto novoProduto = new Produto();
            novoProduto.Popular();
            lista.Add(novoProduto);
            Program.MenuVendedor();
        }
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
        public static void AlterarProduto(List<Produto> lista, string mensagem = "")
        {
            Produto.ListarProdutos(lista);
            Console.Write("Digite o código do produto que deseja alterar: ");
            string id = Console.ReadLine();
            Produto produtoSelecionado = lista.FirstOrDefault(item => item.id == id);
            lista.Remove(produtoSelecionado);
            CriarProduto(lista);
            Console.WriteLine(mensagem);
        }
        public static void RetirarProduto(List<Produto> lista, string mensagem = "")
        {
            
            Produto.ListarProdutos(lista);
            Console.Write("Deseja retirar algum produto? (S/N): ");
            string resposta = Console.ReadLine();
            if (resposta == "s" || resposta == "S")
            {
                Console.Write("Digite o código do produto que deseja retirar: ");
                string id = Console.ReadLine();
                Produto produtoSelecionado = lista.FirstOrDefault(item => item.id == id);
                lista.Remove(produtoSelecionado);
                Program.MenuVendedor();
                Console.WriteLine(mensagem);
            }
            else
            {
                Program.MenuVendedor();
            }
        }
        public static void AdicionarAoCarrinho(List<Produto> lista1, List<Produto> lista2)
        {
            Console.Write("Deseja adicionar algum produto ao carrinho? (S/N): ");
            string resposta = Console.ReadLine();
            if (resposta == "s" || resposta == "S")
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
