using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Controle_de_Investimentos
{
    public partial class SwingTrade : Form
    {
        public SwingTrade()
        {
            InitializeComponent();
        }


        /*********************** Classes reutilizáveis ***********************/        


        /*********************** Carrega itens no datagrid ***********************/
        private void carregaDataGrid()
        {
            /*********************** Variáveis ***********************/

            string data_compra;
            string data_venda;
            string codigo_acao;
            string id;


            /*********************** Carrega as definições gerais de estilo de datagrid ***********************/
            Styles modelo = new Styles();
            dataGridView1 = modelo.styleDataGridView(dataGridView1);

            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Ação";
            dataGridView1.Columns[1].Name = "Data de compra";
            dataGridView1.Columns[2].Name = "Data de venda";
            dataGridView1.Columns[3].Name = "Código da transação";

            dataGridView1.Columns[3].Visible = false;


            /*********************** Conexão com BD e comando select ***********************/
            string sql = "SELECT a.codigo, t.data_compra, t.data_venda, t.id FROM transacoes t JOIN acoes a ON(t.cod_acao = a.id)";
            MySqlConnection con = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.ConnectionString = Properties.Settings.Default.connectionString;
            cmd.CommandType = CommandType.Text;
            MySqlDataReader reader;
            con.Open();


            /*********************** Pega os dados do retornados do BD, e manda para o datagrid ***********************/
            try
            {
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        codigo_acao = reader[0].ToString();
                        data_compra = reader[1].ToString();
                        data_venda = reader[2].ToString();
                        id = reader[3].ToString();

                        dataGridView1.Rows.Add(codigo_acao,data_compra,data_venda,id); 
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }


        /*********************** Seleciona item no datagrid e exibe ao lado ***********************/
        public void selecionaAtivo ()
        {
            string idSelecionado = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            
            /*********************** Conexão com BD e comando select ***********************/
            string sql = "SELECT a.codigo, t.data_compra, t.qtd_compra, t.valor_compra, t.valor_total_compra, t.data_venda, t.qtd_venda, t.valor_venda, t.valor_total_venda, t.taxa_corretagem, t.valor_darf, t.lucro_menos_impostos, t.lucro_sem_impostos FROM transacoes t JOIN acoes a ON(t.cod_acao = a.id) WHERE t.id =" + idSelecionado;
            MySqlConnection con = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.ConnectionString = Properties.Settings.Default.connectionString;
            cmd.CommandType = CommandType.Text;
            MySqlDataReader reader;
            con.Open();
            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtCodigoAcao.Enabled = false;
                    mskDataCompra.Enabled = false;
                    txtQtdCompra.Enabled = false;
                    txtValorUnitarioCompra.Enabled = false;
                    txtValorTotalCompra.Enabled = false;
                    mskDataVenda.Enabled = false;
                    txtQtdVenda.Enabled = false;
                    txtValorUnitarioVenda.Enabled = false;
                    txtValorTotalVenda.Enabled = false;
                    txtTaxaCorretagem.Enabled = false;
                    txtDarf.Enabled = false;
                    txtLucro.Enabled = false;
                    txtCodigoAcao.Text = reader[0].ToString();
                    mskDataCompra.Text = reader[1].ToString();
                    txtQtdCompra.Text = reader[2].ToString();
                    txtValorUnitarioCompra.Text = reader[3].ToString();
                    txtValorTotalCompra.Text = reader[4].ToString();
                    mskDataVenda.Text = reader[5].ToString();
                    txtQtdVenda.Text = reader[6].ToString();
                    txtValorUnitarioVenda.Text = reader[7].ToString();
                    txtValorTotalVenda.Text = reader[8].ToString();
                    txtTaxaCorretagem.Text = reader[9].ToString();
                    txtDarf.Text = reader[10].ToString();
                    txtLucro.Text = reader[11].ToString();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }



        /*********************** Classes padrões do form ***********************/
        private void SwingTrade_Load(object sender, EventArgs e)
        {
            carregaDataGrid();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            selecionaAtivo();
        }


        /*********************** Classes ainda não utilizadas ***********************/
    }
}
