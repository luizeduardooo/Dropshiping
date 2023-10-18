using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Drop2._0.Model;
using Drop2._0.Entity;

namespace Drop2._0
{
    public class Cliente
    {
        private Menu _menu = new Menu();
        public string nome { get; private set; }
        public string cpf { get; private set; }


        public Cliente()
        {
            Cadastrar();
        }

        private void Cadastrar()
        {
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite o CPF (somente números): ");
            cpf = Console.ReadLine();
        }
        public void CadastrarCliente(List<Cliente> lista)
        {
            Cliente novoCliente = new Cliente();
            lista.Add(novoCliente);
            _menu.MostrarMenu($"{novoCliente.nome} bem-vindo(a)! ");

        }
        public void ListarCliente(List<Cliente> lista)
        {
            for (int id = 0; id < lista.Count; id++)
            {
                Console.WriteLine($"{id + 1} - {lista[id].nome}, CPF {lista[id].cpf}");
            }
            Console.WriteLine("Tecle Enter para continuar");
            Console.ReadLine();
            _menu.MostrarMenu();
        }
    }
}