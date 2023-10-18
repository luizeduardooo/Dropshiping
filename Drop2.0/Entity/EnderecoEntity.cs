using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drop2._0.Entity
{
    internal class EnderecoEntity
    {
        public int ID { get; set; }
        public string RUA { get; set; }
        public int NUMERO { get; set; }
        public string BAIRRO { get; set; }
        public int CIDADE_ID { get; set; }
    }
}
