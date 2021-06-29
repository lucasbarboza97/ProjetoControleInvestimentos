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
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;


namespace Controle_de_Investimentos
{
    public partial class SwingTrade : Form
    {
        string carregaGridMySql = "SELECT a.codigo, t.data_compra, t.data_venda, t.id FROM transacoes t JOIN acoes a ON(t.cod_acao = a.id)";
        
        bool novo;

        public SwingTrade()
        {
            InitializeComponent();
        }


        /*********************** Classes reutilizáveis ***********************/        
        /*********************** Carrega itens no datagrid ***********************/
        private void carregaDataGrid(String sql)
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
            
            tsbSalvar.Enabled = false;
            btnCancelar.Visible = false;
            btnSalvar.Visible = false;


            /*********************** Conexão com BD e comando select ***********************/
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

        /*********************** Função para pesquisar açoes pelo código ***********************/
        public void pesquisar()
        {
            string buscaPorCodigoAcaoMysql = "SELECT a.codigo, t.data_compra, t.data_venda, t.id FROM acoes a JOIN transacoes t ON(t.cod_acao = a.id) WHERE a.codigo LIKE '%" + tstBuscar.Text + "%';";
            dataGridView1.Rows.Clear();
            carregaDataGrid(buscaPorCodigoAcaoMysql);
            tstBuscar.Text = "";
            dataGridView1.Focus();
        }

        /*********************** Função para cancelar - Recarrega o load ***********************/
        public void cancelar()
        {
            tsbPesquisar.Enabled = true;
            tstBuscar.Enabled = true;
            tsbEditar.Enabled = true;
            tsbCadastrar.Enabled = true;
            tsbPesquisar.Enabled = true;
            dataGridView1.Rows.Clear();
            carregaDataGrid(carregaGridMySql);

        }

        /*********************** Função para habilitar os campos e limpá-los para cadastrar uma nova transação ***********************/
        public void cadastrar()
        {
            dataGridView1.Rows.Clear();

            txtCodigoAcao.Text = "";
            txtDarf.Text = "";
            txtQtdCompra.Text = "";
            txtQtdVenda.Text = "";
            txtTaxaCorretagem.Text = "";
            txtValorUnitarioCompra.Text = "";
            txtValorUnitarioVenda.Text = "";
            mskDataCompra.Text = "";
            mskDataVenda.Text = "";
            txtLucro.Text = "";
            txtValorTotalCompra.Text = "";
            txtValorTotalVenda.Text = "";

            txtCodigoAcao.Enabled = true;
            txtDarf.Enabled = true;
            txtQtdCompra.Enabled = true;
            txtQtdVenda.Enabled = true;
            txtTaxaCorretagem.Enabled = true;
            txtValorUnitarioCompra.Enabled = true;
            txtValorUnitarioVenda.Enabled = true;
            mskDataCompra.Enabled = true;
            mskDataVenda.Enabled = true;
            tsbPesquisar.Enabled = false;
            tstBuscar.Enabled = false;
            tsbEditar.Enabled = false;
            tsbCadastrar.Enabled = false;
            tsbSalvar.Enabled = true;
            btnSalvar.Visible = true;
            btnCancelar.Visible = true;
            novo = true;
        }

        /*********************** Função para salvar os campos e enviar insert para o BD ***********************/
        public void salvar()
        {
            if (novo)
            {
                string mySql = "INSERT INTO transacoes (cod_acao, cod_investidor, data_compra, qtd_compra, valor_compra, data_venda, qtd_venda, valor_venda)" 
                                + "VALUES ((SELECT a.id FROM transacoes t JOIN acoes a ON(a.id=t.cod_acao) WHERE a.codigo LIKE'" 
                                + txtCodigoAcao + "' GROUP BY a.id), '1', '" + mskDataCompra.Text + "', '"
                                + txtQtdCompra.Text + "', '" + txtValorUnitarioCompra.Text
                                + "', '" + mskDataVenda.Text + "', '" + txtQtdVenda.Text + "', '"
                                + txtValorUnitarioVenda.Text + "')";

                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = Properties.Settings.Default.connectionString;
                MySqlCommand cmd = new MySqlCommand(mySql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Cadastro realizado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                string mySql = "UPDATE CLIENTE SET nome='" + txtNome.Text + "',endereco = '" + txtEndereco.Text + "', " + "cep='" + mskCEP.Text + "', BAIRRO='" + txtBairro.Text + "',cidade = '" + txtCidade.Text + "', " + "uf='" + txtUF.Text + "', telefone='" + mskTelefone.Text + "' WHERE id=" + txtId.Text;

                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = Properties.Settings.Default.connectionString;
                MySqlCommand cmd = new MySqlCommand(mySql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Cadastro atualizado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
        }

        /*********************** Classes padrões do form ***********************/
        private void SwingTrade_Load(object sender, EventArgs e)
        {
            carregaDataGrid(carregaGridMySql);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            selecionaAtivo();
        }

        private void tsbPesquisar_Click(object sender, EventArgs e)
        {
            pesquisar();
        }

        private void tsbCadastrar_Click(object sender, EventArgs e)
        {
            cadastrar();
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            cancelar();
        }

        private void tstBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pesquisar();  
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelar();
        }

        private void tsbRecarregar_Click(object sender, EventArgs e)
        {
            carregaDataGrid(carregaGridMySql);
        }

        private void tsbSalvar_Click(object sender, EventArgs e)
        {

        }


        /*********************** Classes ainda não utilizadas ***********************/
    }
}
