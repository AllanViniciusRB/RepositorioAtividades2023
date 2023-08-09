namespace AtividadeFORMS
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtResu
            // 
            this.TxtResu.Location = new System.Drawing.Point(222, 213);
            this.TxtResu.Multiline = true;
            this.TxtResu.Name = "TxtResu";
            this.TxtResu.Size = new System.Drawing.Size(350, 51);
            this.TxtResu.TabIndex = 0;
            // 
            // RbnCPF
            // 
            this.RbnCPF.AutoSize = true;
            this.RbnCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbnCPF.Location = new System.Drawing.Point(222, 148);
            this.RbnCPF.Name = "RbnCPF";
            this.RbnCPF.Size = new System.Drawing.Size(68, 28);
            this.RbnCPF.TabIndex = 1;
            this.RbnCPF.TabStop = true;
            this.RbnCPF.Text = "CPF";
            this.RbnCPF.UseVisualStyleBackColor = true;
            // 
            // RbnCNPJ
            // 
            this.RbnCNPJ.AutoSize = true;
            this.RbnCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbnCNPJ.Location = new System.Drawing.Point(492, 148);
            this.RbnCNPJ.Name = "RbnCNPJ";
            this.RbnCNPJ.Size = new System.Drawing.Size(80, 28);
            this.RbnCNPJ.TabIndex = 2;
            this.RbnCNPJ.TabStop = true;
            this.RbnCNPJ.Text = "CNPJ";
            this.RbnCNPJ.UseVisualStyleBackColor = true;
            // 
            // BtnValid
            // 
            this.BtnValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnValid.Location = new System.Drawing.Point(222, 306);
            this.BtnValid.Name = "BtnValid";
            this.BtnValid.Size = new System.Drawing.Size(108, 55);
            this.BtnValid.TabIndex = 3;
            this.BtnValid.Text = "Validar";
            this.BtnValid.UseVisualStyleBackColor = true;
            this.BtnValid.Click += new System.EventHandler(this.BtnValid_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Validador CPF e CNPJ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(462, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 55);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
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
    }
}

