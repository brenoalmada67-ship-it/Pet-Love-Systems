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

namespace PetShop_Win
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }


        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            if (AreaCompartilhada.UsuarioLogado.Admin == false)
            {
                usuariosButton.Visible = false;
            }

            if (AreaCompartilhada.UsuarioLogado.AcessaProdutos == false)
            {
                produtosButton.Visible = false;
            }

            if (AreaCompartilhada.UsuarioLogado.AcessaClientes == false)
            {
                clientesButton.Visible = false;
            }

            if (AreaCompartilhada.UsuarioLogado.AcessaCategorias == false)
            {
                categoriasButton.Visible = false;
            }
        }


        private void AbrirTelaNoPainel(Form telaSecundaria)
        {
    
            if (this.painelConteudoPanel.Controls.Count > 0)
            {
                this.painelConteudoPanel.Controls[0].Dispose();
            }

            telaSecundaria.TopLevel = false;
            telaSecundaria.FormBorderStyle = FormBorderStyle.None;

            telaSecundaria.Dock = DockStyle.Fill;

            this.painelConteudoPanel.Controls.Add(telaSecundaria);
            this.painelConteudoPanel.Tag = telaSecundaria;

            telaSecundaria.Show();
        }



        private void categoriasButton_Click(object sender, EventArgs e)
        {
            AbrirTelaNoPainel(new CategoriasForm());
        }

        private void produtosButton_Click(object sender, EventArgs e)
        {
            AbrirTelaNoPainel(new ProdutosForm());
        }

        private void clientesButton_Click(object sender, EventArgs e)
        {
            AbrirTelaNoPainel(new ClientesForm());
        }

        private void agendamentosButton_Click(object sender, EventArgs e)
        {
            AbrirTelaNoPainel(new AgendamentosForm());
        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void painelMenuLateralPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void S_Click(object sender, EventArgs e)
        {

        }

        private void usuariosButton_Click(object sender, EventArgs e)
        {
            AbrirTelaNoPainel(new UsuariosForm());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}