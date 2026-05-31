using PetShop_Negocio.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop_Win
{
    public partial class ProdutosForm : Form
    {
        private ProdutoDAO dao = new ProdutoDAO();

        public ProdutosForm()
        {
            InitializeComponent();
        }

        private void ProdutosForm_Load(object sender, EventArgs e)
        {
            filtroAtivoRadioButton.Checked = true;
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            var lista = dao.Listar();
            string filtroNome = filtroNomeTextBox.Text.Trim().ToLower();

            if (!string.IsNullOrEmpty(filtroNome))
            {
                lista = lista.FindAll(p => p.Nome.ToLower().Contains(filtroNome));
            }

            if (filtroAtivoRadioButton.Checked)
            {
                lista = lista.FindAll(p => p.Ativo == true);
            }
            else if (filtroInativoRadioButton.Checked)
            {
                lista = lista.FindAll(p => p.Ativo == false);
            }

            categoriasDataGridView.DataSource = lista;

            if (categoriasDataGridView.Columns["CategoriaID"] != null)
            {
                categoriasDataGridView.Columns["CategoriaID"].Visible = false;
            }
        }

        private void listarButton_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void inserirButton_Click(object sender, EventArgs e)
        {
            // O construtor vazio agora é suportado pelo parâmetro opcional (int id = 0).
            var cadastroForm = new ProdutosCadastroForm();

            // Arquiteto Sênior: Acionamento da recarga condicional do Grid
            if (cadastroForm.ShowDialog() == DialogResult.OK)
            {
                CarregarGrid();
            }
        }

        private void alterarButton_Click(object sender, EventArgs e)
        {
            if (categoriasDataGridView.SelectedRows.Count > 0)
            {
                int idSelecionado = Convert.ToInt32(categoriasDataGridView.SelectedRows[0].Cells["ID"].Value);

                ProdutosCadastroForm tela = new ProdutosCadastroForm(idSelecionado);

                // Arquiteto Sênior: Atualiza apenas se o usuário realmente salvou as alterações
                if (tela.ShowDialog() == DialogResult.OK)
                {
                    CarregarGrid();
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto na lista para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            if (categoriasDataGridView.SelectedRows.Count > 0)
            {
                DialogResult resposta = MessageBox.Show("Tem certeza que deseja excluir este produto do sistema?", "Auditoria de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    int idSelecionado = Convert.ToInt32(categoriasDataGridView.SelectedRows[0].Cells["ID"].Value);
                    dao.Excluir(idSelecionado);
                    CarregarGrid();
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto na lista para executar a exclusão.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void fecharButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}