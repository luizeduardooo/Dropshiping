using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySql.Data;

namespace Drop2._0.Entity
{ 
    public class PedidoEntity
    {
        public int ID { get; set; }
        public double VALOR { get; set; } 

        public int CLIENTE_ID { get; set;}

        public int FORMA_PAGAMENTO_ID { get; set; }

    

    }
}
