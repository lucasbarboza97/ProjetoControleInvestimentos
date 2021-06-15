using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investimentos.DTO
{
    public class TransacoesDTO
    {
        public int id { get; set; }
        public int cod_acao { get; set; }
        public int cod_investidor { get; set; }
        public DateTime data_compra { get; set; }
        public double valor_compra { get; set; }
        public DateTime data_venda { get; set; }
        public double valor_venda { get; set; }
    }
}
