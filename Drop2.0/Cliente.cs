using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Drop2._0
{
    internal class Cliente
    {
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
            Console.Write("Digite o CPF(somente números): ");
            cpf = Console.ReadLine();
        }
    }
}