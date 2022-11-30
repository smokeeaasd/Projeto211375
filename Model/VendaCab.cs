using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto211375.Model
{
    public class VendaCab
    {
        public int Id { get; set; }
        public int idVendaCab { get; set; }
        public int idProduto { get; set; }
        public double qtde { get; set; }
        public double valorUnitario { get; set; }
    }
}
