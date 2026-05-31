using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetShop_Negocio.DAO;

namespace PetShop_Win
{
    public partial class AgendamentosForm : Form
    {
        private AgendamentoDAO dao = new AgendamentoDAO();

        public AgendamentosForm()
        {
            InitializeComponent();
        }

        private void AgendamentosForm_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            agendamentosDataGridView.DataSource = null;
            agendamentosDataGridView.DataSource = dao.Listar();
            agendamentosDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void listarButton_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void inserirButton_Click(object sender, EventArgs e)
        {
            AgendamentosCadastroForm tela = new AgendamentosCadastroForm(0);
            tela.ShowDialog();
            CarregarGrid();
        }

        private void alterarButton_Click(object sender, EventArgs e)
        {
            if (agendamentosDataGridView.SelectedRows.Count > 0)
            {
                int idSelecionado = Convert.ToInt32(agendamentosDataGridView.SelectedRows[0].Cells["ID"].Value);
                AgendamentosCadastroForm tela = new AgendamentosCadastroForm(idSelecionado);
                tela.ShowDialog();
                CarregarGrid();
            }
            else
            {
                MessageBox.Show("Selecione um agendamento para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            if (agendamentosDataGridView.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja cancelar este agendamento?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idSelecionado = Convert.ToInt32(agendamentosDataGridView.SelectedRows[0].Cells["ID"].Value);
                    dao.Excluir(idSelecionado);
                    CarregarGrid();
                }
            }
            else
            {
                MessageBox.Show("Selecione um agendamento para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void fecharButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
