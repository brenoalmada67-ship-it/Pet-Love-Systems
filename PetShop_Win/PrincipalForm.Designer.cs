namespace PetShop_Win
{
    partial class PrincipalForm
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
            this.painelMenuLateralPanel = new System.Windows.Forms.Panel();
            this.usuariosButton = new FontAwesome.Sharp.IconButton();
            this.categoriasButton = new FontAwesome.Sharp.IconButton();
            this.produtosButton = new FontAwesome.Sharp.IconButton();
            this.agendamentosButton = new FontAwesome.Sharp.IconButton();
            this.clientesButton = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sairButton = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.S = new System.Windows.Forms.Label();
            this.painelConteudoPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.painelMenuLateralPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.painelConteudoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelMenuLateralPanel
            // 
            this.painelMenuLateralPanel.BackColor = System.Drawing.Color.Teal;
            this.painelMenuLateralPanel.Controls.Add(this.usuariosButton);
            this.painelMenuLateralPanel.Controls.Add(this.categoriasButton);
            this.painelMenuLateralPanel.Controls.Add(this.produtosButton);
            this.painelMenuLateralPanel.Controls.Add(this.agendamentosButton);
            this.painelMenuLateralPanel.Controls.Add(this.clientesButton);
            this.painelMenuLateralPanel.Controls.Add(this.panel2);
            this.painelMenuLateralPanel.Controls.Add(this.panel1);
            this.painelMenuLateralPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.painelMenuLateralPanel.Location = new System.Drawing.Point(0, 0);
            this.painelMenuLateralPanel.Name = "painelMenuLateralPanel";
            this.painelMenuLateralPanel.Size = new System.Drawing.Size(204, 450);
            this.painelMenuLateralPanel.TabIndex = 0;
            this.painelMenuLateralPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.painelMenuLateralPanel_Paint);
            // 
            // usuariosButton
            // 
            this.usuariosButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usuariosButton.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariosButton.IconChar = FontAwesome.Sharp.IconChar.UsersGear;
            this.usuariosButton.IconColor = System.Drawing.Color.Teal;
            this.usuariosButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.usuariosButton.IconSize = 30;
            this.usuariosButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usuariosButton.Location = new System.Drawing.Point(23, 358);
            this.usuariosButton.Name = "usuariosButton";
            this.usuariosButton.Size = new System.Drawing.Size(159, 37);
            this.usuariosButton.TabIndex = 12;
            this.usuariosButton.Text = "Usuarios";
            this.usuariosButton.UseVisualStyleBackColor = false;
            this.usuariosButton.Click += new System.EventHandler(this.usuariosButton_Click);
            // 
            // categoriasButton
            // 
            this.categoriasButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.categoriasButton.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriasButton.IconChar = FontAwesome.Sharp.IconChar.BoxesStacked;
            this.categoriasButton.IconColor = System.Drawing.Color.Teal;
            this.categoriasButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.categoriasButton.IconSize = 30;
            this.categoriasButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoriasButton.Location = new System.Drawing.Point(23, 161);
            this.categoriasButton.Name = "categoriasButton";
            this.categoriasButton.Size = new System.Drawing.Size(159, 37);
            this.categoriasButton.TabIndex = 11;
            this.categoriasButton.Text = "Categorias";
            this.categoriasButton.UseVisualStyleBackColor = false;
            this.categoriasButton.Click += new System.EventHandler(this.categoriasButton_Click);
            // 
            // produtosButton
            // 
            this.produtosButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.produtosButton.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produtosButton.IconChar = FontAwesome.Sharp.IconChar.Dog;
            this.produtosButton.IconColor = System.Drawing.Color.Teal;
            this.produtosButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.produtosButton.IconSize = 30;
            this.produtosButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.produtosButton.Location = new System.Drawing.Point(23, 247);
            this.produtosButton.Name = "produtosButton";
            this.produtosButton.Size = new System.Drawing.Size(159, 37);
            this.produtosButton.TabIndex = 10;
            this.produtosButton.Text = "Produtos";
            this.produtosButton.UseVisualStyleBackColor = false;
            this.produtosButton.Click += new System.EventHandler(this.produtosButton_Click);
            // 
            // agendamentosButton
            // 
            this.agendamentosButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.agendamentosButton.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agendamentosButton.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.agendamentosButton.IconColor = System.Drawing.Color.Teal;
            this.agendamentosButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.agendamentosButton.IconSize = 25;
            this.agendamentosButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agendamentosButton.Location = new System.Drawing.Point(23, 116);
            this.agendamentosButton.Name = "agendamentosButton";
            this.agendamentosButton.Size = new System.Drawing.Size(159, 39);
            this.agendamentosButton.TabIndex = 9;
            this.agendamentosButton.Text = "Agendamentos";
            this.agendamentosButton.UseVisualStyleBackColor = false;
            this.agendamentosButton.Click += new System.EventHandler(this.agendamentosButton_Click);
            // 
            // clientesButton
            // 
            this.clientesButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.clientesButton.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientesButton.IconChar = FontAwesome.Sharp.IconChar.UserTag;
            this.clientesButton.IconColor = System.Drawing.Color.Teal;
            this.clientesButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.clientesButton.IconSize = 30;
            this.clientesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientesButton.Location = new System.Drawing.Point(23, 204);
            this.clientesButton.Name = "clientesButton";
            this.clientesButton.Size = new System.Drawing.Size(159, 37);
            this.clientesButton.TabIndex = 0;
            this.clientesButton.Text = "Clientes";
            this.clientesButton.UseVisualStyleBackColor = false;
            this.clientesButton.Click += new System.EventHandler(this.clientesButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sairButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 401);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 49);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // sairButton
            // 
            this.sairButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sairButton.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairButton.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.sairButton.IconColor = System.Drawing.Color.Teal;
            this.sairButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sairButton.IconSize = 30;
            this.sairButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sairButton.Location = new System.Drawing.Point(47, 7);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(110, 30);
            this.sairButton.TabIndex = 13;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = false;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.S);
            this.panel1.Location = new System.Drawing.Point(3, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 32);
            this.panel1.TabIndex = 7;
            // 
            // S
            // 
            this.S.AutoSize = true;
            this.S.BackColor = System.Drawing.Color.WhiteSmoke;
            this.S.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S.Location = new System.Drawing.Point(3, 3);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(199, 29);
            this.S.TabIndex = 5;
            this.S.Text = "Pet Love Sytems";
            this.S.Click += new System.EventHandler(this.S_Click);
            // 
            // painelConteudoPanel
            // 
            this.painelConteudoPanel.Controls.Add(this.panel3);
            this.painelConteudoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelConteudoPanel.Location = new System.Drawing.Point(204, 0);
            this.painelConteudoPanel.Name = "painelConteudoPanel";
            this.painelConteudoPanel.Size = new System.Drawing.Size(596, 450);
            this.painelConteudoPanel.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(596, 450);
            this.panel3.TabIndex = 9;
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.painelConteudoPanel);
            this.Controls.Add(this.painelMenuLateralPanel);
            this.Name = "PrincipalForm";
            this.Text = "Pet Love Sytems - Sistema de gestão para Clinica Veterinaria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            this.painelMenuLateralPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.painelConteudoPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painelMenuLateralPanel;
        private System.Windows.Forms.Panel painelConteudoPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton clientesButton;
        private FontAwesome.Sharp.IconButton agendamentosButton;
        private FontAwesome.Sharp.IconButton categoriasButton;
        private FontAwesome.Sharp.IconButton produtosButton;
        private System.Windows.Forms.Label S;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton usuariosButton;
        private FontAwesome.Sharp.IconButton sairButton;
    }
}