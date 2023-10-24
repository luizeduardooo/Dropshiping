using Drop2._0.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Drop2._0.Model
{
    public class EstadoModel
    {
        public string connectString = "Server=localhost;Database=dropshipping;User=root;Password=root;";
        public void Criar()
        {
            EstadoEntity estado = new EstadoEntity();
            Console.Write("Digite o nome do estado: ");
            estado.NOME = Console.ReadLine();

            Console.Write("Digite a sigla do estado: ");
            estado.UF = Console.ReadLine();

            using (MySqlConnection conn = new MySqlConnection(connectString))
            {
                string sql = "INSERT INTO ESTADO VALUE (NULL, @NOME, @UF)";
                int linhas = conn.Execute(sql, estado);
                Console.WriteLine($"{linhas} linhas adicionadas");
            }
        }

        public void Ler()
        {

            using (MySqlConnection conn = new MySqlConnection(connectString))
            {
                IEnumerable<EstadoEntity> estado = conn.Query<EstadoEntity>("SELECT * FROM ESTADO");
                Console.Clear();

                foreach (EstadoEntity estados in estado)
                {
                    Console.WriteLine($"{estados.ID}, Nome do estado:{estados.NOME} , sigla do estado {estados.UF}");
                }
                Console.ReadLine();
            }
        }

        public void Atualizar()
        {
            Ler();


            Console.WriteLine("Digite o ID que desejar mudar");
            int id = Convert.ToInt32(Console.ReadLine());

            using (MySqlConnection conn = new MySqlConnection(connectString))
            {
                string sql = "SELECT ID, NOME, UF FROM ESTADO WHERE ID = @ID";
                var parameters = new { ID = id };
                EstadoEntity estado = conn.QueryFirst<EstadoEntity>(sql, parameters);
                Console.Write("Digite o nome do novo time: ");
                estado.NOME = Console.ReadLine();

                Console.Write("Digite a nova sigla do estado: ");
                estado.UF = Console.ReadLine();

                sql = "UPDATE ESTADO SET NOME, UF = @NOME, @UF WHERE ID = @ID";
                conn.Execute(sql, estado);
                Console.WriteLine("Estado alterado com sucesso!");
            }

        }
        public void Deletar()
        {
            Ler();

            Console.WriteLine("Digite o ID do estado a ser excluido");
            int id = Convert.ToInt32(Console.ReadLine());

            using (MySqlConnection conn = new MySqlConnection(connectString))
            {
                string sql = "DELETE FROM ESTADO WHERE ID = @ID";
                var parameters = new { ID = id };
                conn.Execute(sql, parameters);
                Console.WriteLine("Estado excluido com sucesso!");
            }

        }
    }
}

