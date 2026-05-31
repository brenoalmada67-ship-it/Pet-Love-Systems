using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetShop_Negocio;
using PetShop_Negocio.DAO;

namespace PetShop_Win
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // --- EVENTOS REAIS DOS BOTÕES ---

        private void entrarButton_Click_1(object sender, EventArgs e)
        {
            // Validação visual
            if (string.IsNullOrWhiteSpace(usuarioTextBox.Text) || string.IsNullOrWhiteSpace(senhaTextBox.Text))
            {
                MessageBox.Show("Preencha o usuário e a senha.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Instancia o nosso motor de banco de dados
            UsuarioDAO dao = new UsuarioDAO();

            // Vai no SQL Server conferir se existe
            var usuarioLogado = dao.Login(usuarioTextBox.Text, senhaTextBox.Text);

            if (usuarioLogado != null)
            {
                // Verifica exclusão lógica
                if (!usuarioLogado.Ativo)
                {
                    MessageBox.Show("Usuário inativo no sistema.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Salva quem é o usuário na nossa máquina de estado (Sessão)
                AreaCompartilhada.UsuarioLogado = usuarioLogado;

                // Prepara e abre a tela principal
                PrincipalForm telaPrincipal = new PrincipalForm();
                this.Hide();
                telaPrincipal.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos.", "Erro de Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sairButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}