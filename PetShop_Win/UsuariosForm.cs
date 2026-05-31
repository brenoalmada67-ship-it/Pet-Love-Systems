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
    public partial class UsuariosForm : Form
    {
        private UsuarioDAO dao = new UsuarioDAO();

        public UsuariosForm()
        {
            InitializeComponent();
        }

        private void UsuariosForm_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            usuariosDataGridView.DataSource = null;
            usuariosDataGridView.DataSource = dao.Listar();
            usuariosDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (usuariosDataGridView.Columns["Senha"] != null)
                usuariosDataGridView.Columns["Senha"].Visible = false;

            if (usuariosDataGridView.Columns["Ativo"] != null)
                usuariosDataGridView.Columns["Ativo"].Visible = false;
            if (usuariosDataGridView.Columns["AcessaCidades"] != null)
                usuariosDataGridView.Columns["AcessaCidades"].Visible = false;
        }

        private void listarButton_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void inserirButton_Click(object sender, EventArgs e)
        {
            UsuariosCadastroForm tela = new UsuariosCadastroForm(0);
            tela.ShowDialog();
            CarregarGrid();
        }

        private void alterarButton_Click(object sender, EventArgs e)
        {
            if (usuariosDataGridView.SelectedRows.Count > 0)
            {
                int idSelecionado = Convert.ToInt32(usuariosDataGridView.SelectedRows[0].Cells["ID"].Value);
                UsuariosCadastroForm tela = new UsuariosCadastroForm(idSelecionado);
                tela.ShowDialog();
                CarregarGrid();
            }
            else
            {
                MessageBox.Show("Selecione um usuário para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            if (usuariosDataGridView.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente desativar este usuário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idSelecionado = Convert.ToInt32(usuariosDataGridView.SelectedRows[0].Cells["ID"].Value);
                    dao.Excluir(idSelecionado);
                    CarregarGrid();
                }
            }
            else
            {
                MessageBox.Show("Selecione um usuário para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void fecharButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
