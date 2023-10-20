using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Drop2._0.Entity;
using Drop2._0.Model;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Drop2._0.Model
{
    public class ProdutoModel
    {
        public string connectString = "Server=localhost;Database=Dropshipping;User=root;Password=root;";
        public void ListarProdutos(List<Produto> lista, string time = "")
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
        public void AlterarProduto(List<Produto> lista)
        {
            Produto _produto = new Produto();
            ListarProdutos(lista);
            Console.Write("Digite o código do produto que deseja alterar: ");
            string id = Console.ReadLine();
            Produto produtoSelecionado = lista.FirstOrDefault(item => item.id == id);
            _produto.AlterarAtributos(produtoSelecionado);
        }
        public void RetirarProduto(List<Produto> lista)
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
        public void AdicionarAoCarrinho(List<Produto> lista1, List<Produto> lista2)
        {
            Menu _menu = new Menu();
            Console.Write("Deseja adicionar algum produto ao carrinho? (S/N): ");
            string resposta = Console.ReadLine().ToLower();
            if (resposta == "s")
            {
                Console.Write("Digite o código do produto que deseja adicionar: ");
                string id = Console.ReadLine();
                Produto produtoSelecionado = lista2.FirstOrDefault(item => item.id == id);
                lista1.Add(produtoSelecionado);
                Console.Clear();
                _menu.MenuProdutos();
            }
            else
            {
                _menu.MenuProdutos();
            }
        }
        public void Read()
        {
            using (MySqlConnection connect = new MySqlConnection(connectString))
            {
                string sql = "SELECT * FROM PRODUTO";
                IEnumerable<ProdutoEntity> produtos = connect.Query<ProdutoEntity>(sql);
                int linhas = connect.Execute(sql, produtos);

                foreach (ProdutoEntity produto in produtos)
                {
                    Console.WriteLine($"Cód {produto.ID} - {produto.NOME} - {produto.DESCRICAO} - Tamanho: {produto.TAMANHO} - R$ {produto.VALOR}");
                    Console.ReadLine();
                    Console.WriteLine($"{linhas} executadas");
                }
            }
        }
        public void Create()
        {
            using (MySqlConnection connect = new MySqlConnection(connectString))
            {
                string sql = "INSERT INTO PRODUTO VALUE (NULL, @NOME, @DESCRICAO, @TAMANHO, @VALOR, @TIME_ID)";
                IEnumerable<ProdutoEntity> produtos = connect.Query<ProdutoEntity>(sql);
                int linhas = connect.Execute(sql, produtos);

            }
        }
    }
}
