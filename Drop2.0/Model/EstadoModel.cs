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
                string sql = "INSERT INTO TIME VALUE (NULL, @NOME_TIME)";
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

            }



        }






    }
}

