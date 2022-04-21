using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Crud
{
    public partial class FrmPessoas : Form
    {
        int Id;
        Pessoas pessoas = new Pessoas();

       

        public FrmPessoas(int Id)
        {
            InitializeComponent();
            this.Id = Id;

            if(this.Id >0)
            {
                pessoas.GetPessoa(this.Id);

                lblId.Text = pessoas.Id.ToString();
                txtNome.Text = pessoas.Nome;
                txtTelefone.Text = pessoas.Telefone;
            }
        }

       

        //Botao Salvar vai fazer o update no cadastro
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaPessoa())
            {
                pessoas.Nome = txtNome.Text;
                pessoas.Telefone = txtTelefone.Text;

                pessoas.AlteraPessoa();
            }
        }



        private void FrmPessoas_Load(object sender, EventArgs e)
        {

        }

        //Botão Fehcar janela
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExluir_Click(object sender, EventArgs e)
        {
            pessoas.Nome = txtNome.Text;

            pessoas.ExcluiPessoa();
            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            
        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private bool ValidaPessoa()
        {
            if (txtNome.Text == "")
            {                
                MessageBox.Show("Informe o nome: ", Program.sistema);
                txtNome.Focus();
                return false;
            }
            else if (txtTelefone.Text == "")
            {
                MessageBox.Show("Informe o telefone: ", Program.sistema);
                txtTelefone.Focus();
                return false;
            } else
                return true;
        }
    }
}
