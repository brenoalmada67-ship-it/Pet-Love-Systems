namespace PetShop_Win
{
    partial class ProdutosCadastroForm
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
            this.salvarButton = new System.Windows.Forms.Button();
            this.fecharButton = new System.Windows.Forms.Button();
            this.ativoCheckBox = new System.Windows.Forms.CheckBox();
            this.valorTotalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.valorUnitarioNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.quantidadeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.valorTotalLabel = new System.Windows.Forms.Label();
            this.valorUnitarioLabel = new System.Windows.Forms.Label();
            this.quantidadeLabel = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.categoriaLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.tituloLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.valorTotalNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorUnitarioNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantidadeNumericUpDown)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // salvarButton
            // 
            this.salvarButton.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvarButton.Location = new System.Drawing.Point(213, 246);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(75, 23);
            this.salvarButton.TabIndex = 20;
            this.salvarButton.Text = "Salvar";
            this.salvarButton.UseVisualStyleBackColor = true;
            this.salvarButton.Click += new System.EventHandler(this.salvarButton_Click);
            // 
            // fecharButton
            // 
            this.fecharButton.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecharButton.Location = new System.Drawing.Point(294, 246);
            this.fecharButton.Name = "fecharButton";
            this.fecharButton.Size = new System.Drawing.Size(75, 23);
            this.fecharButton.TabIndex = 22;
            this.fecharButton.Text = "Fechar";
            this.fecharButton.UseVisualStyleBackColor = true;
            this.fecharButton.Click += new System.EventHandler(this.fecharButton_Click);
            // 
            // ativoCheckBox
            // 
            this.ativoCheckBox.AutoSize = true;
            this.ativoCheckBox.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ativoCheckBox.Location = new System.Drawing.Point(19, 246);
            this.ativoCheckBox.Name = "ativoCheckBox";
            this.ativoCheckBox.Size = new System.Drawing.Size(57, 18);
            this.ativoCheckBox.TabIndex = 18;
            this.ativoCheckBox.Text = "Ativo";
            this.ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // valorTotalNumericUpDown
            // 
            this.valorTotalNumericUpDown.DecimalPlaces = 2;
            this.valorTotalNumericUpDown.Location = new System.Drawing.Point(247, 194);
            this.valorTotalNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.valorTotalNumericUpDown.Name = "valorTotalNumericUpDown";
            this.valorTotalNumericUpDown.ReadOnly = true;
            this.valorTotalNumericUpDown.Size = new System.Drawing.Size(115, 20);
            this.valorTotalNumericUpDown.TabIndex = 17;
            this.valorTotalNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // valorUnitarioNumericUpDown
            // 
            this.valorUnitarioNumericUpDown.DecimalPlaces = 2;
            this.valorUnitarioNumericUpDown.Location = new System.Drawing.Point(145, 194);
            this.valorUnitarioNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.valorUnitarioNumericUpDown.Name = "valorUnitarioNumericUpDown";
            this.valorUnitarioNumericUpDown.Size = new System.Drawing.Size(96, 20);
            this.valorUnitarioNumericUpDown.TabIndex = 15;
            this.valorUnitarioNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.valorUnitarioNumericUpDown.ValueChanged += new System.EventHandler(this.valorUnitarioNumericUpDown_ValueChanged);
            // 
            // quantidadeNumericUpDown
            // 
            this.quantidadeNumericUpDown.Location = new System.Drawing.Point(12, 194);
            this.quantidadeNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.quantidadeNumericUpDown.Name = "quantidadeNumericUpDown";
            this.quantidadeNumericUpDown.Size = new System.Drawing.Size(130, 20);
            this.quantidadeNumericUpDown.TabIndex = 14;
            this.quantidadeNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.quantidadeNumericUpDown.ValueChanged += new System.EventHandler(this.quantidadeNumericUpDown_ValueChanged);
            // 
            // valorTotalLabel
            // 
            this.valorTotalLabel.AutoSize = true;
            this.valorTotalLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorTotalLabel.Location = new System.Drawing.Point(292, 178);
            this.valorTotalLabel.Name = "valorTotalLabel";
            this.valorTotalLabel.Size = new System.Drawing.Size(69, 14);
            this.valorTotalLabel.TabIndex = 23;
            this.valorTotalLabel.Text = "Valor Total";
            // 
            // valorUnitarioLabel
            // 
            this.valorUnitarioLabel.AutoSize = true;
            this.valorUnitarioLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorUnitarioLabel.Location = new System.Drawing.Point(142, 178);
            this.valorUnitarioLabel.Name = "valorUnitarioLabel";
            this.valorUnitarioLabel.Size = new System.Drawing.Size(85, 14);
            this.valorUnitarioLabel.TabIndex = 21;
            this.valorUnitarioLabel.Text = "Valor Unitário";
            // 
            // quantidadeLabel
            // 
            this.quantidadeLabel.AutoSize = true;
            this.quantidadeLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantidadeLabel.Location = new System.Drawing.Point(13, 178);
            this.quantidadeLabel.Name = "quantidadeLabel";
            this.quantidadeLabel.Size = new System.Drawing.Size(70, 14);
            this.quantidadeLabel.TabIndex = 19;
            this.quantidadeLabel.Text = "Quantidade";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeTextBox.Location = new System.Drawing.Point(12, 138);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(353, 20);
            this.nomeTextBox.TabIndex = 12;
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeLabel.Location = new System.Drawing.Point(12, 121);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(39, 14);
            this.nomeLabel.TabIndex = 16;
            this.nomeLabel.Text = "Nome";
            // 
            // categoriaComboBox
            // 
            this.categoriaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoriaComboBox.FormattingEnabled = true;
            this.categoriaComboBox.Location = new System.Drawing.Point(152, 80);
            this.categoriaComboBox.Name = "categoriaComboBox";
            this.categoriaComboBox.Size = new System.Drawing.Size(217, 21);
            this.categoriaComboBox.TabIndex = 11;
            // 
            // categoriaLabel
            // 
            this.categoriaLabel.AutoSize = true;
            this.categoriaLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaLabel.Location = new System.Drawing.Point(149, 65);
            this.categoriaLabel.Name = "categoriaLabel";
            this.categoriaLabel.Size = new System.Drawing.Size(60, 14);
            this.categoriaLabel.TabIndex = 13;
            this.categoriaLabel.Text = "Categoria";
            // 
            // idTextBox
            // 
            this.idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTextBox.Location = new System.Drawing.Point(12, 81);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(130, 20);
            this.idTextBox.TabIndex = 9;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(12, 64);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(20, 14);
            this.idLabel.TabIndex = 10;
            this.idLabel.Text = "ID";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(320, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(60, 62);
            this.panel2.TabIndex = 20;
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
            this.topPanel.Size = new System.Drawing.Size(380, 62);
            this.topPanel.TabIndex = 24;
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tituloLabel.Location = new System.Drawing.Point(12, 9);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(264, 30);
            this.tituloLabel.TabIndex = 8;
            this.tituloLabel.Text = "Cadastro de Produtos";
            // 
            // ProdutosCadastroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(380, 281);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.salvarButton);
            this.Controls.Add(this.fecharButton);
            this.Controls.Add(this.ativoCheckBox);
            this.Controls.Add(this.valorTotalNumericUpDown);
            this.Controls.Add(this.valorUnitarioNumericUpDown);
            this.Controls.Add(this.quantidadeNumericUpDown);
            this.Controls.Add(this.valorTotalLabel);
            this.Controls.Add(this.valorUnitarioLabel);
            this.Controls.Add(this.quantidadeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.categoriaComboBox);
            this.Controls.Add(this.categoriaLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ProdutosCadastroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastre ou Edite seu Produto";
            this.Load += new System.EventHandler(this.ProdutosCadastroForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.valorTotalNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorUnitarioNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantidadeNumericUpDown)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salvarButton;
        private System.Windows.Forms.Button fecharButton;
        private System.Windows.Forms.CheckBox ativoCheckBox;
        private System.Windows.Forms.NumericUpDown valorTotalNumericUpDown;
        private System.Windows.Forms.NumericUpDown valorUnitarioNumericUpDown;
        private System.Windows.Forms.NumericUpDown quantidadeNumericUpDown;
        private System.Windows.Forms.Label valorTotalLabel;
        private System.Windows.Forms.Label valorUnitarioLabel;
        private System.Windows.Forms.Label quantidadeLabel;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.ComboBox categoriaComboBox;
        private System.Windows.Forms.Label categoriaLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label tituloLabel;
    }
}