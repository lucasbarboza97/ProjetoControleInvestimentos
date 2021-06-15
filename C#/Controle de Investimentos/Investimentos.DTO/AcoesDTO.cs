using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investimentos.DTO
{
    public class AcoesDTO
    {
        public int id { get; set; }
        public string codigo { get; set; }
        public string nome_empresa { get; set; }
        public string setor { get; set; }
    }
}
