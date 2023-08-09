namespace GeradorValidadorCPF
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
            this.LblDigitCpf = new System.Windows.Forms.Label();
            this.LblGeradorCPF = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtGerarCPF = new System.Windows.Forms.TextBox();
            this.BtnValidarCPF = new System.Windows.Forms.Button();
            this.BtnGerarCPF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblDigitCpf
            // 
            this.LblDigitCpf.AutoSize = true;
            this.LblDigitCpf.Font = new System.Drawing.Font("Elephant", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDigitCpf.Location = new System.Drawing.Point(253, 45);
            this.LblDigitCpf.Name = "LblDigitCpf";
            this.LblDigitCpf.Size = new System.Drawing.Size(253, 38);
            this.LblDigitCpf.TabIndex = 1;
            this.LblDigitCpf.Text = "Digite seu CPF";
            // 
            // LblGeradorCPF
            // 
            this.LblGeradorCPF.AutoSize = true;
            this.LblGeradorCPF.Font = new System.Drawing.Font("Elephant", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGeradorCPF.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblGeradorCPF.Location = new System.Drawing.Point(254, 279);
            this.LblGeradorCPF.Name = "LblGeradorCPF";
            this.LblGeradorCPF.Size = new System.Drawing.Size(253, 35);
            this.LblGeradorCPF.TabIndex = 0;
            this.LblGeradorCPF.Text = "Gerador de CPF";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(176, 110);
            this.txtCPF.Multiline = true;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(387, 52);
            this.txtCPF.TabIndex = 4;
            this.txtCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCPF.TextChanged += new System.EventHandler(this.txtCPF_TextChanged);
            // 
            // txtGerarCPF
            // 
            this.txtGerarCPF.Location = new System.Drawing.Point(176, 330);
            this.txtGerarCPF.Multiline = true;
            this.txtGerarCPF.Name = "txtGerarCPF";
            this.txtGerarCPF.Size = new System.Drawing.Size(387, 53);
            this.txtGerarCPF.TabIndex = 5;
            // 
            // BtnValidarCPF
            // 
            this.BtnValidarCPF.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnValidarCPF.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.BtnValidarCPF.Location = new System.Drawing.Point(284, 177);
            this.BtnValidarCPF.Name = "BtnValidarCPF";
            this.BtnValidarCPF.Size = new System.Drawing.Size(179, 62);
            this.BtnValidarCPF.TabIndex = 6;
            this.BtnValidarCPF.Text = "Validar CPF";
            this.BtnValidarCPF.UseVisualStyleBackColor = true;
            this.BtnValidarCPF.Click += new System.EventHandler(this.BtnValidarCPF_Click);
            // 
            // BtnGerarCPF
            // 
            this.BtnGerarCPF.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGerarCPF.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.BtnGerarCPF.Location = new System.Drawing.Point(284, 399);
            this.BtnGerarCPF.Name = "BtnGerarCPF";
            this.BtnGerarCPF.Size = new System.Drawing.Size(179, 62);
            this.BtnGerarCPF.TabIndex = 7;
            this.BtnGerarCPF.Text = "Gerar CPF";
            this.BtnGerarCPF.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 538);
            this.Controls.Add(this.BtnGerarCPF);
            this.Controls.Add(this.BtnValidarCPF);
            this.Controls.Add(this.txtGerarCPF);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.LblDigitCpf);
            this.Controls.Add(this.LblGeradorCPF);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblDigitCpf;
        private System.Windows.Forms.Label LblGeradorCPF;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtGerarCPF;
        private System.Windows.Forms.Button BtnValidarCPF;
        private System.Windows.Forms.Button BtnGerarCPF;
    }
}

