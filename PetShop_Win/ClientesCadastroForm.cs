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
    public partial class ClientesCadastroForm : Form
    {
        private int idCliente;
        private ClienteDAO dao = new ClienteDAO();
        private bool _transacaoEmAndamento = false;

        public ClientesCadastroForm(int id = 0)
        {
            InitializeComponent();
            idCliente = id;

            // Trava o campo ID para edição manual
            idTextBox.ReadOnly = true;

            // Injeta as siglas dos estados na lista suspensa
            CarregarEstadosBrasileiros();

            // Se o ID for maior que 0, carrega os dados para edição
            if (idCliente > 0)
            {
                var cliente = dao.Listar().Find(c => c.ID == idCliente);
                if (cliente != null)
                {
                    idTextBox.Text = cliente.ID.ToString();
                    nomeTextBox.Text = cliente.Nome;
                    cpfTextBox.Text = cliente.CPF;
                    telefoneTextBox.Text = cliente.Telefone;
                    cidadeTextBox.Text = cliente.Cidade;

                    // Posiciona o ComboBox no estado correto
                    estadoComboBox.Text = cliente.Estado;
                }
            }
        }

        // Método que preenche a lista suspensa com todas as UFs
        private void CarregarEstadosBrasileiros()
        {
            string[] estados = { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO",
                                 "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI",
                                 "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" };

            estadoComboBox.Items.AddRange(estados);
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            // Barreira anti-clique duplo
            if (_transacaoEmAndamento) return;

            // Auditoria de campos obrigatórios
            if (string.IsNullOrWhiteSpace(nomeTextBox.Text))
            {
                MessageBox.Show("O nome do cliente é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(estadoComboBox.Text))
            {
                MessageBox.Show("Selecione a sigla do estado (UF).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _transacaoEmAndamento = true;
            salvarButton.Enabled = false;

            try
            {
                // Monta o objeto com os dados da tela
                Cliente cliente = new Cliente
                {
                    ID = idCliente,
                    Nome = nomeTextBox.Text.Trim(),
                    CPF = cpfTextBox.Text.Trim(),
                    Telefone = telefoneTextBox.Text.Trim(),
                    Cidade = cidadeTextBox.Text.Trim(),
                    Estado = estadoComboBox.Text
                };

                // Executa a inserção ou alteração no SQL Server
                if (idCliente == 0)
                {
                    dao.Inserir(cliente);
                    MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dao.Alterar(cliente);
                    MessageBox.Show("Cliente atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            finally
            {
                if (!this.IsDisposed)
                {
                    _transacaoEmAndamento = false;
                    salvarButton.Enabled = true;
                }
            }
        }

        private void ClientesCadastroForm_Load(object sender, EventArgs e)
        {

        }

        private void fecharButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void telefoneLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
