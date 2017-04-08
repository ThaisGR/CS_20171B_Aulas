namespace Views
{
    partial class Form1
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
            this.btnAdicionarAluno = new System.Windows.Forms.Button();
            this.btnListarAlunos = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdicionarAluno
            // 
            this.btnAdicionarAluno.Location = new System.Drawing.Point(13, 13);
            this.btnAdicionarAluno.Name = "btnAdicionarAluno";
            this.btnAdicionarAluno.Size = new System.Drawing.Size(259, 23);
            this.btnAdicionarAluno.TabIndex = 0;
            this.btnAdicionarAluno.Text = "Adicionar Aluno";
            this.btnAdicionarAluno.UseVisualStyleBackColor = true;
            this.btnAdicionarAluno.Click += new System.EventHandler(this.btnAdicionarAluno_Click);
            // 
            // btnListarAlunos
            // 
            this.btnListarAlunos.Location = new System.Drawing.Point(13, 43);
            this.btnListarAlunos.Name = "btnListarAlunos";
            this.btnListarAlunos.Size = new System.Drawing.Size(259, 23);
            this.btnListarAlunos.TabIndex = 1;
            this.btnListarAlunos.Text = "Listar Alunos";
            this.btnListarAlunos.UseVisualStyleBackColor = true;
            this.btnListarAlunos.Click += new System.EventHandler(this.btnListarAlunos_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(12, 101);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(259, 23);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir Aluno";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(12, 72);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(260, 23);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar Aluno";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnListarAlunos);
            this.Controls.Add(this.btnAdicionarAluno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionarAluno;
        private System.Windows.Forms.Button btnListarAlunos;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
    }
}

