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
    public partial class Estoque : Form
    {
        Conexao conex = new Conexao();

        public Estoque()
        {
            InitializeComponent();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Estoque_Load(object sender, EventArgs e)
        {
            conex.abrirBanco();
            DataTable dataTable = conex.selectValue("SELECT * FROM tb_estoque;");
            dgvEstoque.DataSource = dataTable;
            selectcbx();
          
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            this.Hide();
            mn.Show();
        }


        private void selectcbx()
        {
            conex.abrirBanco();
            try
            {
                DataTable valor = conex.selectValue("SELECT * FROM tb_produto ;");
                cbxEstoque.DataSource = valor;
                cbxEstoque.DisplayMember = "nm_produto";
                cbxEstoque.ValueMember = "Id_produto";
            }
            catch (Exception error)
            {
                MessageBox.Show("Error : " + error.Message + "chamr equipe T.I");
            }
            finally
            {
                conex.fecharConex();
            }

        }



        private void insert()
        {
            conex.abrirBanco();
            try{
                conex.insertValue("INSERT INTO tb_estoque(quantiadade_estoque,Id_produto) VALUES ( '" + txtQTDE.Text+"',   );");
            }
            catch(Exception error)
            {
                MessageBox.Show("Error : " + error.Message + "chame a equipe T.I");
            }
            finally
            {
                conex.fecharConex() ;
            }
        }

        private bool ErrorQtde()
        {
            string[] pneu = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            int count = 0;
            for (int i = 0; i <= txtQTDE.Text.Length - 1; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    if (txtQTDE.Text.Substring(i, 1) == pneu[j])
                    {
                        count++;
                        break;
                    }
                }
            }

            if (count == txtQTDE.Text.Length)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void BTNCAdastrar_Click(object sender, EventArgs e)
        {
            insert();
            ErrorQtde();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            this.Hide();
            produto.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            this.Hide();
            user.Show();
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Serviços ser = new Serviços();
            this.Hide();
            ser.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente cl = new Cliente();
            this.Hide();
            cl.Show();
        }

        private void txtQTDE_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
