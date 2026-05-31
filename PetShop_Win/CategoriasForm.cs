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
    public partial class CategoriasForm : Form
    {
        // Instancia o motor de banco de dados para Categorias
        private CategoriaDAO dao = new CategoriaDAO();

        public CategoriasForm()
        {
            InitializeComponent();
        }

        // Evento que roda sozinho quando a tela abre
        private void CategoriasForm_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        // Função central que busca os dados e aplica os filtros
        private void CarregarGrid()
        {
            var lista = dao.Listar();
            string filtroNome = filtroNomeTextBox.Text.Trim().ToLower();

            if (!string.IsNullOrEmpty(filtroNome))
            {
                lista = lista.FindAll(c => c.Nome.ToLower().Contains(filtroNome));
            }

            categoriasDataGridView.DataSource = lista;

            // ESCONDE A COLUNA DESCRIÇÃO
            if (categoriasDataGridView.Columns["Descricao"] != null)
            {
                categoriasDataGridView.Columns["Descricao"].Visible = false;
            }
        }

        // --- EVENTOS DOS BOTÕES ---

        private void listarButton_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void inserirButton_Click(object sender, EventArgs e)
        {
            // Abre a tela pequena passando 0 (indicando que é um cadastro NOVO)
            CategoriasCadastroForm tela = new CategoriasCadastroForm(0);
            tela.ShowDialog();

            // Atualiza a grade assim que a janelinha fechar
            CarregarGrid();
        }

        private void alterarButton_Click(object sender, EventArgs e)
        {
            // Verifica se o usuário realmente selecionou uma linha na grade
            if (categoriasDataGridView.SelectedRows.Count > 0)
            {
                // Extrai o ID da linha selecionada
                int idSelecionado = Convert.ToInt32(categoriasDataGridView.SelectedRows[0].Cells["ID"].Value);

                // Abre a tela pequena passando o ID selecionado
                CategoriasCadastroForm tela = new CategoriasCadastroForm(idSelecionado);
                tela.ShowDialog();

                // Atualiza a grade assim que a janelinha fechar
                CarregarGrid();
            }
            else
            {
                MessageBox.Show("Selecione uma categoria na grade para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            if (categoriasDataGridView.SelectedRows.Count > 0)
            {
                DialogResult resposta = MessageBox.Show("Tem certeza que deseja excluir esta categoria?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    int idSelecionado = Convert.ToInt32(categoriasDataGridView.SelectedRows[0].Cells["ID"].Value);
                    dao.Excluir(idSelecionado);

                    // Atualiza a grade após excluir
                    CarregarGrid();
                }
            }
            else
            {
                MessageBox.Show("Selecione uma categoria na grade para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void fecharButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
private void filtroTodosRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
