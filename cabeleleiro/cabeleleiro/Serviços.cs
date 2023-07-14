using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cabeleleiro
{
    public partial class Serviços : Form
    {
        Conexao con = new Conexao();
        public Serviços()
        {
            InitializeComponent();
        }

        private void Serviços_Load(object sender, EventArgs e)
        {
            con.abrirBanco();
            DataTable dataTable = con.selectValue("SELECT * FROM tb_servicos;");
            dgvServicos.DataSource = dataTable;

        }


        private void Cadastrar()
        {
            try
            {
                con.abrirBanco();
                con.insertValue("INSERT INTO tb_servicos(nm_servicos,Preco_servicos) VALUES ('" + TXTnome.Text + "', '" + TXTpreco.Text + "');");
            }
            catch
            {
                MessageBox.Show("Deu erro entre em contato com o suporte ao T.I");

            }

        }

        private bool ErrorPreco()
        {
            string[] pneu = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            int count = 0;
            for (int i = 0; i <= TXTpreco.Text.Length - 1; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    if (TXTpreco.Text.Substring(i, 1) == pneu[j])
                    {
                        count++;
                        break;
                    }
                }
            }

            if (count == TXTpreco.Text.Length)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void BTNcadastrar_Click(object sender, EventArgs e)
        {
            ErrorPreco();
            Cadastrar();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            this.Hide();
            mn.Show();
        }

        private void dgvServicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente cl = new Cliente();
            this.Hide();
            cl.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            this.Hide();
            produto.Show();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque();
            this.Hide();
            estoque.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            this.Hide();
            usuario.Show();

        }
    }
}
