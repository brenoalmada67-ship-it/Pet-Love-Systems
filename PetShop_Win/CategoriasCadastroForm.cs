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
using PetShop_Negocio.Mapeamento;

namespace PetShop_Win
{
    public partial class CategoriasCadastroForm : Form
    {
        private int idCategoria;
        private CategoriaDAO dao = new CategoriaDAO();

        // O construtor recebe o ID (0 para novo, ou o ID existente para editar)
        public CategoriasCadastroForm(int id)
        {
            InitializeComponent();
            idCategoria = id;

            // Bloqueia a caixa de texto do ID para o utilizador não digitar nela (o SQL Server trata disso)
            idTextBox.ReadOnly = true;

            // Se o ID for maior que 0, é uma Alteração. Vamos procurar no banco e preencher a tela.
            if (idCategoria > 0)
            {
                var categoria = dao.Listar().Find(c => c.ID == idCategoria);
                if (categoria != null)
                {
                    idTextBox.Text = categoria.ID.ToString();
                    nomeTextBox.Text = categoria.Nome;

                    // ATENÇÃO: Se a tua classe Categoria tiver a propriedade "Ativo", remove as barras (//) abaixo:
                    // ativoCheckBox.Checked = categoria.Ativo;
                }
            }
        }

        // --- EVENTOS DOS BOTÕES ---

        private void salvarButton_Click(object sender, EventArgs e)
        {
            // Validação visual de campos obrigatórios
            if (string.IsNullOrWhiteSpace(nomeTextBox.Text))
            {
                MessageBox.Show("O Nome da categoria é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Interrompe a execução aqui
            }

            // Monta o objeto Categoria com os dados digitados na tela
            Categoria categoria = new Categoria
            {
                ID = idCategoria,
                Nome = nomeTextBox.Text.Trim()

                // Nota: Omiti o campo Descricao porque o retiraste da tela. 
                // Se adicionaste a coluna Ativo no banco de dados, remove as barras (//) abaixo:
                // , Ativo = ativoCheckBox.Checked
            };

            // Se o ID for 0, é um Inserir. Se for maior que 0, é um Alterar.
            if (idCategoria == 0)
            {
                dao.Inserir(categoria);
                MessageBox.Show("Categoria cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dao.Alterar(categoria);
                MessageBox.Show("Categoria atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Fecha a janelinha pequena automaticamente após guardar
            this.Close();
        }

        private void fecharButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}