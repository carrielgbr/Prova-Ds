using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cabeleleiro
{
    public partial class Produto : Form
    {
        Conexao con = new Conexao();
        public Produto()
        {
            InitializeComponent();
        }

        private void Produto_Load(object sender, EventArgs e)
        {
            preecherComboBox();
            con.abrirBanco();
            DataTable dataTable = con.selectValue("select * from view_produto;");
            dgvProduto.DataSource = dataTable;
        }

        private void preecherComboBox()
        {
            con.abrirBanco();
            try
            {
                /*
                con.selectValue("SELECT * FROM tb_tipoProduto");
                MySqlCommand cmd = new MySqlCommand();
                MySqlDataReader dados = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dados);
                cbxProduto.DisplayMember = "Produto";
                cbxProduto.ValueMember = "Id";
                cbxProduto.DataSource = dt;
                cbxProduto.Text = "Selecione o Produto";*/
                /*DataTable valor = con.selectValue("SELECT * FROM tb_tipoProduto");
                cbxProduto.DataSource = valor;
                cbxProduto.DisplayMember = "Produto";
                cbxProduto.ValueMember = "Id";
                cbxProduto.Text = "Selecione o Produto";*/
                DataTable valor = con.selectValue("SELECT * FROM tb_tipoProduto");
                cbxProduto.DataSource = valor;
                cbxProduto.DisplayMember = "nm_tipoProduto";
                cbxProduto.ValueMember = "Id_tipoProduto";
                //cbxProduto.Text = "Selecione o Produto";
            }
            catch (Exception erro)
            {
                MessageBox.Show("Error: "+ erro.Message+"Chamar equipe Ti");
            }
            finally
            {
                con.fecharConex();
            }

        }

        private void cadastrar()
        {
            con.abrirBanco();
            try
            {
                con.insertValue("INSERT INTO tb_Produto(nm_Produto,Preco_Produto,Id_tipoProduto) VALUES ('" + TXTNome.Text + "', '" + TXTpreco.Text + "', '" + cbxProduto.SelectedValue.ToString() + "' ); ");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Error: " + erro.Message + "Chamar equipe Ti");

            }
            finally { 
                con.fecharConex();
            }

        }

        private void BTNcadastrar_Click(object sender, EventArgs e)
        {
            cadastrar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            this.Hide();
            mn.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente cl = new Cliente();
            this.Hide();
            cl.Show();
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

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Serviços ser = new Serviços();
            this.Hide();
            ser.Show();
        }
    }
}
