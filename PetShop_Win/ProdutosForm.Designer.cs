namespace PetShop_Win
{
    partial class ProdutosForm
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.filtroInativoRadioButton = new System.Windows.Forms.RadioButton();
            this.filtroAtivoRadioButton = new System.Windows.Forms.RadioButton();
            this.filtroTodosRadioButton = new System.Windows.Forms.RadioButton();
            this.filtroStatusLabel = new System.Windows.Forms.Label();
            this.listarButton = new System.Windows.Forms.Button();
            this.filtroNomeTextBox = new System.Windows.Forms.TextBox();
            this.filtroNomeLabel = new System.Windows.Forms.Label();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.excluirButton = new System.Windows.Forms.Button();
            this.inserirButton = new System.Windows.Forms.Button();
            this.alterarButton = new System.Windows.Forms.Button();
            this.fecharButton = new System.Windows.Forms.Button();
            this.botoesPanel = new System.Windows.Forms.Panel();
            this.categoriasDataGridView = new System.Windows.Forms.DataGridView();
            this.topPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.botoesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Teal;
            this.topPanel.Controls.Add(this.panel2);
            this.topPanel.Controls.Add(this.filtroInativoRadioButton);
            this.topPanel.Controls.Add(this.filtroAtivoRadioButton);
            this.topPanel.Controls.Add(this.filtroTodosRadioButton);
            this.topPanel.Controls.Add(this.filtroStatusLabel);
            this.topPanel.Controls.Add(this.listarButton);
            this.topPanel.Controls.Add(this.filtroNomeTextBox);
            this.topPanel.Controls.Add(this.filtroNomeLabel);
            this.topPanel.Controls.Add(this.tituloLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(800, 94);
            this.topPanel.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(700, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 94);
            this.panel2.TabIndex = 20;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Teal;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.OldRepublic;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 94;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(100, 94);
            this.iconPictureBox1.TabIndex = 7;
            this.iconPictureBox1.TabStop = false;
            // 
            // filtroInativoRadioButton
            // 
            this.filtroInativoRadioButton.AutoSize = true;
            this.filtroInativoRadioButton.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroInativoRadioButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.filtroInativoRadioButton.Location = new System.Drawing.Point(422, 68);
            this.filtroInativoRadioButton.Name = "filtroInativoRadioButton";
            this.filtroInativoRadioButton.Size = new System.Drawing.Size(64, 18);
            this.filtroInativoRadioButton.TabIndex = 19;
            this.filtroInativoRadioButton.Text = "Inativo";
            this.filtroInativoRadioButton.UseVisualStyleBackColor = true;
            // 
            // filtroAtivoRadioButton
            // 
            this.filtroAtivoRadioButton.AutoSize = true;
            this.filtroAtivoRadioButton.Checked = true;
            this.filtroAtivoRadioButton.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroAtivoRadioButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.filtroAtivoRadioButton.Location = new System.Drawing.Point(367, 68);
            this.filtroAtivoRadioButton.Name = "filtroAtivoRadioButton";
            this.filtroAtivoRadioButton.Size = new System.Drawing.Size(56, 18);
            this.filtroAtivoRadioButton.TabIndex = 18;
            this.filtroAtivoRadioButton.TabStop = true;
            this.filtroAtivoRadioButton.Text = "Ativo";
            this.filtroAtivoRadioButton.UseVisualStyleBackColor = true;
            // 
            // filtroTodosRadioButton
            // 
            this.filtroTodosRadioButton.AutoSize = true;
            this.filtroTodosRadioButton.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroTodosRadioButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.filtroTodosRadioButton.Location = new System.Drawing.Point(306, 68);
            this.filtroTodosRadioButton.Name = "filtroTodosRadioButton";
            this.filtroTodosRadioButton.Size = new System.Drawing.Size(59, 18);
            this.filtroTodosRadioButton.TabIndex = 17;
            this.filtroTodosRadioButton.Text = "Todos";
            this.filtroTodosRadioButton.UseVisualStyleBackColor = true;
            // 
            // filtroStatusLabel
            // 
            this.filtroStatusLabel.AutoSize = true;
            this.filtroStatusLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroStatusLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.filtroStatusLabel.Location = new System.Drawing.Point(303, 52);
            this.filtroStatusLabel.Name = "filtroStatusLabel";
            this.filtroStatusLabel.Size = new System.Drawing.Size(40, 14);
            this.filtroStatusLabel.TabIndex = 16;
            this.filtroStatusLabel.Text = "Status";
            // 
            // listarButton
            // 
            this.listarButton.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listarButton.Location = new System.Drawing.Point(492, 67);
            this.listarButton.Name = "listarButton";
            this.listarButton.Size = new System.Drawing.Size(75, 20);
            this.listarButton.TabIndex = 15;
            this.listarButton.Text = "Listar";
            this.listarButton.UseVisualStyleBackColor = true;
            this.listarButton.Click += new System.EventHandler(this.listarButton_Click);
            // 
            // filtroNomeTextBox
            // 
            this.filtroNomeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filtroNomeTextBox.Location = new System.Drawing.Point(19, 67);
            this.filtroNomeTextBox.Name = "filtroNomeTextBox";
            this.filtroNomeTextBox.Size = new System.Drawing.Size(283, 20);
            this.filtroNomeTextBox.TabIndex = 10;
            // 
            // filtroNomeLabel
            // 
            this.filtroNomeLabel.AutoSize = true;
            this.filtroNomeLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroNomeLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.filtroNomeLabel.Location = new System.Drawing.Point(16, 51);
            this.filtroNomeLabel.Name = "filtroNomeLabel";
            this.filtroNomeLabel.Size = new System.Drawing.Size(147, 14);
            this.filtroNomeLabel.TabIndex = 9;
            this.filtroNomeLabel.Text = "Digite o nome do Produto";
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tituloLabel.Location = new System.Drawing.Point(12, 9);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(150, 40);
            this.tituloLabel.TabIndex = 8;
            this.tituloLabel.Text = "Produtos";
            // 
            // excluirButton
            // 
            this.excluirButton.BackColor = System.Drawing.Color.Teal;
            this.excluirButton.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluirButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.excluirButton.Location = new System.Drawing.Point(181, 6);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(75, 23);
            this.excluirButton.TabIndex = 15;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = false;
            this.excluirButton.Click += new System.EventHandler(this.excluirButton_Click);
            // 
            // inserirButton
            // 
            this.inserirButton.BackColor = System.Drawing.Color.Teal;
            this.inserirButton.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inserirButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.inserirButton.Location = new System.Drawing.Point(19, 6);
            this.inserirButton.Name = "inserirButton";
            this.inserirButton.Size = new System.Drawing.Size(75, 23);
            this.inserirButton.TabIndex = 14;
            this.inserirButton.Text = "Inserir";
            this.inserirButton.UseVisualStyleBackColor = false;
            this.inserirButton.Click += new System.EventHandler(this.inserirButton_Click);
            // 
            // alterarButton
            // 
            this.alterarButton.BackColor = System.Drawing.Color.Teal;
            this.alterarButton.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alterarButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.alterarButton.Location = new System.Drawing.Point(100, 6);
            this.alterarButton.Name = "alterarButton";
            this.alterarButton.Size = new System.Drawing.Size(75, 23);
            this.alterarButton.TabIndex = 13;
            this.alterarButton.Text = "Alterar";
            this.alterarButton.UseVisualStyleBackColor = false;
            this.alterarButton.Click += new System.EventHandler(this.alterarButton_Click);
            // 
            // fecharButton
            // 
            this.fecharButton.BackColor = System.Drawing.Color.Teal;
            this.fecharButton.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecharButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.fecharButton.Location = new System.Drawing.Point(262, 6);
            this.fecharButton.Name = "fecharButton";
            this.fecharButton.Size = new System.Drawing.Size(75, 23);
            this.fecharButton.TabIndex = 12;
            this.fecharButton.Text = "Fechar";
            this.fecharButton.UseVisualStyleBackColor = false;
            this.fecharButton.Click += new System.EventHandler(this.fecharButton_Click);
            // 
            // botoesPanel
            // 
            this.botoesPanel.Controls.Add(this.excluirButton);
            this.botoesPanel.Controls.Add(this.inserirButton);
            this.botoesPanel.Controls.Add(this.alterarButton);
            this.botoesPanel.Controls.Add(this.fecharButton);
            this.botoesPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.botoesPanel.Location = new System.Drawing.Point(0, 94);
            this.botoesPanel.Name = "botoesPanel";
            this.botoesPanel.Size = new System.Drawing.Size(800, 36);
            this.botoesPanel.TabIndex = 6;
            // 
            // categoriasDataGridView
            // 
            this.categoriasDataGridView.AllowUserToAddRows = false;
            this.categoriasDataGridView.AllowUserToDeleteRows = false;
            this.categoriasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categoriasDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.categoriasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriasDataGridView.Location = new System.Drawing.Point(0, 130);
            this.categoriasDataGridView.MultiSelect = false;
            this.categoriasDataGridView.Name = "categoriasDataGridView";
            this.categoriasDataGridView.ReadOnly = true;
            this.categoriasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categoriasDataGridView.Size = new System.Drawing.Size(800, 320);
            this.categoriasDataGridView.TabIndex = 7;
            // 
            // ProdutosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.categoriasDataGridView);
            this.Controls.Add(this.botoesPanel);
            this.Controls.Add(this.topPanel);
            this.Name = "ProdutosForm";
            this.Text = "Pet Love Sytems - Sistema de gestão para Clinica Veterinaria";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.botoesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoriasDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button listarButton;
        private System.Windows.Forms.TextBox filtroNomeTextBox;
        private System.Windows.Forms.Label filtroNomeLabel;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.RadioButton filtroInativoRadioButton;
        private System.Windows.Forms.RadioButton filtroAtivoRadioButton;
        private System.Windows.Forms.RadioButton filtroTodosRadioButton;
        private System.Windows.Forms.Label filtroStatusLabel;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button inserirButton;
        private System.Windows.Forms.Button alterarButton;
        private System.Windows.Forms.Button fecharButton;
        private System.Windows.Forms.Panel botoesPanel;
        private System.Windows.Forms.DataGridView categoriasDataGridView;
    }
}