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
    public partial class ClientesForm : Form
    {
        private ClienteDAO dao = new ClienteDAO();

        public ClientesForm()
        {
            InitializeComponent();
        }

        // Este evento deve estar ligado ao Load da tela para carregar os dados assim que abrir
        private void ClientesForm_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        // --- MOTOR DE LISTAGEM E PESQUISA ---
        private void CarregarGrid()
        {
            // Busca a lista limpa e atualizada (agora com Cidade e Estado, sem o Ativo)
            var lista = dao.Listar();

            // Se você desenhou um TextBox para pesquisar pelo nome (opcional)
            // Descomente as linhas abaixo e substitua "filtroNomeTextBox" pelo nome correto da sua caixa de pesquisa
            /*
            string filtroNome = filtroNomeTextBox.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(filtroNome))
            {
                lista = lista.FindAll(c => c.Nome.ToLower().Contains(filtroNome));
            }
            */

            // Injeta os dados na grelha
            clientesDataGridView.DataSource = null; // Limpa o cache
            clientesDataGridView.DataSource = lista;

            // Garantia de preenchimento visual que definimos no Blueprint
            clientesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // --- EVENTOS DOS BOTÕES ---

        private void listarButton_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void inserirButton_Click(object sender, EventArgs e)
        {
            // O ID 0 avisa para a modal que é um Novo Cadastro
            ClientesCadastroForm tela = new ClientesCadastroForm(0);
            tela.ShowDialog();

            // Atualiza a grelha instantaneamente assim que a modal for fechada
            CarregarGrid();
        }

        private void alterarButton_Click(object sender, EventArgs e)
        {
            // Verifica se o usuário clicou em alguma linha azul da grelha
            if (clientesDataGridView.SelectedRows.Count > 0)
            {
                // Captura o ID escondido na linha selecionada
                int idSelecionado = Convert.ToInt32(clientesDataGridView.SelectedRows[0].Cells["ID"].Value);

                // Passa o ID selecionado para a modal carregar os dados
                ClientesCadastroForm tela = new ClientesCadastroForm(idSelecionado);
                tela.ShowDialog();

                CarregarGrid();
            }
            else
            {
                MessageBox.Show("Selecione um cliente na lista para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            if (clientesDataGridView.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente excluir este cliente do sistema?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idSelecionado = Convert.ToInt32(clientesDataGridView.SelectedRows[0].Cells["ID"].Value);
                    dao.Excluir(idSelecionado);

                    CarregarGrid();
                }
            }
            else
            {
                MessageBox.Show("Selecione um cliente na lista para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void fecharButton_Click(object sender, EventArgs e)
        {
            this.Close(); // A arquitetura SPA do PrincipalForm lida perfeitamente com isso
        }
    }
}
