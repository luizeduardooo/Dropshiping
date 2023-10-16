using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySql.Data;

namespace Drop2._0
{
    public class Forma_de_pagamento
    {
        protected static double ValorTotal;

        public static double CalcularValor(List<Produto> lista)
        {
            for (int i = 0; i < lista.Count(); i++)
            {
                ValorTotal += lista[i].valor;
            }
                return ValorTotal;
        }
    }
}
