using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Investimentos.DTO;
using Investimentos.BLL;

namespace Investimentos.UI
{
    public partial class SwingTrade : Form
    {
        public SwingTrade()
        {
            InitializeComponent();
        }

        private void SwingTrade_Load(object sender, EventArgs e)
        {
            carregaGridTransacoes();
        }
        private void carregaGridTransacoes()
        {

            try
            {
                IList<TransacoesDTO> listUsuario_DTO = new List<TransacoesDTO>();
                listUsuario_DTO = new SwingTradeBLL().carregaGridTransacao();

                //Preencher dados no DataGridView

                dataGridView1.DataSource = listUsuario_DTO;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }
    }
}
