namespace PetShop_Win
{
    partial class AgendamentosForm
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
            this.listarButton = new System.Windows.Forms.Button();
            this.filtroNomeTextBox = new System.Windows.Forms.TextBox();
            this.filtroNomeLabel = new System.Windows.Forms.Label();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.botoesPanel = new System.Windows.Forms.Panel();
            this.excluirButton = new System.Windows.Forms.Button();
            this.inserirButton = new System.Windows.Forms.Button();
            this.alterarButton = new System.Windows.Forms.Button();
            this.fecharButton = new System.Windows.Forms.Button();
            this.agendamentosDataGridView = new System.Windows.Forms.DataGridView();
            this.topPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.botoesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Teal;
            this.topPanel.Controls.Add(this.panel2);
            this.topPanel.Controls.Add(this.listarButton);
            this.topPanel.Controls.Add(this.filtroNomeTextBox);
            this.topPanel.Controls.Add(this.filtroNomeLabel);
            this.topPanel.Controls.Add(this.tituloLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(800, 94);
            this.topPanel.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(700, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 94);
            this.panel2.TabIndex = 18;
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
            // listarButton
            // 
            this.listarButton.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listarButton.Location = new System.Drawing.Point(317, 67);
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
            this.filtroNomeLabel.Size = new System.Drawing.Size(144, 14);
            this.filtroNomeLabel.TabIndex = 9;
            this.filtroNomeLabel.Text = "Digite o nome do Cliente";
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tituloLabel.Location = new System.Drawing.Point(12, 9);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(240, 40);
            this.tituloLabel.TabIndex = 8;
            this.tituloLabel.Text = "Agendamentos";
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
            this.botoesPanel.Size = new System.Drawing.Size(800, 37);
            this.botoesPanel.TabIndex = 9;
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
            // agendamentosDataGridView
            // 
            this.agendamentosDataGridView.AllowUserToAddRows = false;
            this.agendamentosDataGridView.AllowUserToDeleteRows = false;
            this.agendamentosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.agendamentosDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.agendamentosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.agendamentosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.agendamentosDataGridView.Location = new System.Drawing.Point(0, 131);
            this.agendamentosDataGridView.MultiSelect = false;
            this.agendamentosDataGridView.Name = "agendamentosDataGridView";
            this.agendamentosDataGridView.ReadOnly = true;
            this.agendamentosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.agendamentosDataGridView.Size = new System.Drawing.Size(800, 319);
            this.agendamentosDataGridView.TabIndex = 10;
            // 
            // AgendamentosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.agendamentosDataGridView);
            this.Controls.Add(this.botoesPanel);
            this.Controls.Add(this.topPanel);
            this.Name = "AgendamentosForm";
            this.Text = "Pet Love Sytems - Sistema de gestão para Clinica Veterinaria";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.botoesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.agendamentosDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button listarButton;
        private System.Windows.Forms.TextBox filtroNomeTextBox;
        private System.Windows.Forms.Label filtroNomeLabel;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel botoesPanel;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button inserirButton;
        private System.Windows.Forms.Button alterarButton;
        private System.Windows.Forms.Button fecharButton;
        private System.Windows.Forms.DataGridView agendamentosDataGridView;
    }
}