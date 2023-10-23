using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Drop2._0.Model;
using MySql.Data;

namespace Drop2._0.Entity
{
    public class ProdutoEntity
    {
        public int ID { get; set; }
        public string NOME { get; set; }
        public string DESCRICAO { get; set; }
        public string TAMANHO { get; set; }
        public double VALOR { get; set; }
        public int TIME_ID { get; set; }

        public ProdutoModel ProdutoModel { get; set; }
    }
}
