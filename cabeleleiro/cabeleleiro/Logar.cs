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
    public partial class Logar : Form
    {
        Conexao conexao = new Conexao();
        public Logar()
        {
            InitializeComponent();
        }

        private void BTNvoltar_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();
        }

        private void BTNentrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login();
        }

        private void Login()
        {
            conexao.abrirBanco();
            DataTable dt = conexao.selectValue("SELECT * FROM tb_Usuario where Login_Usuario='" + TXTUsuario.Text + "'AND Senha_Usuario='" + TXTsenha.Text + "';");
            if (dt.Rows.Count > 0)
            {
                Menu mn = new Menu();
                mn.Show();
            }
            else
            {
                MessageBox.Show("Login ou Senha errados tente novamente.");
            }

            conexao.fecharConex();

            }

        private void Logar_Load(object sender, EventArgs e)
        {

        }
    }
    }
