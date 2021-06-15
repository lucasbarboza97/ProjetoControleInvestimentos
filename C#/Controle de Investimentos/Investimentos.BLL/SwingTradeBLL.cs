using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Investimentos.DTO;
using Investimentos.DAL;

namespace Investimentos.BLL
{
    public class SwingTradeBLL
    {
        public IList<TransacoesDTO> carregaGridTransacao()
        {
            try
            {
                return new SwingTradeDAL().carregaGridTransacao();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
