using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySql.Data;

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
        public static void AlterarAtributos(Produto produto)
        {
            if (produto == null)
            {
                Console.WriteLine("Código inválido! Pressione Enter para retornar ao Menu!");
                Console.ReadLine();
                Program.MenuVendedor();
            }
            else
            {
                Console.Write("Digite o nome do produto: ");
                produto.nome = Console.ReadLine();
                Console.Write("Digite uma descrição do produto: ");
                produto.descricao = Console.ReadLine();
                Console.Write("Digite o tamanho do produto: ");
                produto.tamanho = Console.ReadLine();
                Console.Write("Digite o valor do produto: ");
                produto.valor = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o nome do Time: ");
                produto.time = Console.ReadLine().ToLower();
                Program.MenuVendedor("Produto Alterado com Sucesso!");
            }
        }
        
    }

}
