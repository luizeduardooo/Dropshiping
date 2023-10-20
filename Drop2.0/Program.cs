using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using Drop2._0.Model;
using Drop2._0.Entity;
using Drop2._0;

namespace Drop2._0
{
    class Program
    {
        static string caminho = "C:/Users/eduardo.rauber/Drop/ListaProdutos.txt";
        static void Main(string[] args)
        {

            if (File.Exists(caminho))
            {      
                StreamReader streamReader = new StreamReader(caminho);
                string json = streamReader.ReadToEnd();
                Menu.produtos = JsonSerializer.Deserialize<List<Produto>>(json);
                streamReader.Close();
            }
            Menu menu = new Menu();
            Console.Title = "Dropshipping dos Guris";     
            menu.MostrarMenu();
        }
    }
}