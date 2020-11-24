using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginscreen
{
    public partial class CadastroPage : Form
    {
        public CadastroPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadSalvar_Click(object sender, EventArgs e)
        {
            Hash hash = new Hash();
            string senhaCodificada = hash.CriptografarSenha(txtCadSenha.Text);


            Cadastrar cad = new Cadastrar(txtCadNome.Text, senhaCodificada, txtCadEmail.Text);
            MessageBox.Show(cad.mensagem);

            txtCadNome.Text = "";
            txtCadSenha.Text = "";
            txtCadEmail.Text = "";
        }

        private void btnCadSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
