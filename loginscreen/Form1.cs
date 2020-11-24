using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace loginscreen
{

    public partial class Form1 : Form
    {
        

        
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)            
        {
            CadastroPage cadastro = new CadastroPage();
            cadastro.Show();            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Hash hash = new Hash();
            bool Verificador = false;

            string usuario = textBoxUsuario.Text.ToString();
            string senha = textBoxSenha.Text;
            
            string senhaCodificada = hash.CriptografarSenha(senha);

            if (usuario.Length > 0 && senha.Length > 0){
                Comparar comp = new Comparar();

                Verificador = comp.verificarLogin(usuario, senhaCodificada);

                if (Verificador == true)
                {
                    MessageBox.Show("Login feito com sucesso");
                    UserName.Text = $"Nome: {usuario}";
                }
                else
                {
                    MessageBox.Show("Usuario não existe ou a senha está errada");
                }
            }
            else
            {
                MessageBox.Show("Erro no login");
            }

            textBoxUsuario.Text = "";
            textBoxSenha.Text = "";
        }

        private void UserName_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
