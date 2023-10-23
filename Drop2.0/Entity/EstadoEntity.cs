using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySql.Data;

namespace Drop2._0.Entity
{
    public class EstadoEntity
    {
        public int ID { get; set; } 
        public string NOME { get; set; }
        public string UF { get; set; }

    }
}
