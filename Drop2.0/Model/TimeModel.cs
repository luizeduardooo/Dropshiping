using Drop2._0.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using ZstdSharp.Unsafe;

namespace Drop2._0.Model
{
    public class TimeModel
    {
        public string connectString = "Server=localhost;Database=dropshipping;User=root;Password=root;";
        public void Criar()
        {
            TimeEntity time = new TimeEntity();
            Console.Write("Digite o nome do time: ");
            time.NOME_TIME = Console.ReadLine();

            using (MySqlConnection conn = new MySqlConnection(connectString))
            {
                string sql = "INSERT INTO TIME VALUE (NULL, @NOME_TIME)";
                int linhas = conn.Execute(sql, time);
                Console.WriteLine($"{linhas} linhas adicionadas");
            }
        }
        public void Ler()
        {
            using (MySqlConnection conn = new MySqlConnection(connectString))
            {
                
                IEnumerable<TimeEntity> times = conn.Query<TimeEntity>("SELECT * FROM TIME");
                Console.Clear();
                foreach (TimeEntity time in times)
                {
                    Console.WriteLine($"{time.ID} - {time.NOME_TIME}");
                    
                }
                Console.WriteLine("Pressione Enter para retornar ao menu");                Console.ReadLine();
                Menu menuVendedor = new Menu();
                menuVendedor.MenuVendedor();
                
            }
        }
        
    }
}
