using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;

using Investimentos.DTO;

namespace Investimentos.DAL
{
    public class SwingTradeDAL
    {
        public IList<TransacoesDTO> carregaGridTransacao()
        {


            try
            {
                MySqlConnection CON = new MySqlConnection();
                CON.ConnectionString = Properties.Settings.Default.ConfigDB;
                MySqlCommand CM = new MySqlCommand();
                CM.CommandType = CommandType.Text;
                CM.CommandText = "SELECT a.codigo, t.data_compra, t.valor_compra, t.data_venda, t.valor_venda FROM acoes a JOIN transacoes t on(a.id=t.cod_acao)";
                CM.Connection = CON;

                MySqlDataReader ER;

                IList<TransacoesDTO> listTransacoesDTO = new List<TransacoesDTO>();

                CON.Open();
                ER = CM.ExecuteReader();
                if (ER.HasRows)
                {
                    while (ER.Read())
                    {
                        // Objeto estão criados no DTO

                        TransacoesDTO tra = new TransacoesDTO();
                        tra.id = Convert.ToInt32(ER["id"]);
                        tra.cod_acao = Convert.ToInt32(ER["cod_acao"]);
                        tra.cod_investidor = Convert.ToInt32(ER["cod_investidor"]);
                        tra.data_compra = Convert.ToDateTime(ER["data_compra"]);
                        tra.data_venda = Convert.ToDateTime(ER["data_venda"]);
                        tra.valor_compra = Convert.ToDouble(ER["valor_compra"]);
                        tra.valor_venda = Convert.ToDouble(ER["valor_venda"]);

                        listTransacoesDTO.Add(tra);

                    }

                }

                return listTransacoesDTO;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
