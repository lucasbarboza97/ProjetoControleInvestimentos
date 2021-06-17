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


        /*********************** Carrega itens no listbox ***********************/
        private void carregaListBox()
        {
            /*********************** Variáveis ***********************/
            string id;
            string cod_acao;
            string cod_investidor;
            string data_compra;
            string valor_compra;
            string data_venda;
            string valor_venda;
            string qtd_compra;
            string qtd_venda;
            string codigo_acao;


            /*********************** Carrega as definições gerais de estilo de datagrid ***********************/
            Styles modelo = new Styles();
            dataGridView1 = modelo.styleDataGridView(dataGridView1);

            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Ação";
            dataGridView1.Columns[1].Name = "Data de compra";
            dataGridView1.Columns[2].Name = "Data de venda";


            /*********************** Conexão com BD e comando select ***********************/
            string sql = "SELECT a.codigo, t.id, t.cod_acao, t.cod_investidor, t.data_compra, t.valor_compra, t.data_venda,t.valor_venda,t.qtd_compra,t.qtd_venda FROM transacoes t JOIN acoes a ON(t.cod_acao = a.id)";
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
                        id = reader[1].ToString();
                        cod_acao = reader[2].ToString();
                        cod_investidor = reader[3].ToString();
                        data_compra = reader[4].ToString();
                        valor_compra = reader[5].ToString();
                        data_venda = reader[6].ToString();
                        valor_venda = reader[7].ToString();
                        qtd_compra = reader[8].ToString();
                        qtd_venda = reader[9].ToString();
                        dataGridView1.Rows.Add(codigo_acao,data_compra,data_venda); 
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


        /*********************** Classes padrões do form ***********************/
        private void SwingTrade_Load(object sender, EventArgs e)
        {
            carregaListBox();
        }


        /*********************** Classes ainda não utilizadas ***********************/
    }
}
