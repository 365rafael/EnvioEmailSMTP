﻿namespace EnvioEmailSMTP
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmailDestinatario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmailAssunto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmailMensagem = new System.Windows.Forms.TextBox();
            this.btnEnviarEmail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o e-mail destinatário:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtEmailDestinatario
            // 
            this.txtEmailDestinatario.Location = new System.Drawing.Point(30, 73);
            this.txtEmailDestinatario.Name = "txtEmailDestinatario";
            this.txtEmailDestinatario.Size = new System.Drawing.Size(394, 20);
            this.txtEmailDestinatario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Assunto:";
            // 
            // txtEmailAssunto
            // 
            this.txtEmailAssunto.Location = new System.Drawing.Point(33, 145);
            this.txtEmailAssunto.Name = "txtEmailAssunto";
            this.txtEmailAssunto.Size = new System.Drawing.Size(394, 20);
            this.txtEmailAssunto.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mensagem:";
            // 
            // txtEmailMensagem
            // 
            this.txtEmailMensagem.Location = new System.Drawing.Point(36, 225);
            this.txtEmailMensagem.Multiline = true;
            this.txtEmailMensagem.Name = "txtEmailMensagem";
            this.txtEmailMensagem.Size = new System.Drawing.Size(394, 163);
            this.txtEmailMensagem.TabIndex = 5;
            // 
            // btnEnviarEmail
            // 
            this.btnEnviarEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarEmail.Location = new System.Drawing.Point(146, 406);
            this.btnEnviarEmail.Name = "btnEnviarEmail";
            this.btnEnviarEmail.Size = new System.Drawing.Size(159, 32);
            this.btnEnviarEmail.TabIndex = 6;
            this.btnEnviarEmail.Text = "Enviar e-mail";
            this.btnEnviarEmail.UseVisualStyleBackColor = true;
            this.btnEnviarEmail.Click += new System.EventHandler(this.btnEnviarEmail_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 450);
            this.Controls.Add(this.btnEnviarEmail);
            this.Controls.Add(this.txtEmailMensagem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmailAssunto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmailDestinatario);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Enviar e-mail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmailDestinatario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmailAssunto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmailMensagem;
        private System.Windows.Forms.Button btnEnviarEmail;
    }
}

