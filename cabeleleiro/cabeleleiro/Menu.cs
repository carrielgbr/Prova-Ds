using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cabeleleiro
{
    public partial class Menu : Form
    {

        Conexao conex  = new Conexao();


        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente cl = new Cliente();
            this.Hide();
            cl.Show();
        }

        private void servilçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Serviços ser = new Serviços();
            this.Hide();
            ser.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario User = new Usuario();
            this.Hide();
            User.Show();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estoque stock = new Estoque();
            this.Hide();
            stock.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produto pd = new Produto();
            this.Hide();
            pd.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            select();
            conex.abrirBanco();
            DataTable dataTable = conex.selectValue("select * from view_cliente_servicos;");
            dgvMenu.DataSource = dataTable;
            secondselect();
        }

        private void Cadastrar()
        {
            conex.abrirBanco();
            try
                {
                    conex.insertValue("INSERT INTO tb_servicoscliente (Id_servicos, Id_cliente) VALUES ('" + cbxCliente.SelectedValue.ToString() + "','" + cbxServicos.SelectedValue.ToString() + "'); ");
                }
            catch (Exception error)
                {
                    MessageBox.Show("Error : " + error.Message + " chamar equipe de ti");
                }
            finally
                {
                    conex.fecharConex();
                }

        }


        private void select()
        {
            conex.abrirBanco();
                try
                    {
                DataTable valor = conex.selectValue("SELECT * FROM tb_cliente ;") ;
                        cbxCliente.DataSource = valor;
                        cbxCliente.DisplayMember = "nm_cliente";
                        cbxCliente.ValueMember = "Id_cliente";
                    }
                catch(Exception error)
                    {
                        MessageBox.Show("Error : " + error.Message + "chamr equipe T.I");
                    }
                finally
                    {
                        conex.fecharConex();
                    }
        }



        private void secondselect()
        {
            conex.abrirBanco();
                try
                    {
                        DataTable valor = conex.selectValue("SELECT * FROM tb_servicos");
                        cbxServicos.DataSource = valor;
                        cbxServicos.DisplayMember = "nm_servicos";
                        cbxServicos.ValueMember = "Id_servicos";
                    }
                catch(Exception error)
                    {
                        MessageBox.Show("Error : " + error.Message + "chamr equipe T.I");
                    }
                finally
                    {
                        conex.fecharConex() ;
                    }


        }




        private void BTNCadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar();
        }

        private void cbxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
