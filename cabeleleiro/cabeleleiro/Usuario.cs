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
    public partial class Usuario : Form
    {
        Conexao conex = new Conexao();
        public Usuario()
        {
            InitializeComponent();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            this.Hide();
            mn.Show();
        }

        private void Cadastrar()
        {
            try
            {
                conex.abrirBanco();
                conex.insertValue("INSERT INTO tb_Usuario(nm_Usuario,Login_Usuario,Senha_Usuario) VALUES ('"+ TXTNOME.Text +"', '"+ TXTusuario.Text +"', '"+ TXTSenha.Text +"'); ");    
            }
            catch
            {
                MessageBox.Show("entre em contato com o nosso suporte T.I");
            }
            conex.fecharConex();
                
        }

        private void BTNCadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar();
            MessageBox.Show("Usuario Cadastrado Com Sucesso !");
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            this.Hide();
            cliente.Show();
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

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Serviços ser = new Serviços();
            this.Hide();
            ser.Show();
        }
    }
}
