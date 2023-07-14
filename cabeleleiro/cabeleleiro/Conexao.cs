using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace cabeleleiro
{
    internal class Conexao
    {
        private string conexao = "server=localhost;uid=root;database=banco_trabalho_ds";
        public MySqlConnection conne = null;

        public void abrirBanco()
        {
            try
            {
                MySqlConnection sqlc = new MySqlConnection(conexao);
                sqlc.ConnectionString = this.conexao;
                sqlc.Open();
                this.conne = sqlc;
            }
            catch(Exception error)
            {
                MessageBox.Show("Error : "+ error.Message +"Chamar equipe T.I" );
            }
        }

        public void fecharConex()
        {
            this.conne.Close();
        }


        public void insertValue(string text)
        {
            MySqlCommand command = new MySqlCommand(text, this.conne);
            command.ExecuteNonQuery();
        }

        public DataTable selectValue(string text)
        {
            MySqlDataAdapter command = new MySqlDataAdapter(text, this.conne);
            DataTable dt = new DataTable();
            command.Fill(dt);
            return dt;
        }


    }
}
