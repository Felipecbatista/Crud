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
    public partial class FrmPrincipal : Form
    {
        DataTable dt = new DataTable();
        public FrmPrincipal()
        {
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
            dt = Pessoas.GetPessoas(true);
            dgrid.DataSource = dt;
            ConfigurarGradePessoas();
        }


        //Seta o grid de exibição
        private void ConfigurarGradePessoas()
        {
            dgrid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgrid.DefaultCellStyle.Font = new Font("Arial", 9);
            dgrid.RowHeadersWidth = 25;

            dgrid.Columns["Id"].HeaderText = "ID";
            dgrid.Columns["Id"].Visible = false;

            dgrid.Columns["Nome"].HeaderText = "NOME";
            dgrid.Columns["Nome"].Width = 350;
            dgrid.Columns["Nome"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgrid.Columns["Nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgrid.Columns["Telefone"].HeaderText = "TELEFONE";
            dgrid.Columns["Telefone"].Width = 130;

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            var Id = Convert.ToInt32(dgrid.Rows[dgrid.CurrentCell.RowIndex].Cells["Id"].Value);

            using (var frm= new FrmPessoas(Id))
            {
                frm.ShowDialog();
            }
        }

        
        private void dgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            dt = Pessoas.GetPessoas(true);
            dgrid.DataSource = dt;
            ConfigurarGradePessoas();
        }



        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void bntIncluir_Click(object sender, EventArgs e)
        {
            
            using (var frm = new FrmPessoas(0))
            {
                frm.ShowDialog();
                dgrid.DataSource = Pessoas.GetPessoas(true);
            }

        }
    }
}
