using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Windows.Forms;
using PetShop_Negocio.DAO;
using PetShop_Negocio.Mapeamento;

namespace PetShop_Win
{
    public partial class UsuariosCadastroForm : Form
    {
        private int idUsuario;
        private UsuarioDAO dao = new UsuarioDAO();

        public UsuariosCadastroForm(int id = 0)
        {
            InitializeComponent();
            idUsuario = id;
            idTextBox.ReadOnly = true;

            if (idUsuario > 0)
            {
                // Modo Edição: Carrega os dados do banco para a tela
                var usuario = dao.Listar().Find(u => u.ID == idUsuario);
                if (usuario != null)
                {
                    idTextBox.Text = usuario.ID.ToString();
                    nomeTextBox.Text = usuario.Nome;
                    cargoTextBox.Text = usuario.Cargo;
                    loginTextBox.Text = usuario.Login;
                    senhaTextBox.Text = usuario.Senha;

                    produtosCheckBox.Checked = usuario.AcessaProdutos;
                    clientesCheckBox.Checked = usuario.AcessaClientes;
                    categoriasCheckBox.Checked = usuario.AcessaCategorias;
                    adminCheckBox.Checked = usuario.Admin;
                }
            }
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            // Validações básicas
            if (string.IsNullOrWhiteSpace(nomeTextBox.Text) || string.IsNullOrWhiteSpace(loginTextBox.Text) || string.IsNullOrWhiteSpace(senhaTextBox.Text))
            {
                MessageBox.Show("Nome, Login e Senha são obrigatórios.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Usuario usuario = new Usuario
                {
                    ID = idUsuario,
                    Nome = nomeTextBox.Text.Trim(),
                    Cargo = cargoTextBox.Text.Trim(),
                    Login = loginTextBox.Text.Trim(),
                    Senha = senhaTextBox.Text.Trim(),
                    AcessaProdutos = produtosCheckBox.Checked,
                    AcessaClientes = clientesCheckBox.Checked,
                    AcessaCidades = false,

                    AcessaCategorias = categoriasCheckBox.Checked,
                    Admin = adminCheckBox.Checked
                };

                if (idUsuario == 0)
                {
                    dao.Inserir(usuario);
                    MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dao.Alterar(usuario);
                    MessageBox.Show("Usuário atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar usuário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fecharButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    
private void produtosCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void clientesCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void categoriasCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void adminCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
