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
        /******************************************* Carrega itens no listbox *******************************************/
        private void carregaListBox()
        {
            string sql = "SELECT * FROM transacoes";

            MySqlConnection con = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.ConnectionString = Properties.Settings.Default.connectionString;
            cmd.CommandType = CommandType.Text;
            MySqlDataReader reader;
            con.Open();
            try
            {
                reader = cmd.ExecuteReader();

            }
        }

        private void SwingTrade_Load(object sender, EventArgs e)
        {

        }
    }
}
