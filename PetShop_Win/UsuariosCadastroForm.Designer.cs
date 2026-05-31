namespace PetShop_Win
{
    partial class UsuariosCadastroForm
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
            this.tituloLabel = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.cargoTextBox = new System.Windows.Forms.TextBox();
            this.cargoLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.salvarButton = new System.Windows.Forms.Button();
            this.fecharButton = new System.Windows.Forms.Button();
            this.senhaLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.produtosCheckBox = new System.Windows.Forms.CheckBox();
            this.clientesCheckBox = new System.Windows.Forms.CheckBox();
            this.categoriasCheckBox = new System.Windows.Forms.CheckBox();
            this.adminCheckBox = new System.Windows.Forms.CheckBox();
            this.topPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tituloLabel.Location = new System.Drawing.Point(12, 9);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(252, 30);
            this.tituloLabel.TabIndex = 8;
            this.tituloLabel.Text = "Cadastro de Usuario";
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Teal;
            this.topPanel.Controls.Add(this.panel2);
            this.topPanel.Controls.Add(this.tituloLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(396, 62);
            this.topPanel.TabIndex = 64;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(336, 0);
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
            // senhaTextBox
            // 
            this.senhaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.senhaTextBox.Location = new System.Drawing.Point(12, 200);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(364, 20);
            this.senhaTextBox.TabIndex = 61;
            // 
            // loginTextBox
            // 
            this.loginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginTextBox.Location = new System.Drawing.Point(12, 160);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(364, 20);
            this.loginTextBox.TabIndex = 60;
            // 
            // cargoTextBox
            // 
            this.cargoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cargoTextBox.Location = new System.Drawing.Point(148, 120);
            this.cargoTextBox.Name = "cargoTextBox";
            this.cargoTextBox.Size = new System.Drawing.Size(228, 20);
            this.cargoTextBox.TabIndex = 59;
            // 
            // cargoLabel
            // 
            this.cargoLabel.AutoSize = true;
            this.cargoLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargoLabel.Location = new System.Drawing.Point(145, 104);
            this.cargoLabel.Name = "cargoLabel";
            this.cargoLabel.Size = new System.Drawing.Size(40, 14);
            this.cargoLabel.TabIndex = 58;
            this.cargoLabel.Text = "Cargo";
            // 
            // idTextBox
            // 
            this.idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTextBox.Location = new System.Drawing.Point(12, 120);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(130, 20);
            this.idTextBox.TabIndex = 56;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(9, 104);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(20, 14);
            this.idLabel.TabIndex = 57;
            this.idLabel.Text = "ID";
            // 
            // salvarButton
            // 
            this.salvarButton.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvarButton.Location = new System.Drawing.Point(220, 249);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(75, 23);
            this.salvarButton.TabIndex = 53;
            this.salvarButton.Text = "Salvar";
            this.salvarButton.UseVisualStyleBackColor = true;
            this.salvarButton.Click += new System.EventHandler(this.salvarButton_Click);
            // 
            // fecharButton
            // 
            this.fecharButton.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecharButton.Location = new System.Drawing.Point(301, 249);
            this.fecharButton.Name = "fecharButton";
            this.fecharButton.Size = new System.Drawing.Size(75, 23);
            this.fecharButton.TabIndex = 55;
            this.fecharButton.Text = "Fechar";
            this.fecharButton.UseVisualStyleBackColor = true;
            this.fecharButton.Click += new System.EventHandler(this.fecharButton_Click);
            // 
            // senhaLabel
            // 
            this.senhaLabel.AutoSize = true;
            this.senhaLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaLabel.Location = new System.Drawing.Point(9, 183);
            this.senhaLabel.Name = "senhaLabel";
            this.senhaLabel.Size = new System.Drawing.Size(40, 14);
            this.senhaLabel.TabIndex = 54;
            this.senhaLabel.Text = "Senha";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(9, 143);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(40, 14);
            this.loginLabel.TabIndex = 52;
            this.loginLabel.Text = "Login";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeTextBox.Location = new System.Drawing.Point(12, 81);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(364, 20);
            this.nomeTextBox.TabIndex = 50;
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeLabel.Location = new System.Drawing.Point(9, 65);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(39, 14);
            this.nomeLabel.TabIndex = 51;
            this.nomeLabel.Text = "Nome";
            // 
            // produtosCheckBox
            // 
            this.produtosCheckBox.AutoSize = true;
            this.produtosCheckBox.Location = new System.Drawing.Point(12, 227);
            this.produtosCheckBox.Name = "produtosCheckBox";
            this.produtosCheckBox.Size = new System.Drawing.Size(68, 17);
            this.produtosCheckBox.TabIndex = 65;
            this.produtosCheckBox.Text = "Produtos";
            this.produtosCheckBox.UseVisualStyleBackColor = true;
            this.produtosCheckBox.CheckedChanged += new System.EventHandler(this.produtosCheckBox_CheckedChanged);
            // 
            // clientesCheckBox
            // 
            this.clientesCheckBox.AutoSize = true;
            this.clientesCheckBox.Location = new System.Drawing.Point(102, 227);
            this.clientesCheckBox.Name = "clientesCheckBox";
            this.clientesCheckBox.Size = new System.Drawing.Size(63, 17);
            this.clientesCheckBox.TabIndex = 66;
            this.clientesCheckBox.Text = "Clientes";
            this.clientesCheckBox.UseVisualStyleBackColor = true;
            this.clientesCheckBox.CheckedChanged += new System.EventHandler(this.clientesCheckBox_CheckedChanged);
            // 
            // categoriasCheckBox
            // 
            this.categoriasCheckBox.AutoSize = true;
            this.categoriasCheckBox.Location = new System.Drawing.Point(190, 227);
            this.categoriasCheckBox.Name = "categoriasCheckBox";
            this.categoriasCheckBox.Size = new System.Drawing.Size(76, 17);
            this.categoriasCheckBox.TabIndex = 67;
            this.categoriasCheckBox.Text = "Categorias";
            this.categoriasCheckBox.UseVisualStyleBackColor = true;
            this.categoriasCheckBox.CheckedChanged += new System.EventHandler(this.categoriasCheckBox_CheckedChanged);
            // 
            // adminCheckBox
            // 
            this.adminCheckBox.AutoSize = true;
            this.adminCheckBox.Location = new System.Drawing.Point(285, 227);
            this.adminCheckBox.Name = "adminCheckBox";
            this.adminCheckBox.Size = new System.Drawing.Size(91, 17);
            this.adminCheckBox.TabIndex = 68;
            this.adminCheckBox.Text = "Adiministrador";
            this.adminCheckBox.UseVisualStyleBackColor = true;
            this.adminCheckBox.CheckedChanged += new System.EventHandler(this.adminCheckBox_CheckedChanged);
            // 
            // UsuariosCadastroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 291);
            this.Controls.Add(this.adminCheckBox);
            this.Controls.Add(this.categoriasCheckBox);
            this.Controls.Add(this.clientesCheckBox);
            this.Controls.Add(this.produtosCheckBox);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.cargoTextBox);
            this.Controls.Add(this.cargoLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.salvarButton);
            this.Controls.Add(this.fecharButton);
            this.Controls.Add(this.senhaLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.nomeLabel);
            this.Name = "UsuariosCadastroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastre ou Edite um usuario";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox cargoTextBox;
        private System.Windows.Forms.Label cargoLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button salvarButton;
        private System.Windows.Forms.Button fecharButton;
        private System.Windows.Forms.Label senhaLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.CheckBox produtosCheckBox;
        private System.Windows.Forms.CheckBox clientesCheckBox;
        private System.Windows.Forms.CheckBox categoriasCheckBox;
        private System.Windows.Forms.CheckBox adminCheckBox;
    }
}