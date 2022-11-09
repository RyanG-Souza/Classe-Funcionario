namespace Classe_Funcionario
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btm_Cadastrar = new System.Windows.Forms.Button();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Idade = new System.Windows.Forms.Label();
            this.lbl_Setor = new System.Windows.Forms.Label();
            this.lbl_Data = new System.Windows.Forms.Label();
            this.lbl_Salário = new System.Windows.Forms.Label();
            this.txb_Nome = new System.Windows.Forms.TextBox();
            this.txb_Email = new System.Windows.Forms.TextBox();
            this.txb_Idade = new System.Windows.Forms.TextBox();
            this.txb_Setor = new System.Windows.Forms.TextBox();
            this.txb_Data = new System.Windows.Forms.TextBox();
            this.txb_Salário = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btm_Cadastrar
            // 
            this.btm_Cadastrar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm_Cadastrar.Location = new System.Drawing.Point(69, 228);
            this.btm_Cadastrar.Name = "btm_Cadastrar";
            this.btm_Cadastrar.Size = new System.Drawing.Size(122, 53);
            this.btm_Cadastrar.TabIndex = 0;
            this.btm_Cadastrar.Text = "Cadastrar";
            this.btm_Cadastrar.UseVisualStyleBackColor = true;
            this.btm_Cadastrar.Click += new System.EventHandler(this.btm_Cadastrar_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(30, 33);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(38, 15);
            this.lbl_nome.TabIndex = 1;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(30, 61);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(38, 15);
            this.lbl_Email.TabIndex = 2;
            this.lbl_Email.Text = "Email";
            // 
            // lbl_Idade
            // 
            this.lbl_Idade.AutoSize = true;
            this.lbl_Idade.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Idade.Location = new System.Drawing.Point(30, 87);
            this.lbl_Idade.Name = "lbl_Idade";
            this.lbl_Idade.Size = new System.Drawing.Size(35, 15);
            this.lbl_Idade.TabIndex = 3;
            this.lbl_Idade.Text = "Idade";
            // 
            // lbl_Setor
            // 
            this.lbl_Setor.AutoSize = true;
            this.lbl_Setor.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Setor.Location = new System.Drawing.Point(30, 113);
            this.lbl_Setor.Name = "lbl_Setor";
            this.lbl_Setor.Size = new System.Drawing.Size(37, 15);
            this.lbl_Setor.TabIndex = 4;
            this.lbl_Setor.Text = "Setor";
            // 
            // lbl_Data
            // 
            this.lbl_Data.AutoSize = true;
            this.lbl_Data.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Data.Location = new System.Drawing.Point(30, 142);
            this.lbl_Data.Name = "lbl_Data";
            this.lbl_Data.Size = new System.Drawing.Size(113, 15);
            this.lbl_Data.TabIndex = 5;
            this.lbl_Data.Text = "Data de contratação";
            // 
            // lbl_Salário
            // 
            this.lbl_Salário.AutoSize = true;
            this.lbl_Salário.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Salário.Location = new System.Drawing.Point(30, 172);
            this.lbl_Salário.Name = "lbl_Salário";
            this.lbl_Salário.Size = new System.Drawing.Size(82, 15);
            this.lbl_Salário.TabIndex = 6;
            this.lbl_Salário.Text = "Salário Bruto";
            // 
            // txb_Nome
            // 
            this.txb_Nome.Location = new System.Drawing.Point(149, 28);
            this.txb_Nome.Name = "txb_Nome";
            this.txb_Nome.Size = new System.Drawing.Size(112, 20);
            this.txb_Nome.TabIndex = 7;
            // 
            // txb_Email
            // 
            this.txb_Email.Location = new System.Drawing.Point(149, 54);
            this.txb_Email.Name = "txb_Email";
            this.txb_Email.Size = new System.Drawing.Size(112, 20);
            this.txb_Email.TabIndex = 7;
            // 
            // txb_Idade
            // 
            this.txb_Idade.Location = new System.Drawing.Point(149, 82);
            this.txb_Idade.Name = "txb_Idade";
            this.txb_Idade.Size = new System.Drawing.Size(112, 20);
            this.txb_Idade.TabIndex = 7;
            // 
            // txb_Setor
            // 
            this.txb_Setor.Location = new System.Drawing.Point(149, 108);
            this.txb_Setor.Name = "txb_Setor";
            this.txb_Setor.Size = new System.Drawing.Size(112, 20);
            this.txb_Setor.TabIndex = 7;
            // 
            // txb_Data
            // 
            this.txb_Data.Location = new System.Drawing.Point(149, 140);
            this.txb_Data.Name = "txb_Data";
            this.txb_Data.Size = new System.Drawing.Size(112, 20);
            this.txb_Data.TabIndex = 7;
            // 
            // txb_Salário
            // 
            this.txb_Salário.Location = new System.Drawing.Point(149, 170);
            this.txb_Salário.Name = "txb_Salário";
            this.txb_Salário.Size = new System.Drawing.Size(112, 20);
            this.txb_Salário.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 307);
            this.Controls.Add(this.txb_Salário);
            this.Controls.Add(this.txb_Data);
            this.Controls.Add(this.txb_Setor);
            this.Controls.Add(this.txb_Idade);
            this.Controls.Add(this.txb_Email);
            this.Controls.Add(this.txb_Nome);
            this.Controls.Add(this.lbl_Salário);
            this.Controls.Add(this.lbl_Data);
            this.Controls.Add(this.lbl_Setor);
            this.Controls.Add(this.lbl_Idade);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.btm_Cadastrar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btm_Cadastrar;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Idade;
        private System.Windows.Forms.Label lbl_Setor;
        private System.Windows.Forms.Label lbl_Data;
        private System.Windows.Forms.Label lbl_Salário;
        private System.Windows.Forms.TextBox txb_Nome;
        private System.Windows.Forms.TextBox txb_Email;
        private System.Windows.Forms.TextBox txb_Idade;
        private System.Windows.Forms.TextBox txb_Setor;
        private System.Windows.Forms.TextBox txb_Data;
        private System.Windows.Forms.TextBox txb_Salário;
    }
}

