using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstoqueLogin
{
    public class Pedido
    {
        public int NumeroPedido { get; set; }
        public string NomeCliente { get; set; }
        public string EmailCliente { get; set; }
        public string Telefone { get; set; }
        public object IdCliente { get; internal set; }
        public IEnumerable<object> Produtos { get; internal set; }
    }
}
