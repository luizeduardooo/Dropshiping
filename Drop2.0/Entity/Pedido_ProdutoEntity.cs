using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySql.Data;

namespace Drop2._0.Entity
{
    public class Pedido_ProdutoEntity
    {
        public int PEDIDO_ID { get; set; }
        public int PRODUTO_ID { get; set; }
        public double VALOR { get; set; }
        public int QUANTIDADE { get; set; }

    }
}
