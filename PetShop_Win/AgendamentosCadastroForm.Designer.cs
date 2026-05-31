namespace PetShop_Win
{
    partial class AgendamentosCadastroForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.clienteLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.salvarButton = new System.Windows.Forms.Button();
            this.fecharButton = new System.Windows.Forms.Button();
            this.nomeAnimalTextBox = new System.Windows.Forms.TextBox();
            this.nomeAnimalLabel = new System.Windows.Forms.Label();
            this.tipoAnimalTextBox = new System.Windows.Forms.TextBox();
            this.tipoAnimalLabel = new System.Windows.Forms.Label();
            this.clienteComboBox = new System.Windows.Forms.ComboBox();
            this.horarioComboBox = new System.Windows.Forms.ComboBox();
            this.horarioLabel = new System.Windows.Forms.Label();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataLabel = new System.Windows.Forms.Label();
            this.servicoTextBox = new System.Windows.Forms.TextBox();
            this.servicoLabel = new System.Windows.Forms.Label();
            this.valorNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.valorLabel = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tituloLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.valorNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.topPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // clienteLabel
            // 
            this.clienteLabel.AutoSize = true;
            this.clienteLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteLabel.Location = new System.Drawing.Point(12, 104);
            this.clienteLabel.Name = "clienteLabel";
            this.clienteLabel.Size = new System.Drawing.Size(47, 14);
            this.clienteLabel.TabIndex = 57;
            this.clienteLabel.Text = "Cliente";
            // 
            // idTextBox
            // 
            this.idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTextBox.Location = new System.Drawing.Point(15, 81);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(130, 20);
            this.idTextBox.TabIndex = 55;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(12, 65);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(20, 14);
            this.idLabel.TabIndex = 56;
            this.idLabel.Text = "ID";
            // 
            // salvarButton
            // 
            this.salvarButton.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvarButton.Location = new System.Drawing.Point(373, 201);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(75, 23);
            this.salvarButton.TabIndex = 52;
            this.salvarButton.Text = "Salvar";
            this.salvarButton.UseVisualStyleBackColor = true;
            this.salvarButton.Click += new System.EventHandler(this.salvarButton_Click);
            // 
            // fecharButton
            // 
            this.fecharButton.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecharButton.Location = new System.Drawing.Point(454, 201);
            this.fecharButton.Name = "fecharButton";
            this.fecharButton.Size = new System.Drawing.Size(75, 23);
            this.fecharButton.TabIndex = 54;
            this.fecharButton.Text = "Fechar";
            this.fecharButton.UseVisualStyleBackColor = true;
            this.fecharButton.Click += new System.EventHandler(this.fecharButton_Click);
            // 
            // nomeAnimalTextBox
            // 
            this.nomeAnimalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeAnimalTextBox.Location = new System.Drawing.Point(149, 81);
            this.nomeAnimalTextBox.Name = "nomeAnimalTextBox";
            this.nomeAnimalTextBox.Size = new System.Drawing.Size(179, 20);
            this.nomeAnimalTextBox.TabIndex = 49;
            // 
            // nomeAnimalLabel
            // 
            this.nomeAnimalLabel.AutoSize = true;
            this.nomeAnimalLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeAnimalLabel.Location = new System.Drawing.Point(149, 65);
            this.nomeAnimalLabel.Name = "nomeAnimalLabel";
            this.nomeAnimalLabel.Size = new System.Drawing.Size(99, 14);
            this.nomeAnimalLabel.TabIndex = 50;
            this.nomeAnimalLabel.Text = "Nome do Animal";
            // 
            // tipoAnimalTextBox
            // 
            this.tipoAnimalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tipoAnimalTextBox.Location = new System.Drawing.Point(336, 81);
            this.tipoAnimalTextBox.Name = "tipoAnimalTextBox";
            this.tipoAnimalTextBox.Size = new System.Drawing.Size(196, 20);
            this.tipoAnimalTextBox.TabIndex = 63;
            // 
            // tipoAnimalLabel
            // 
            this.tipoAnimalLabel.AutoSize = true;
            this.tipoAnimalLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoAnimalLabel.Location = new System.Drawing.Point(333, 65);
            this.tipoAnimalLabel.Name = "tipoAnimalLabel";
            this.tipoAnimalLabel.Size = new System.Drawing.Size(92, 14);
            this.tipoAnimalLabel.TabIndex = 64;
            this.tipoAnimalLabel.Text = "Tipo de Animal";
            // 
            // clienteComboBox
            // 
            this.clienteComboBox.FormattingEnabled = true;
            this.clienteComboBox.Location = new System.Drawing.Point(15, 120);
            this.clienteComboBox.Name = "clienteComboBox";
            this.clienteComboBox.Size = new System.Drawing.Size(233, 21);
            this.clienteComboBox.TabIndex = 65;
            // 
            // horarioComboBox
            // 
            this.horarioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.horarioComboBox.FormattingEnabled = true;
            this.horarioComboBox.Location = new System.Drawing.Point(254, 161);
            this.horarioComboBox.Name = "horarioComboBox";
            this.horarioComboBox.Size = new System.Drawing.Size(275, 21);
            this.horarioComboBox.TabIndex = 66;
            // 
            // horarioLabel
            // 
            this.horarioLabel.AutoSize = true;
            this.horarioLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horarioLabel.Location = new System.Drawing.Point(251, 144);
            this.horarioLabel.Name = "horarioLabel";
            this.horarioLabel.Size = new System.Drawing.Size(48, 14);
            this.horarioLabel.TabIndex = 67;
            this.horarioLabel.Text = "Horário";
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.Location = new System.Drawing.Point(15, 161);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(233, 20);
            this.dataDateTimePicker.TabIndex = 68;
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLabel.Location = new System.Drawing.Point(12, 144);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(32, 14);
            this.dataLabel.TabIndex = 69;
            this.dataLabel.Text = "Data";
            // 
            // servicoTextBox
            // 
            this.servicoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.servicoTextBox.Location = new System.Drawing.Point(254, 120);
            this.servicoTextBox.Name = "servicoTextBox";
            this.servicoTextBox.Size = new System.Drawing.Size(275, 20);
            this.servicoTextBox.TabIndex = 70;
            // 
            // servicoLabel
            // 
            this.servicoLabel.AutoSize = true;
            this.servicoLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicoLabel.Location = new System.Drawing.Point(251, 104);
            this.servicoLabel.Name = "servicoLabel";
            this.servicoLabel.Size = new System.Drawing.Size(48, 14);
            this.servicoLabel.TabIndex = 71;
            this.servicoLabel.Text = "Serviço";
            // 
            // valorNumericUpDown
            // 
            this.valorNumericUpDown.DecimalPlaces = 2;
            this.valorNumericUpDown.Location = new System.Drawing.Point(15, 204);
            this.valorNumericUpDown.Name = "valorNumericUpDown";
            this.valorNumericUpDown.Size = new System.Drawing.Size(139, 20);
            this.valorNumericUpDown.TabIndex = 72;
            this.valorNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // valorLabel
            // 
            this.valorLabel.AutoSize = true;
            this.valorLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorLabel.Location = new System.Drawing.Point(12, 187);
            this.valorLabel.Name = "valorLabel";
            this.valorLabel.Size = new System.Drawing.Size(98, 14);
            this.valorLabel.TabIndex = 73;
            this.valorLabel.Text = "Valor do Serviço";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Teal;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.OldRepublic;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 60;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(60, 60);
            this.iconPictureBox1.TabIndex = 7;
            this.iconPictureBox1.TabStop = false;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Teal;
            this.topPanel.Controls.Add(this.panel2);
            this.topPanel.Controls.Add(this.tituloLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(545, 62);
            this.topPanel.TabIndex = 74;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(485, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(60, 62);
            this.panel2.TabIndex = 20;
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tituloLabel.Location = new System.Drawing.Point(12, 9);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(311, 30);
            this.tituloLabel.TabIndex = 8;
            this.tituloLabel.Text = "Agendamento de Serviço";
            // 
            // AgendamentosCadastroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(545, 241);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.valorLabel);
            this.Controls.Add(this.valorNumericUpDown);
            this.Controls.Add(this.servicoTextBox);
            this.Controls.Add(this.servicoLabel);
            this.Controls.Add(this.dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(this.horarioLabel);
            this.Controls.Add(this.horarioComboBox);
            this.Controls.Add(this.clienteComboBox);
            this.Controls.Add(this.tipoAnimalTextBox);
            this.Controls.Add(this.tipoAnimalLabel);
            this.Controls.Add(this.clienteLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.salvarButton);
            this.Controls.Add(this.fecharButton);
            this.Controls.Add(this.nomeAnimalTextBox);
            this.Controls.Add(this.nomeAnimalLabel);
            this.Name = "AgendamentosCadastroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agende um Serviço";
            this.Load += new System.EventHandler(this.AgendamentosCadastroForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.valorNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label clienteLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button salvarButton;
        private System.Windows.Forms.Button fecharButton;
        private System.Windows.Forms.TextBox nomeAnimalTextBox;
        private System.Windows.Forms.Label nomeAnimalLabel;
        private System.Windows.Forms.TextBox tipoAnimalTextBox;
        private System.Windows.Forms.Label tipoAnimalLabel;
        private System.Windows.Forms.ComboBox clienteComboBox;
        private System.Windows.Forms.ComboBox horarioComboBox;
        private System.Windows.Forms.Label horarioLabel;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.TextBox servicoTextBox;
        private System.Windows.Forms.Label servicoLabel;
        private System.Windows.Forms.NumericUpDown valorNumericUpDown;
        private System.Windows.Forms.Label valorLabel;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label tituloLabel;
    }
}