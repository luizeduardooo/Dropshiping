using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Drop2._0
{
    public class Credito : Forma_de_pagamento
    {
        private string NumeroCartao;
        private string Senha;
        private string Validacao;
        public int Parcelas { get; set; }


        public string numeroCartao
        {
            get { return numeroCartao; }

            set
            {
               
                if (value.Length == 16)
                    numeroCartao = value;
                else
                    throw new ArgumentException("O número do cartão deve ter 16 dígitos.");
            }


        }

        public string senha
        {
            get { return senha; }

            set
            {
              
                if (value.Length == 4)
                    senha = value;
                else
                    throw new ArgumentException("O número da senha deve conter 4 dígitos.");
            }


        }

        public string validacao
        {
            get { return validacao; }

            set
            {

                if (value.Length == 3)
                    validacao = value;
                else
                    throw new ArgumentException("O número da validação deve conter 3 dígitos.");
            }


        }
    }
}

