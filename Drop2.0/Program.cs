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
        private static Menu _menu = new Menu();
        static void Main(string[] args)
        {
            Console.Title = "Dropshipping dos Guris";     
            _menu.MostrarMenu();
        }
    }
}