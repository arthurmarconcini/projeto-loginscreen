
namespace loginscreen
{
    partial class CadastroPage
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
            this.btnCadSalvar = new System.Windows.Forms.Button();
            this.btnCadSair = new System.Windows.Forms.Button();
            this.lblCadNome = new System.Windows.Forms.Label();
            this.lblCadSenha = new System.Windows.Forms.Label();
            this.lblCadEmail = new System.Windows.Forms.Label();
            this.txtCadNome = new System.Windows.Forms.TextBox();
            this.txtCadSenha = new System.Windows.Forms.TextBox();
            this.txtCadEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCadSalvar
            // 
            this.btnCadSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadSalvar.Location = new System.Drawing.Point(149, 205);
            this.btnCadSalvar.Name = "btnCadSalvar";
            this.btnCadSalvar.Size = new System.Drawing.Size(120, 40);
            this.btnCadSalvar.TabIndex = 0;
            this.btnCadSalvar.Text = "Salvar";
            this.btnCadSalvar.UseVisualStyleBackColor = true;
            this.btnCadSalvar.Click += new System.EventHandler(this.btnCadSalvar_Click);
            // 
            // btnCadSair
            // 
            this.btnCadSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadSair.Location = new System.Drawing.Point(284, 205);
            this.btnCadSair.Name = "btnCadSair";
            this.btnCadSair.Size = new System.Drawing.Size(120, 40);
            this.btnCadSair.TabIndex = 1;
            this.btnCadSair.Text = "Sair";
            this.btnCadSair.UseVisualStyleBackColor = true;
            this.btnCadSair.Click += new System.EventHandler(this.btnCadSair_Click);
            // 
            // lblCadNome
            // 
            this.lblCadNome.AutoSize = true;
            this.lblCadNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadNome.Location = new System.Drawing.Point(71, 56);
            this.lblCadNome.Name = "lblCadNome";
            this.lblCadNome.Size = new System.Drawing.Size(84, 24);
            this.lblCadNome.TabIndex = 2;
            this.lblCadNome.Text = "Usuário: ";
            this.lblCadNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCadSenha
            // 
            this.lblCadSenha.AutoSize = true;
            this.lblCadSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadSenha.Location = new System.Drawing.Point(71, 101);
            this.lblCadSenha.Name = "lblCadSenha";
            this.lblCadSenha.Size = new System.Drawing.Size(70, 24);
            this.lblCadSenha.TabIndex = 3;
            this.lblCadSenha.Text = "Senha:";
            // 
            // lblCadEmail
            // 
            this.lblCadEmail.AutoSize = true;
            this.lblCadEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadEmail.Location = new System.Drawing.Point(71, 147);
            this.lblCadEmail.Name = "lblCadEmail";
            this.lblCadEmail.Size = new System.Drawing.Size(62, 24);
            this.lblCadEmail.TabIndex = 4;
            this.lblCadEmail.Text = "Email:";
            // 
            // txtCadNome
            // 
            this.txtCadNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadNome.Location = new System.Drawing.Point(149, 56);
            this.txtCadNome.Name = "txtCadNome";
            this.txtCadNome.Size = new System.Drawing.Size(255, 29);
            this.txtCadNome.TabIndex = 5;
            // 
            // txtCadSenha
            // 
            this.txtCadSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadSenha.Location = new System.Drawing.Point(149, 101);
            this.txtCadSenha.Name = "txtCadSenha";
            this.txtCadSenha.PasswordChar = '*';
            this.txtCadSenha.Size = new System.Drawing.Size(255, 29);
            this.txtCadSenha.TabIndex = 6;
            // 
            // txtCadEmail
            // 
            this.txtCadEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadEmail.Location = new System.Drawing.Point(149, 147);
            this.txtCadEmail.Name = "txtCadEmail";
            this.txtCadEmail.Size = new System.Drawing.Size(255, 29);
            this.txtCadEmail.TabIndex = 7;
            // 
            // CadastroPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(507, 298);
            this.Controls.Add(this.txtCadEmail);
            this.Controls.Add(this.txtCadSenha);
            this.Controls.Add(this.txtCadNome);
            this.Controls.Add(this.lblCadEmail);
            this.Controls.Add(this.lblCadSenha);
            this.Controls.Add(this.lblCadNome);
            this.Controls.Add(this.btnCadSair);
            this.Controls.Add(this.btnCadSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroPage";
            this.Text = "cadastroPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadSalvar;
        private System.Windows.Forms.Button btnCadSair;
        private System.Windows.Forms.Label lblCadNome;
        private System.Windows.Forms.Label lblCadSenha;
        private System.Windows.Forms.Label lblCadEmail;
        private System.Windows.Forms.TextBox txtCadNome;
        private System.Windows.Forms.TextBox txtCadSenha;
        private System.Windows.Forms.TextBox txtCadEmail;
    }
}