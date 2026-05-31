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
using PetShop_Negocio.Mapeamento;

namespace PetShop_Win
{
    public partial class ProdutosCadastroForm : Form
    {
        private int idProduto;
        private ProdutoDAO produtoDao = new ProdutoDAO();
        private CategoriaDAO categoriaDao = new CategoriaDAO();

        // Arquiteto Sênior: Semáforo de controle de concorrência local.
        private bool _transacaoEmAndamento = false;

        // Arquiteto Sênior: Construtor unificado com parâmetro opcional (id = 0 para Inserção).
        // Resolve a falha de compilação por incompatibilidade de assinatura.
        public ProdutosCadastroForm(int id = 0)
        {
            InitializeComponent();
            idProduto = id;

            idTextBox.ReadOnly = true;
            valorTotalNumericUpDown.Enabled = false;

            CarregarCategorias();

            if (idProduto > 0)
            {
                // Dívida Técnica Ciente: Substituir futuramente por produtoDao.BuscarPorId(idProduto)
                var produto = produtoDao.Listar().Find(p => p.ID == idProduto);
                if (produto != null)
                {
                    idTextBox.Text = produto.ID.ToString();
                    nomeTextBox.Text = produto.Nome;
                    quantidadeNumericUpDown.Value = produto.Quantidade;
                    valorUnitarioNumericUpDown.Value = produto.ValorUnitario;

                    // O cálculo abaixo já ocorrerá naturalmente pelos disparadores dos NumericUpDowns,
                    // mas mantemos o set explícito por segurança tática.
                    valorTotalNumericUpDown.Value = produto.ValorTotal;

                    ativoCheckBox.Checked = produto.Ativo;
                    categoriaComboBox.SelectedValue = produto.CategoriaID;
                }
            }
            else
            {
                ativoCheckBox.Checked = true;
            }
        }

        private void CarregarCategorias()
        {
            var categorias = categoriaDao.Listar();
            categoriaComboBox.DataSource = categorias;
            categoriaComboBox.DisplayMember = "Nome";
            categoriaComboBox.ValueMember = "ID";
            categoriaComboBox.SelectedIndex = -1;
        }

        // Arquiteto Sênior: Blindagem Matemática Inserida.
        private void CalcularTotal()
        {
            decimal quantidade = quantidadeNumericUpDown.Value;
            decimal valorUnitario = valorUnitarioNumericUpDown.Value;
            decimal totalCalculado = quantidade * valorUnitario;

            const decimal limiteMaximoInterface = 100000.00m;

            if (totalCalculado > limiteMaximoInterface)
            {
                valorTotalNumericUpDown.Value = limiteMaximoInterface;
                MessageBox.Show($"O cálculo excedeu o limite máximo do campo ({limiteMaximoInterface:C}). O valor foi contido por segurança.", "Salvaguarda Estrutural", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                valorTotalNumericUpDown.Value = totalCalculado;
            }
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            // 1. Barreira Anti-Concorrência: Rejeita cliques duplos instantaneamente.
            if (_transacaoEmAndamento) return;

            // Arquiteto Sênior: Eliminação do Silenciamento de Validação
            if (string.IsNullOrWhiteSpace(nomeTextBox.Text))
            {
                MessageBox.Show("O nome do produto é um atributo estrutural obrigatório. Preencha-o.", "Auditoria de Domínio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (categoriaComboBox.SelectedValue == null)
            {
                MessageBox.Show("Selecione uma categoria válida para o produto.", "Auditoria de Domínio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Acionamento da Trava de Estado
            _transacaoEmAndamento = true;
            salvarButton.Enabled = false;
            this.Cursor = Cursors.WaitCursor;

            try
            {
                Produto produto = new Produto
                {
                    ID = idProduto,
                    Nome = nomeTextBox.Text.Trim(),
                    CategoriaID = Convert.ToInt32(categoriaComboBox.SelectedValue),
                    Quantidade = Convert.ToInt32(quantidadeNumericUpDown.Value),
                    ValorUnitario = valorUnitarioNumericUpDown.Value,
                    ValorTotal = valorTotalNumericUpDown.Value,
                    Ativo = ativoCheckBox.Checked
                };

                if (idProduto == 0)
                {
                    produtoDao.Inserir(produto);
                    MessageBox.Show("Produto cadastrado com sucesso no motor de dados!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    produtoDao.Alterar(produto);
                    MessageBox.Show("Produto atualizado com sucesso no motor de dados!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Arquiteto Sênior: Estabelecimento do Contrato de Roteamento UI
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            finally
            {
                // 3. Liberação Incondicional do Semáforo (Garante a resiliência da UI)
                if (!this.IsDisposed)
                {
                    _transacaoEmAndamento = false;
                    salvarButton.Enabled = true;
                    this.Cursor = Cursors.Default;
                }
            }
        }

        private void fecharButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void quantidadeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void valorUnitarioNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void ProdutosCadastroForm_Load(object sender, EventArgs e)
        {

        }
    }
}