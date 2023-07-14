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
    public partial class Cliente : Form
    {

        Conexao conex = new Conexao();

        public Cliente()
        {
            InitializeComponent();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            this.Hide();
            produto.Show();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            conex.abrirBanco();
            DataTable dataTable = conex.selectValue("SELECT * FROM tb_cliente;");
            dgvCliente.DataSource = dataTable;
        }

        private void Cadastro()
        {
            try
            {
                conex.abrirBanco();
                conex.insertValue("INSERT INTO tb_cliente (nm_cliente,cpf_cliente,telefone_cliente,endereço_cliente) VALUES ('" + TXTNome.Text + "', '" + TXTCPF.Text + "', '" + TXTTelefone.Text + "', '" + TXTEndereco.Text + "');");
            }
            catch
            {
                MessageBox.Show("os dados nao foram inseridos.");
            }
        }

        private bool ErrorCPF()
        {
            string[] pneu = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            int count = 0;
            for (int i = 0; i <= TXTCPF.Text.Length - 1; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    if (TXTCPF.Text.Substring(i, 1) == pneu[j])
                    {
                        count++;
                        break;
                    }
                }
            }

            if (count == TXTCPF.Text.Length)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ErrorTelefone()
        {
            string[] pneu = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            int count = 0;
            for (int i = 0; i <= TXTTelefone.Text.Length - 1; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    if (TXTTelefone.Text.Substring(i, 1) == pneu[j])
                    {
                        count++;
                        break;
                    }
                }
            }

            if (count == TXTTelefone.Text.Length)
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
            if (TXTCPF.Text == "")
            {
                MessageBox.Show("preencha todos os campos");
                return;
            }
            if (TXTEndereco.Text == "")
            {
                MessageBox.Show("preencha todos os campos");
                return;
            }
            if (TXTNome.Text == "")
            {
                MessageBox.Show("preencha todos os campos");
                return;
            }
            if (TXTTelefone.Text == "")
            {
                MessageBox.Show("preencha todos os campos");
                return;
            }

            if (ErrorCPF() || ErrorTelefone())
            {
                MessageBox.Show("coloca numeros nos campos de CPF e TELEFONE");
                TXTCPF.Text = "";
                TXTTelefone.Text = "";
                TXTCPF.Focus();
                TXTTelefone.Focus();
                return;

            }


            Cadastro();
            MessageBox.Show("OS dados foram cadastrados");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            conex.abrirBanco();
            DataTable dataTable = conex.selectValue("SELECT * FROM tb_cliente;");
            dgvCliente.DataSource = dataTable;
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            this.Hide();
            mn.Show();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estoque es = new Estoque();
            this.Hide();
            es.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            this.Hide();
            usuario.Show();
        }

        private void serviçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Serviços ser = new Serviços();
            this.Hide();
            ser.Show();
        }
    }
}
