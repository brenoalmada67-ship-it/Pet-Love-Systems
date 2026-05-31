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
using System.Collections.Generic;
using System.Windows.Forms;
using PetShop_Negocio.DAO;
using PetShop_Negocio.Mapeamento;

namespace PetShop_Win
{
    public partial class AgendamentosCadastroForm : Form
    {
        private int idAgendamento;
        private AgendamentoDAO agendamentoDao = new AgendamentoDAO();
        private ClienteDAO clienteDao = new ClienteDAO();
        private bool _transacaoEmAndamento = false;

        private TimeSpan? _horarioOriginalEdicao = null;
        private DateTime? _dataOriginalEdicao = null;

        public AgendamentosCadastroForm(int id = 0)
        {
            InitializeComponent();
            idAgendamento = id;
            idTextBox.ReadOnly = true;

            CarregarClientes();

            if (idAgendamento > 0)
            {
                var agendamento = agendamentoDao.Listar().Find(a => a.ID == idAgendamento);
                if (agendamento != null)
                {
                    idTextBox.Text = agendamento.ID.ToString();
                    clienteComboBox.SelectedValue = agendamento.IDCliente;
                    nomeAnimalTextBox.Text = agendamento.NomeAnimal;
                    tipoAnimalTextBox.Text = agendamento.TipoAnimal;

                    // Carrega o serviço
                    servicoTextBox.Text = agendamento.Servico;

                    valorNumericUpDown.Value = agendamento.Valor;

                    _horarioOriginalEdicao = agendamento.Horario;
                    _dataOriginalEdicao = agendamento.DataAgendamento.Date;

                    dataDateTimePicker.Value = agendamento.DataAgendamento;
                }
            }

            AtualizarHorariosDisponiveis();
        }

        private void CarregarClientes()
        {
            clienteComboBox.DataSource = clienteDao.Listar();
            clienteComboBox.DisplayMember = "Nome";
            clienteComboBox.ValueMember = "ID";
            clienteComboBox.SelectedIndex = -1;
        }

        private void AtualizarHorariosDisponiveis()
        {
            List<TimeSpan> todosHorarios = new List<TimeSpan>();
            TimeSpan horaAtual = new TimeSpan(8, 0, 0);
            TimeSpan horaFim = new TimeSpan(18, 0, 0);

            while (horaAtual <= horaFim)
            {
                todosHorarios.Add(horaAtual);
                horaAtual = horaAtual.Add(new TimeSpan(0, 30, 0));
            }

            DateTime dataSelecionada = dataDateTimePicker.Value.Date;
            List<TimeSpan> ocupados = agendamentoDao.BuscarHorariosOcupados(dataSelecionada);

            if (idAgendamento > 0 && _dataOriginalEdicao == dataSelecionada && _horarioOriginalEdicao.HasValue)
            {
                ocupados.Remove(_horarioOriginalEdicao.Value);
            }

            horarioComboBox.Items.Clear();
            foreach (var hora in todosHorarios)
            {
                if (!ocupados.Contains(hora))
                {
                    horarioComboBox.Items.Add(hora.ToString(@"hh\:mm"));
                }
            }

            if (idAgendamento > 0 && _dataOriginalEdicao == dataSelecionada && _horarioOriginalEdicao.HasValue)
            {
                horarioComboBox.Text = _horarioOriginalEdicao.Value.ToString(@"hh\:mm");
            }
            else
            {
                horarioComboBox.SelectedIndex = -1;
            }
        }

        private void dataDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            AtualizarHorariosDisponiveis();
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            if (_transacaoEmAndamento) return;

            if (clienteComboBox.SelectedValue == null)
            {
                MessageBox.Show("Selecione o tutor responsável.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(nomeAnimalTextBox.Text))
            {
                MessageBox.Show("O nome do animal é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Nova validação obrigando a informar o serviço
            if (string.IsNullOrWhiteSpace(servicoTextBox.Text))
            {
                MessageBox.Show("Informe o serviço que será realizado (ex: Banho, Tosa, Consulta).", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(horarioComboBox.Text))
            {
                MessageBox.Show("Selecione um horário disponível para este dia.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _transacaoEmAndamento = true;
            salvarButton.Enabled = false;

            try
            {
                Agendamento agendamento = new Agendamento
                {
                    ID = idAgendamento,
                    IDCliente = Convert.ToInt32(clienteComboBox.SelectedValue),
                    NomeAnimal = nomeAnimalTextBox.Text.Trim(),
                    TipoAnimal = tipoAnimalTextBox.Text.Trim(),
                    Servico = servicoTextBox.Text.Trim(), // Salva o serviço
                    DataAgendamento = dataDateTimePicker.Value.Date,
                    Horario = TimeSpan.Parse(horarioComboBox.Text),
                    Valor = valorNumericUpDown.Value
                };

                if (idAgendamento == 0)
                {
                    agendamentoDao.Inserir(agendamento);
                    MessageBox.Show("Agendamento reservado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    agendamentoDao.Alterar(agendamento);
                    MessageBox.Show("Agendamento atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha estrutural ao salvar. O horário pode ter sido reservado por outro terminal: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void fecharButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void AgendamentosCadastroForm_Load(object sender, EventArgs e)
        {

        }
    }
}