namespace Validacoes
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
            this.TxtResu = new System.Windows.Forms.TextBox();
            this.RbnCPF = new System.Windows.Forms.RadioButton();
            this.RbnCNPJ = new System.Windows.Forms.RadioButton();
            this.BtnValid = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtResu
            // 
            this.TxtResu.Location = new System.Drawing.Point(277, 195);
            this.TxtResu.Multiline = true;
            this.TxtResu.Name = "TxtResu";
            this.TxtResu.Size = new System.Drawing.Size(290, 40);
            this.TxtResu.TabIndex = 0;
            // 
            // RbnCPF
            // 
            this.RbnCPF.AutoSize = true;
            this.RbnCPF.Location = new System.Drawing.Point(277, 78);
            this.RbnCPF.Name = "RbnCPF";
            this.RbnCPF.Size = new System.Drawing.Size(45, 17);
            this.RbnCPF.TabIndex = 1;
            this.RbnCPF.TabStop = true;
            this.RbnCPF.Text = "CPF";
            this.RbnCPF.UseVisualStyleBackColor = true;
            // 
            // RbnCNPJ
            // 
            this.RbnCNPJ.AutoSize = true;
            this.RbnCNPJ.Location = new System.Drawing.Point(497, 78);
            this.RbnCNPJ.Name = "RbnCNPJ";
            this.RbnCNPJ.Size = new System.Drawing.Size(52, 17);
            this.RbnCNPJ.TabIndex = 2;
            this.RbnCNPJ.TabStop = true;
            this.RbnCNPJ.Text = "CNPJ";
            this.RbnCNPJ.UseVisualStyleBackColor = true;
            // 
            // BtnValid
            // 
            this.BtnValid.Location = new System.Drawing.Point(277, 286);
            this.BtnValid.Name = "BtnValid";
            this.BtnValid.Size = new System.Drawing.Size(75, 23);
            this.BtnValid.TabIndex = 3;
            this.BtnValid.Text = "Validar";
            this.BtnValid.UseVisualStyleBackColor = true;
            this.BtnValid.Click += new System.EventHandler(this.BtnValid_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(497, 286);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "Sair";
            this.BtnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnValid);
            this.Controls.Add(this.RbnCNPJ);
            this.Controls.Add(this.RbnCPF);
            this.Controls.Add(this.TxtResu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtResu;
        private System.Windows.Forms.RadioButton RbnCPF;
        private System.Windows.Forms.RadioButton RbnCNPJ;
        private System.Windows.Forms.Button BtnValid;
        private System.Windows.Forms.Button BtnExit;
    }
}

